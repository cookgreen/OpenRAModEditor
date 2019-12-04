using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Diagnostics;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace OpenRAModEditor
{
	public partial class ctrlSettingExternalApplication : UserControl, ISavableControl
	{
		private OraModEditorProject project;
		private OraModEditorProjectSettingGroup externalAppSettingGroup;
		public ctrlSettingExternalApplication(OraModEditorProject project)
		{
			InitializeComponent();
			this.project = project;

			InitLanguageOptions();
		}

		private void InitLanguageOptions()
		{
			colExtension.Text = LanguageManager.Instance.GetLocalizedString("ui_setting_external_app_extension");
			colAppPath.Text = LanguageManager.Instance.GetLocalizedString("ui_setting_external_app_application");
		}

		private void BtnAdd_Click(object sender, EventArgs e)
		{
			frmSettingExternalApplicationAddEdit addWin = new frmSettingExternalApplicationAddEdit(null, 0);
			if(addWin.ShowDialog() == DialogResult.OK)
			{
				ListViewItem item = new ListViewItem();
				item.Text = addWin.ExternalApplication.Extension;
				item.SubItems.Add(addWin.ExternalApplication.Application);
				externalAppList.Items.Add(item);
				if (externalAppSettingGroup == null)
				{
					externalAppSettingGroup = project.Settings.AddGroup("External Application");
					externalAppSettingGroup.AddSetting(addWin.ExternalApplication.Extension, addWin.ExternalApplication.Application);
				}
			}
		}

		private void BtnDelete_Click(object sender, EventArgs e)
		{
			externalAppList.Items.RemoveAt(externalAppList.SelectedIndices[0]);
		}

		public bool Save()
		{
			project.Save(project.Mod.ModSDKPath + "\\.project");
			return true;
		}

		private void ExternalAppList_SelectedIndexChanged(object sender, EventArgs e)
		{
			if (externalAppList.SelectedIndices[0] == -1)
			{
				btnDelete.Enabled = false;
			}
			else
			{
				btnDelete.Enabled = true;
			}
		}

		private void CtrlSettingExternalApplication_Load(object sender, EventArgs e)
		{
			var result = project.Settings.Groups.Where(o => o.Name == "External Application");
			if (result.Count() > 0)
			{
				externalAppSettingGroup = result.ElementAt(0);
				foreach(var kpl in externalAppSettingGroup.SettingItems)
				{
					ListViewItem item = new ListViewItem();
					item.Text = kpl.ItemName;
					item.SubItems.Add(kpl.ItemValue);
				}
			}
		}
	}
}
