using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace OpenRAModEditor
{
	public partial class frmMain : Form
	{
		private OraMod mod;
		private OraModEditorProject project;
		private Dictionary<TreeNode, string> nodePathDic;
		private Dictionary<string, MiniYaml> miniYamls;
		private Timer timer;
		private OraModRuntime runtime;
		public GroupBox MainPanel
		{
			get
			{
				return gbMain;
			}
		}

		public frmMain(OraModEditorProject project)
		{
			InitializeComponent();
			this.project = project;
			this.mod = project.Mod;
			nodePathDic = new Dictionary<TreeNode, string>();
			miniYamls = new Dictionary<string, MiniYaml>();
			timer = new Timer();
			timer.Interval = 100;
			timer.Tick += Timer_Tick;
			timer.Start();
			runtime = new OraModRuntime(mod);
			runtime.RunStateChanged += Runtime_RunStateChanged;

			mnuLanguages.DropDownItems.Clear();
			foreach(var locate in LanguageManager.Instance.GetLocates())
			{
				var locateMenuItem = mnuLanguages.DropDownItems.Add(LanguageManager.Instance.GetTranslation(locate));
				locateMenuItem.Click += (o, e) =>
				{
					LanguageManager.Instance.AppConfig.Localization = LanguageManager.Instance.GetLocateByTranslation(locateMenuItem.Text);
					LanguageManager.Instance.AppConfig.Save();
				};
			}

			InitializeMod();

			InitLanguageOptions();
		}

		private void InitLanguageOptions()
		{
			Text = LanguageManager.Instance.GetLocalizedString("ui_control_panel_title");
			mnuFile.Text = LanguageManager.Instance.GetLocalizedString("ui_main_window_menu_file");
			mnuExit.Text = LanguageManager.Instance.GetLocalizedString("ui_main_window_menu_file_exit");
			mnuMod.Text = LanguageManager.Instance.GetLocalizedString("ui_main_window_menu_mod");
			mnuRunMod.Text = LanguageManager.Instance.GetLocalizedString("ui_main_window_menu_mod_run");
			mnuTools.Text = LanguageManager.Instance.GetLocalizedString("ui_main_window_menu_tool");
			mnuSettings.Text = LanguageManager.Instance.GetLocalizedString("ui_main_window_menu_tool_settings");
			mnuBasicInformation.Text = LanguageManager.Instance.GetLocalizedString("ui_main_window_menu_tool_basic_info");
			mnuLanguages.Text = LanguageManager.Instance.GetLocalizedString("ui_main_window_menu_tool_languages");
			mnuHelp.Text = LanguageManager.Instance.GetLocalizedString("ui_main_window_menu_help");
			mnuOpenRAWiki.Text = LanguageManager.Instance.GetLocalizedString("ui_main_window_menu_help_openra_wiki");
			mnuOpenRATraitWiki.Text = LanguageManager.Instance.GetLocalizedString("ui_main_window_menu_help_openra_traits_wiki");
			mnuAbout.Text = LanguageManager.Instance.GetLocalizedString("ui_main_window_menu_help_about");
			groupBox1.Text = LanguageManager.Instance.GetLocalizedString("ui_main_window_file_list");
		}

		private void InitializeMod()
		{
			modFileList.Nodes.Clear();

			TreeNode modTreeNode = modFileList.Nodes.Add(mod.ModID);
			DirectoryInfo di = new DirectoryInfo(mod.ModPath);
			foreach (var fileSystem in di.EnumerateFileSystemInfos())
			{
				TreeNode treeNode = null;
				if (fileSystem.Attributes == FileAttributes.Directory)
				{
					treeNode = modTreeNode.Nodes.Add(fileSystem.Name);
					treeNode.ImageIndex = 0;
					treeNode.Nodes.Add("Refreshing");
					nodePathDic.Add(treeNode, fileSystem.FullName);
				}
				else
				{
					treeNode = modTreeNode.Nodes.Add(fileSystem.Name);
					nodePathDic.Add(treeNode, fileSystem.FullName);
					if (fileSystem.Extension == ".yaml")
					{
						treeNode.ImageIndex = 2;
						miniYamls.Add(fileSystem.FullName, new MiniYaml(fileSystem.FullName));
					}
					else
					{
						treeNode.ImageIndex = 1;
					}
				}
			}
			modTreeNode.Expand();
		}

		private void FrmMain_FormClosed(object sender, FormClosedEventArgs e)
		{
			if(runtime.StillRunning)
			{
				if (MessageBox.Show("There is still running process, do you want to force stop all running processes?",
					"Warning", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
				{
					runtime.Stop();
				}
            }
            DownloadManager.Instance.Stop();
            project.Save(project.Mod.ModSDKPath + "\\.project");
            Application.Exit();
        }

		private void ModFileList_AfterExpand(object sender, TreeViewEventArgs e)
		{
			if (e.Node != null && e.Node.Nodes.Count > 0 && nodePathDic.ContainsKey(e.Node))
			{
				e.Node.Nodes.Clear();
					
				DirectoryInfo di = new DirectoryInfo(nodePathDic[e.Node]);
				foreach (var fileSystem in di.EnumerateFileSystemInfos())
				{
					TreeNode treeNode = null;
					if (fileSystem.Attributes == FileAttributes.Directory)
					{
						treeNode = e.Node.Nodes.Add(fileSystem.Name);
						treeNode.ImageIndex = 0;
						treeNode.Nodes.Add("Refreshing");
						if (!nodePathDic.ContainsKey(treeNode))
						{
							nodePathDic.Add(treeNode, fileSystem.FullName);
						}
					}
					else
					{
						treeNode = e.Node.Nodes.Add(fileSystem.Name);
						if (!nodePathDic.ContainsKey(treeNode))
						{
							nodePathDic.Add(treeNode, fileSystem.FullName);
						}
						if (fileSystem.Extension == ".yaml")
						{
							treeNode.ImageIndex = 2;
							if (!miniYamls.ContainsKey(fileSystem.FullName))
							{
								miniYamls.Add(fileSystem.FullName, new MiniYaml(fileSystem.FullName));
							}
						}
						else
						{
							treeNode.ImageIndex = 1;
						}
					}
				}
			}
		}

		private void ModFileList_AfterSelect(object sender, TreeViewEventArgs e)
		{
			if (e.Node != null && nodePathDic.ContainsKey(e.Node))
			{
				string fullPath = nodePathDic[e.Node];
				if (!string.IsNullOrEmpty(Path.GetExtension(fullPath)) && 
					Path.GetExtension(fullPath) == ".yaml")
				{
					if (mod.Manifest.Chrome.ContainsKey(e.Node.Text) &&
						mod.Manifest.Chrome[e.Node.Text] == fullPath)
					{
						ctrlChromeEditor ctrlChromeEditor = new ctrlChromeEditor(mod, e.Node.Text);
						MainPanel.Controls.Clear();
						MainPanel.Controls.Add(ctrlChromeEditor);
						ctrlChromeEditor.Dock = DockStyle.Fill;
					}
					else
					{
						MiniYaml yaml = miniYamls[fullPath];
						ctrlVisualYamlEditor yamlEditor = new ctrlVisualYamlEditor(yaml);
						MainPanel.Controls.Clear();
						MainPanel.Controls.Add(yamlEditor);
						yamlEditor.Dock = DockStyle.Fill;
					}
				}
			}
		}

		private void MnuExit_Click(object sender, EventArgs e)
		{
			Application.Exit();
		}

		private void MenuBasicInfomation_Click(object sender, EventArgs e)
		{
			frmBasicInfoEditor basicInfoEditorWin = new frmBasicInfoEditor(mod);
			basicInfoEditorWin.ShowDialog();
		}

		private void MnuOpenRAWiki_Click(object sender, EventArgs e)
		{

		}

		private void MnuOpenRATraitWiki_Click(object sender, EventArgs e)
		{

		}

		private void MnuAbout_Click(object sender, EventArgs e)
		{

		}

		private void MnuRunMod_Click(object sender, EventArgs e)
		{
			string reason;
			if(runtime.CompileAsync(out reason))
			{

			}
		}

		private void BtnRunMod_Click(object sender, EventArgs e)
		{
			string reason;
			if (runtime.CompileAsync(out reason))
			{

			}
		}

		private void MnuSettings_Click(object sender, EventArgs e)
		{
			frmSettings settingsWin = new frmSettings(project);
			settingsWin.ShowDialog();
		}

		private void Timer_Tick(object sender, EventArgs e)
		{
		}

		private void Runtime_RunStateChanged(RuntimeState newState)
		{
			switch(newState)
			{
				case RuntimeState.Compiling:
					mnuRunMod.Enabled = false;
					btnRunMod.Enabled = false;
					break;
				case RuntimeState.Running:
					mnuRunMod.Enabled = false;
					btnRunMod.Enabled = false;
					break;
				case RuntimeState.Stop:
					mnuRunMod.Enabled = true;
					btnRunMod.Enabled = true;
					break;
			}
		}
	}
}
