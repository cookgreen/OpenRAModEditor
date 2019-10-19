using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Diagnostics;
using System.IO;
using System.IO.Compression;
using System.Linq;
using System.Net;
using System.Text;
using System.Threading.Tasks;

namespace OpenRAModEditor
{
	public enum RuntimeState
	{
		Compiling,
		Running,
		Stop
	}

	public class OraModRuntime
	{
		private Process runningProcess;
		private BackgroundWorker currentWorker;
		private RuntimeState state;
		private OraMod mod;
		private string modSDKCompileScript;
		private string modSDKRunScript;
		public bool StillRunning
		{
			get
			{
				return runningProcess != null;
			}
		}
		public event Action<RuntimeState> RunStateChanged;
		public OraModRuntime(OraMod mod)
		{
			this.mod = mod;
			state = RuntimeState.Stop;
			currentWorker = null;
		}

		public bool CompileAsync(out string reason)
		{
			reason = null;
			modSDKCompileScript = mod.ModSDKPath;
			modSDKRunScript = mod.ModSDKPath;
			OperatingSystem os = Environment.OSVersion;
			if (os.Platform == PlatformID.Win32NT)
			{
				modSDKCompileScript += "\\make.cmd";
				modSDKRunScript += "\\launch-game.cmd";
			}
			else if (os.Platform == PlatformID.Unix || os.Platform == PlatformID.MacOSX)
			{
				modSDKCompileScript += "\\Makefile";
				modSDKRunScript += "\\launch-game.sh";
			}

			if (File.Exists(modSDKCompileScript) && File.Exists(modSDKRunScript))
			{
				state = RuntimeState.Compiling;
				BackgroundWorker compileWorker = new BackgroundWorker();
				compileWorker.DoWork += CompileWorker_DoWork;
				compileWorker.RunWorkerCompleted += CompileWorker_RunWorkerCompleted;
				compileWorker.RunWorkerAsync();
				currentWorker = compileWorker;
				RunStateChanged?.Invoke(state);

				return true;
			}
			else
			{
				reason = "Mod SDK Compile or Run script missing!";
				return false;
			}
		}

		private void CompileWorker_DoWork(object sender, DoWorkEventArgs e)
		{
			var config = ModConfigEditor.Instance.ReadConfig(mod.ModSDKPath + "\\mod.config");
			string engineZipFile = mod.ModSDKPath + "\\engine.zip";
			string engineDirectory = mod.ModSDKPath + config["ENGINE_DIRECTORY"];
			string engineVersionFile = engineDirectory + "\\VERSION";
			string engineExecutableFile = engineDirectory + "\\OpenRA.Game.exe";
			DirectoryInfo di = new DirectoryInfo(engineDirectory);
			if (!Directory.Exists(engineDirectory) || !File.Exists(engineVersionFile))
			{
				downloadEngine(engineZipFile, di.FullName, config["ENGINE_VERSION"]);
			}
			else if(!File.Exists(engineExecutableFile))
			{
				compileEngine(di.FullName);
			}
			compileMod();
		}

		private void CompileWorker_RunWorkerCompleted(object sender, RunWorkerCompletedEventArgs e)
		{
			currentWorker = null;
			state = RuntimeState.Stop;
			RunStateChanged?.Invoke(state);

			BackgroundWorker runWorker = new BackgroundWorker();
			runWorker.DoWork += RunWorker_DoWork;
			runWorker.RunWorkerCompleted += RunWorker_RunWorkerCompleted;
			runWorker.RunWorkerAsync();
			currentWorker = runWorker;
			state = RuntimeState.Running;
			RunStateChanged?.Invoke(state);
		}

		private void RunWorker_DoWork(object sender, DoWorkEventArgs e)
		{
			
		}

		private void RunWorker_RunWorkerCompleted(object sender, RunWorkerCompletedEventArgs e)
		{
			currentWorker = null;
			state = RuntimeState.Stop;
			RunStateChanged?.Invoke(state);
		}

