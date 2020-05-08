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
	public partial class frmChromeEditorAdd : Form, ILocalization
	{
		private OraMod oraMod;
		private MiniYaml chromeYaml;
		public string ChromeName { get; set; }
		public string Resource { get; set; }
		public frmChromeEditorAdd(OraMod oraMod, MiniYaml chromeYaml)
		{
			InitializeComponent();
			this.oraMod = oraMod;
			this.chromeYaml = chromeYaml;

			InitLanguageOptions();
		}

		public void InitLanguageOptions()
		{
			lbChromeName.Text = LanguageManager.Instance.GetLocalizedString("ui_chrome_editor_add_chrome_name");
			lbChromeResource.Text = LanguageManager.Instance.GetLocalizedString("ui_chrome_editor_add_chrome_resource");
			btnOK.Text = LanguageManager.Instance.GetLocalizedString("ui_ok");
			btnCancel.Text = LanguageManager.Instance.GetLocalizedString("ui_cancel");
		}

		private void BtnChoose_Click(object sender, EventArgs e)
		{
			frmModResourceBrowser modResourceBrowser = new frmModResourceBrowser(oraMod);
			if (modResourceBrowser.ShowDialog() == DialogResult.OK)
			{
				txtResourcePath.Text = modResourceBrowser.SelectedResource;
			}
		}

		private void BtnOK_Click(object sender, EventArgs e)
		{
			if (!string.IsNullOrEmpty(txtChromeName.Text) &&
			   !string.IsNullOrEmpty(txtResourcePath.Text))
			{
				if (chromeYaml.Nodes.Where(o => o.Name == txtChromeName.Text).Count() == 0)
				{
					ChromeName = txtChromeName.Text;
					Resource = txtResourcePath.Text;
					DialogResult = DialogResult.OK;
					Close();
				}
				else
				{
					MessageBox.Show(string.Format("The node with name {0} has already existed!", txtChromeName.Text), "Error",
					 MessageBoxButtons.OK, MessageBoxIcon.Error);
				}
			}
			else
			{
				MessageBox.Show("Please verify your input!", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
			}
		}

		private void BtnCancel_Click(object sender, EventArgs e)
		{
			DialogResult = DialogResult.Cancel;
			Close();
		}
	}
}
