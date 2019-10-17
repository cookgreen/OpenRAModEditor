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
			Close();

			OraMod mod = new OraMod(txtModPath.Text);
			mod.ModID = config["MOD_ID"];
			mod.ModName = config["PACKAGING_WINDOWS_LAUNCHER_NAME"];
			mod.Version = config["ENGINE_VERSION"];
			mod.Author = config["PACKAGING_AUTHORS"];
			mod.modConfig = config;
			mod.Open();

			frmMain mainWin = new frmMain(mod);
			mainWin.ShowDialog();
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
					if (Directory.Exists(modPath) && File.Exists(modYamlPath))
					{
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
	}
}
