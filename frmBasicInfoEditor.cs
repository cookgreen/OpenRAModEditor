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
