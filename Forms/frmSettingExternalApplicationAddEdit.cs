using OpenRAModEditor.Interfaces;
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
	public partial class frmSettingExternalApplicationAddEdit : Form, ILocalization
	{
		private SettingExternalApplication externalApplication;

		public SettingExternalApplication ExternalApplication
		{
			get
			{
				return externalApplication;
			}
		}

		public frmSettingExternalApplicationAddEdit(SettingExternalApplication externalApplication, int mode)
		{
			InitializeComponent();
			this.externalApplication = externalApplication;
			switch (mode)
			{
				case 0:
					Text = "Add External App";
					txtExtension.Text = null;
					txtPath.Text = null;
					break;
				case 1:
					Text = "Edit External App";
					txtExtension.Text = externalApplication.Extension;
					txtPath.Text = externalApplication.Application;
					break;
			}

			InitLanguageOptions();
		}

		public void InitLanguageOptions()
		{
			lbExtension.Text = LanguageManager.Instance.GetLocalizedString("ui_setting_external_app_add_window_extension");
			lbAppPath.Text = LanguageManager.Instance.GetLocalizedString("ui_setting_external_app_add_window_Path");
			btnOK.Text = LanguageManager.Instance.GetLocalizedString("ui_ok");
			btnCancel.Text = LanguageManager.Instance.GetLocalizedString("ui_cancel");
		}

		private void BtnOK_Click(object sender, EventArgs e)
		{
			externalApplication = new SettingExternalApplication();
			externalApplication.Extension = txtExtension.Text;
			externalApplication.Application = txtPath.Text;
			DialogResult = DialogResult.OK;
			Close();
		}

		private void BtnCancel_Click(object sender, EventArgs e)
		{
			DialogResult = DialogResult.Cancel;
			Close();
		}

		private void BtnBrowse_Click(object sender, EventArgs e)
		{
			OpenFileDialog dialog = new OpenFileDialog();
			if (dialog.ShowDialog() == DialogResult.OK)
			{
				txtPath.Text = dialog.FileName;
			}
		}
	}
	public class SettingExternalApplication
	{
		public string Extension { get; set; }
		public string Application { get; set; }
	}
}