		private void downloadEngine(string engineZipFile, string engineDirectory, string engineVersion)
		{
			OutputManager.Instance.AddMessageToOutputer(string.Format("OpenRA {0} is required", engineVersion), "Compile");
			OutputManager.Instance.AddMessageToOutputer(string.Format("Downloading Engine...", engineVersion), "Compile");
			System.Net.ServicePointManager.SecurityProtocol = SecurityProtocolType.Tls12;
			WebClient client = new WebClient();
			client.DownloadFile(string.Format("https://github.com/OpenRA/OpenRA/archive/{0}.zip", engineVersion), engineZipFile);
			if (Directory.Exists(engineDirectory))
			{
				Directory.Delete(engineDirectory, true);
			}
			ZipFile.ExtractToDirectory(engineZipFile, engineDirectory);
			File.Delete(engineZipFile);
			DirectoryInfo di = new DirectoryInfo(engineDirectory);
			DirectoryInfo dii = di.EnumerateDirectories().ElementAt(0);
			foreach (var subFileFolder in dii.EnumerateFileSystemInfos())
			{
				if (subFileFolder.Attributes == FileAttributes.Directory)
				{
					Directory.Move(subFileFolder.FullName, engineDirectory + "\\" + subFileFolder.Name);
				}
				else
				{
					File.Move(subFileFolder.FullName, engineDirectory + "\\" + subFileFolder.Name);
				}
			}
			Directory.Delete(dii.FullName);

			compileEngine(di.FullName);
		}

		private void compileEngine(string engineFullPath)
		{

			Process makeProcess = new Process();
			makeProcess.StartInfo = new ProcessStartInfo();
			makeProcess.StartInfo.RedirectStandardError = true;
			makeProcess.StartInfo.RedirectStandardOutput = true;
			makeProcess.StartInfo.RedirectStandardInput = true;
			makeProcess.StartInfo.UseShellExecute = false;
			makeProcess.StartInfo.FileName = "powershell.exe";
			List<string> commands = new List<string>()
			{
				"cd " + engineFullPath,
				"set-executionpolicy -executionpolicy unrestricted",
				".\\make.ps1",
				"all"
			};
			makeProcess.Start();
			runningProcess = makeProcess;
			foreach (var command in commands)
			{
				makeProcess.StandardInput.WriteLine(command);
			}
			while (!makeProcess.HasExited)
			{
				string line = makeProcess.StandardOutput.ReadLine();
				if (!string.IsNullOrEmpty(line))
				{
					OutputManager.Instance.AddMessageToOutputer(line, "Compile");
					if (line == "Press enter to continue. ")
					{
						makeProcess.StandardInput.WriteLine((char)13);
						break;
					}
				}
			}
			makeProcess.WaitForExit(1);
			runningProcess = null;
		}

		private void compileMod()
		{
			string modSDKPath = mod.ModSDKPath;

			Process compileModProcess = new Process();
			compileModProcess.StartInfo = new ProcessStartInfo();
			compileModProcess.StartInfo.RedirectStandardError = true;
			compileModProcess.StartInfo.RedirectStandardOutput = true;
			compileModProcess.StartInfo.RedirectStandardInput = true;
			compileModProcess.StartInfo.UseShellExecute = false;
			compileModProcess.StartInfo.FileName = "powershell.exe";
			List<string> commands = new List<string>()
			{
				"cd " + modSDKPath,
				"dotnet build /p:Configuration=Release /nologo",
			};
			compileModProcess.Start();
			runningProcess = compileModProcess;
			foreach (var command in commands)
			{
				compileModProcess.StandardInput.WriteLine(command);
			}
			while (!compileModProcess.HasExited)
			{
				string line = compileModProcess.StandardOutput.ReadLine();
				if (!string.IsNullOrEmpty(line))
				{
					OutputManager.Instance.AddMessageToOutputer(line, "Compile");
				}
			}
			compileModProcess.WaitForExit(1);
			runningProcess = null;
		}

		public void Stop()
		{
			if (runningProcess != null)
			{
				runningProcess.WaitForExit(1);
			}
		}
	}
}
