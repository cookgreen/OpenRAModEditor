using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace OpenRAModEditor.Forms
{
	public partial class frmSingleValueEditor : Form
	{
		public string Value { get { return txtValue.Text; } }
		public frmSingleValueEditor(string valueName, string value = null)
		{
			InitializeComponent();
			lbName.Text = valueName;
			txtValue.Text = value;
		}

		private void btnOK_Click(object sender, EventArgs e)
		{
			DialogResult = DialogResult.OK;
			Close();
		}

		private void btnCancel_Click(object sender, EventArgs e)
		{
			DialogResult = DialogResult.Cancel;
			Close();
		}
	}
}
