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
	public partial class frmAddEditYamlNode : Form, ILocalization
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

			InitLanguageOptions();
		}

		public void InitLanguageOptions()
		{
			lbNodeName.Text = LanguageManager.Instance.GetLocalizedString("ui_yaml_editor_add_edit_node_node_name");
			lbNodeValue.Text = LanguageManager.Instance.GetLocalizedString("ui_yaml_editor_add_edit_node_node_value");
			btnOK.Text = LanguageManager.Instance.GetLocalizedString("ui_ok");
			btnCancel.Text = LanguageManager.Instance.GetLocalizedString("ui_cancel");
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
