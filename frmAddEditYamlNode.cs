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
	public partial class frmAddEditYamlNode : Form
	{
		private int mode;
		private MiniYamlNode node;
		public MiniYamlNode Node
		{
			get
			{
				return node;
			}
		}
		public frmAddEditYamlNode(MiniYamlNode node, int mode)
		{
			InitializeComponent();
			this.node = node;
			this.mode = mode;
			if (mode == 0)
			{
				Text = "Add Yaml Node";
			}
			else if (mode == 1)
			{
				Text = "Edit Yaml Node";
			}
		}

		private void FrmAddEditYamlNode_Load(object sender, EventArgs e)
		{
			txtNodeName.Text = node.Name;
			txtNodeValue.Text = node.Value;
		}

		private void BtnOK_Click(object sender, EventArgs e)
		{
			Close();
			node.Name = txtNodeName.Text;
			node.Value = txtNodeValue.Text;
			DialogResult = DialogResult.OK;
		}

		private void BtnCancel_Click(object sender, EventArgs e)
		{
			Close();
			DialogResult = DialogResult.Cancel;
		}
	}
}
