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
	public partial class frmSettings : Form, ILocalization
	{
		private OraModEditorProject project;
		private Dictionary<string, UserControl> settingControlDic;
		public frmSettings(OraModEditorProject project)
		{
			InitializeComponent();
			this.project = project;
			settingControlDic = new Dictionary<string, UserControl>();
			settingControlDic.Add("External Application", new ctrlSettingExternalApplication(project));
			settingCategories.SelectedNode = settingCategories.Nodes[0];
		}

		private void SettingCategories_AfterSelect(object sender, TreeViewEventArgs e)
		{
			panel.Controls.Clear();
			var userCtrl = settingControlDic[e.Node.Text];
			panel.Controls.Add(userCtrl);
			userCtrl.Dock = DockStyle.Fill;
		}

		private void BtnOK_Click(object sender, EventArgs e)
		{
			foreach(var settingControlPair in settingControlDic)
			{
				ISavableControl savableControl = settingControlPair.Value as ISavableControl;
				if (savableControl != null)
				{
					savableControl.Save();
				}
			}

			Close();
		}

		private void BtnCancel_Click(object sender, EventArgs e)
		{
			Close();
		}

		public void InitLanguageOptions()
		{
		}
	}
}
