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
	public partial class frmOpenMod : Form, ICloseableForm
	{
		private ModConfig config;
		public event Action<object> CloseForm;
		public frmOpenMod()
		{
			InitializeComponent();
		}

		private void BtnCancel_Click(object sender, EventArgs e)
		{
			Close();
			CloseForm?.Invoke(this);
		}

		private void BtnOpen_Click(object sender, EventArgs e)
		{
            DialogResult = DialogResult.OK;
			Close();

			OraMod mod = new OraMod(txtModPath.Text);
			mod.ModID = config["MOD_ID"];
			mod.ModName = config["PACKAGING_WINDOWS_LAUNCHER_NAME"];
			mod.Version = config["ENGINE_VERSION"];
			mod.Author = config["PACKAGING_AUTHORS"];
			mod.modConfig = config;
			var project = mod.Open();

			mod.Init();

			frmMain mainWin = new frmMain(project);
			mainWin.Show();
		}

		private void BtnBrowse_Click(object sender, EventArgs e)
		{
			FolderBrowserDialog dialog = new FolderBrowserDialog();
			if (dialog.ShowDialog() == DialogResult.OK)
			{
				txtModPath.Text = dialog.SelectedPath;
				if (!ValidModSDKPath(txtModPath.Text, out config))
				{
					btnOpen.Enabled = false;
					txtVersion.Text = "Invalid mod sdk path";
				}
				else
				{
					btnOpen.Enabled = true;
					txtVersion.Text = config["ENGINE_VERSION"];
				}
			}
		}

		private bool ValidModSDKPath(string path, out ModConfig config)
		{
			config = null;
			DirectoryInfo di = new DirectoryInfo(path);
			var result = di.EnumerateFiles("mod.config");
			if (result.Count() == 0)
			{
				return false;
			}
			else
			{
				config = ModConfigEditor.Instance.ReadConfig(result.ElementAt(0).FullName);
				if (config != null && config["MOD_ID"] != null)
				{
					string modID = config["MOD_ID"];
					string modPath = path + "\\mods\\" + modID;
					string modYamlPath = modPath + "\\mod.yaml";
					string modEditorProjectPath = path + "\\.project";
					if (Directory.Exists(modPath) && File.Exists(modYamlPath))
					{
						if (!File.Exists(modEditorProjectPath))
						{
							OraModEditorProject editorProject = new OraModEditorProject();
							editorProject.BasicInfo.ModID = modID;
							editorProject.BasicInfo.Name = config["PACKAGING_WINDOWS_LAUNCHER_NAME"];
							editorProject.BasicInfo.EngineVersion = config["ENGINE_VERSION"];
							editorProject.BasicInfo.Author = config["PACKAGING_AUTHORS"];
							editorProject.Save(modEditorProjectPath);
						}

						return true;
					}
					else
					{
						return false;
					}
				}
				else
				{
					return false;
				}
			}
		}

        private void FrmOpenMod_FormClosed(object sender, FormClosedEventArgs e)
        {
            Close();
            if (DialogResult != DialogResult.OK)
            {
                CloseForm?.Invoke(this);
            }
        }
    }
}
