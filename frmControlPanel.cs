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
	public partial class frmControlPanel : Form
	{
		private AppConfig config;

		public frmControlPanel()
		{
			InitializeComponent();

			config = AppConfig.LoadConfig("config.xml");
			LanguageManager.Instance.AppConfig = config;

			InitLanguageOptions();
		}

		private void InitLanguageOptions()
		{
			Text = LanguageManager.Instance.GetLocalizedString("ui_control_panel_title");
			btnNewMod.Text = LanguageManager.Instance.GetLocalizedString("ui_control_panel_new_mod");
			btnOpenMod.Text = LanguageManager.Instance.GetLocalizedString("ui_control_panel_open_mod");
			btnExit.Text = LanguageManager.Instance.GetLocalizedString("ui_control_panel_exit");
		}

		private void BtnExit_Click(object sender, EventArgs e)
		{
			Application.Exit();
		}

		private void BtnNewMod_Click(object sender, EventArgs e)
		{
			Hide();
			frmCreateNewMod createNewModWin = new frmCreateNewMod();
			createNewModWin.CloseForm += CloseForm;
			createNewModWin.ShowDialog();
		}

		private void CloseForm(object sender)
		{
			Show();
		}

		private void BtnOpenMod_Click(object sender, EventArgs e)
		{
			Hide();
			frmOpenMod openModWin = new frmOpenMod();
			openModWin.CloseForm += CloseForm;
			openModWin.ShowDialog();
		}

		private void FrmControlPanel_FormClosed(object sender, FormClosedEventArgs e)
		{
			Application.Exit();
			DownloadManager.Instance.Stop();
		}
	}
}
