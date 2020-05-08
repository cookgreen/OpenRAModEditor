using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace OpenRAModEditor
{
	public partial class frmBasicInfoEditor : Form
	{
		private OraMod mod;
		public frmBasicInfoEditor(OraMod mod)
		{
			InitializeComponent();
			this.mod = mod;

			txtModID.Text = mod.ModID;
			txtEngineVersion.Text = mod.modConfig["ENGINE_VERSION"];
			txtModAssembly.Text = mod.modConfig["WHITELISTED_MOD_ASSEMBLIES"];
			txtPackagingAuthor.Text = mod.Author;
			txtPackingInstallerName.Text = mod.ModName;

			InitLanguageOptions();
		}

		private void InitLanguageOptions()
		{
			lbModID.Text = LanguageManager.Instance.GetLocalizedString("ui_mod_basic_info_editor_mod_id");
			lbEngineVersion.Text = LanguageManager.Instance.GetLocalizedString("ui_mod_basic_info_editor_engine_version");
			lbModAssembly.Text = LanguageManager.Instance.GetLocalizedString("ui_mod_basic_info_editor_mod_assembly");
			lbPackagingInstallerName.Text = LanguageManager.Instance.GetLocalizedString("ui_mod_basic_info_editor_packaging_installer_name");
			lbPackagingAuthor.Text = LanguageManager.Instance.GetLocalizedString("ui_mod_basic_info_editor_packaging_author");
			btnOpenModConfig.Text = LanguageManager.Instance.GetLocalizedString("ui_open_mod_config");
			btnOK.Text = LanguageManager.Instance.GetLocalizedString("ui_ok");
			btnCancel.Text = LanguageManager.Instance.GetLocalizedString("ui_cancel");
		}

		private void BtnOpenModConfig_Click(object sender, EventArgs e)
		{
			
		}

		private void BtnOK_Click(object sender, EventArgs e)
		{

		}

		private void BtnCancel_Click(object sender, EventArgs e)
		{
			Close();
		}
	}
}
