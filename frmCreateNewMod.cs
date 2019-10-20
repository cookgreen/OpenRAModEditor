using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.IO.Compression;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace OpenRAModEditor
{
	public partial class frmCreateNewMod : Form, ICloseableForm
	{
		private OraMod mod;
		public frmCreateNewMod()
		{
			InitializeComponent();
		}

		public event Action<object> CloseForm;

		private void BtnCancel_Click(object sender, EventArgs e)
		{
			Close();
			CloseForm?.Invoke(this);
		}

		private void BtnCreate_Click(object sender, EventArgs e)
		{
			if (string.IsNullOrEmpty(txtPath.Text))
			{
				MessageBox.Show("You must select a valid mod path!", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
			}
			else if (cmbVersionList.SelectedItem == null)
			{
				MessageBox.Show("You must select a valid openra version!", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
			}
			else if(string.IsNullOrEmpty(txtModID.Text))
			{
				MessageBox.Show("You must enter a valid mod id!", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
			}
			else if (string.IsNullOrEmpty(txtModName.Text))
			{
				MessageBox.Show("You must enter a valid mod name!", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
			}
			else
			{
                DialogResult = DialogResult.OK;
				Close();

				string modFullPath = txtPath.Text + "\\" + txtModName.Text;
				if(!Directory.Exists(modFullPath))
				{
					Directory.CreateDirectory(modFullPath);
				}

				mod = new OraMod(txtPath.Text);
				mod.Version = cmbVersionList.SelectedItem.ToString();
				mod.Author = txtModAuthor.Text;
				mod.ModID = txtModID.Text;
				mod.ModName = txtModName.Text;
				mod.Create();

				DownloadTask downloadTask = new DownloadTask()
				{
					FileName = "OpenModSDK",
					FileSavePath = System.Environment.GetEnvironmentVariable("TEMP") + "\\OpenModSDK-" + cmbVersionList.SelectedItem.ToString() + ".zip",
					Url = "https://github.com/OpenRA/OpenRAModSDK/archive/" + cmbVersionList.SelectedItem.ToString() + ".zip"
				};

				frmDownload downloadingWin = new frmDownload(downloadTask);
				downloadingWin.afterDownload += DownloadingWin_afterDownload;
				downloadingWin.ShowDialog();
			}
		}

		private void DownloadingWin_afterDownload(string fileSavePath)
		{
			ZipFile.ExtractToDirectory(fileSavePath, mod.ModSDKPath);
			DirectoryInfo di = new DirectoryInfo(mod.ModSDKPath);
			var dii = di.EnumerateDirectories().ElementAt(0);
			var fileSystemInfos = dii.EnumerateFileSystemInfos();
			foreach (var fileSystemInfo in fileSystemInfos)
			{
				if (fileSystemInfo.Attributes == FileAttributes.Directory)
				{
					Directory.Move(fileSystemInfo.FullName, mod.ModSDKPath + "\\" + fileSystemInfo.Name);
				}
				else
				{
					File.Move(fileSystemInfo.FullName, mod.ModSDKPath + "\\" + fileSystemInfo.Name);
				}
			}
			Directory.Delete(dii.FullName, true);

			string modConfigFile = mod.ModSDKPath + "\\mod.config";
			mod.modConfig = ModConfigEditor.Instance.ReadConfig(modConfigFile);

			//Modify the mod.config file
			mod.modConfig["MOD_ID"] = mod.ModID;
			mod.modConfig["PACKAGING_WINDOWS_LAUNCHER_NAME"] = mod.ModName;
			mod.modConfig["PACKAGING_AUTHORS"] = mod.Author;
			ModConfigEditor.Instance.WriteConfig(mod.modConfig, modConfigFile);

			//Rename the mod directory name
			string defaultModDirectory = Path.Combine(mod.ModSDKPath, "mods\\example");
			string currentModDirectory = Path.Combine(mod.ModSDKPath, "mods\\" + mod.ModID);
			Directory.CreateDirectory(currentModDirectory);
			DirectoryInfo di2 = new DirectoryInfo(defaultModDirectory);
			foreach (var fileSystemInfo in di2.EnumerateFileSystemInfos())
			{
				if (fileSystemInfo.Attributes == FileAttributes.Directory)
				{
					Directory.Move(fileSystemInfo.FullName, currentModDirectory + "\\" + fileSystemInfo.Name);
				}
				else
				{
					File.Copy(fileSystemInfo.FullName, currentModDirectory + "\\" + fileSystemInfo.Name);
				}
			}
			Directory.Delete(defaultModDirectory, true);

			//Rename the project file name

			//Rename the project directory name

			//Rename the Solution file name

			//Modify the Solution content to match the project

			frmMain mainWindow = new frmMain(mod.Project);
			mainWindow.Show();
		}

		private void BtnBrowse_Click(object sender, EventArgs e)
		{
			FolderBrowserDialog dialog = new FolderBrowserDialog();
			if (dialog.ShowDialog() == DialogResult.OK)
			{
				txtPath.Text = dialog.SelectedPath;
			}
		}

        private void FrmCreateNewMod_FormClosed(object sender, FormClosedEventArgs e)
        {
            Close();
            if (DialogResult != DialogResult.OK)
            {
                CloseForm?.Invoke(this);
            }
        }
    }
}
