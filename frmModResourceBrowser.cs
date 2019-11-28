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
	public partial class frmModResourceBrowser : Form
	{
		public string SelectedResource;
		private OraMod oraMod;
		public frmModResourceBrowser(OraMod oraMod)
		{
			InitializeComponent();
			this.oraMod = oraMod;
		}

		private void BtnOK_Click(object sender, EventArgs e)
		{
			if (resourceView.SelectedItems.Count > 0)
			{
				SelectedResource = resourceView.SelectedItems[0].Text;
				DialogResult = DialogResult.OK;
				Close();
			}
			else
			{
				MessageBox.Show("Please select a file!", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
			}
		}

		private void BtnCancel_Click(object sender, EventArgs e)
		{
			DialogResult = DialogResult.Cancel;
			Close();
		}

		private void FrmModResourceBrowser_Load(object sender, EventArgs e)
		{
			resourceDirList.Items.Clear();
			foreach (var package in oraMod.Manifest.Packages)
			{
				resourceDirList.Items.Add(package.Key);
			}
			if (resourceDirList.Items.Count > 0)
			{
				resourceDirList.SelectedIndex = 0;
			}
		}

		private void ResourceDirList_SelectedIndexChanged(object sender, EventArgs e)
		{
			resourceView.Items.Clear();
			DirectoryInfo di = new DirectoryInfo(oraMod.Manifest.Packages[resourceDirList.SelectedItem.ToString()]);
			foreach (var file in di.EnumerateFiles())
			{
				ListViewItem lvi = new ListViewItem();
				lvi.Text = file.Name;
				lvi.ImageIndex = 0;
				resourceView.Items.Add(lvi);
			}
		}
	}
}
