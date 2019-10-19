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
	public partial class ctrlVisualYamlEditor : UserControl, IReceiveRunStateChanged
	{
		private MiniYaml miniYaml;
		private Dictionary<TreeNode, MiniYamlNode> keyValuePairs;
		public ctrlVisualYamlEditor(MiniYaml miniYaml)
		{
			InitializeComponent();
			this.miniYaml = miniYaml;
			keyValuePairs = new Dictionary<TreeNode, MiniYamlNode>();
		}

		private void CtrlVisualYamlEditor_Load(object sender, EventArgs e)
		{
			yamlNodeList.Nodes.Clear();

			foreach (var yamlNode in miniYaml.Nodes)
			{
				var node = yamlNodeList.Nodes.Add(yamlNode.Name);
				keyValuePairs.Add(node, yamlNode);
				GetSubYamlNode(node, yamlNode);
			}
		}

		private void GetSubYamlNode(TreeNode treeNode, MiniYamlNode yamlNode)
		{
			foreach(var subYamlNode in yamlNode.ChildNodes)
			{
				var node = treeNode.Nodes.Add(subYamlNode.Name);
				keyValuePairs.Add(node, subYamlNode);
				GetSubYamlNode(node, subYamlNode);
			}
		}

		private void YamlNodeList_AfterSelect(object sender, TreeViewEventArgs e)
		{
			if (e.Node != null)
			{
				txtValue.Enabled = true;
				btnAddYamlNode.Enabled = true;
				btnEditYamlNode.Enabled = true;
				btnDeleteYamlNode.Enabled = true;
				btnMoveForward.Enabled = true;
				btnMoveBackward.Enabled = true;
				btnSaveChangeToFile.Enabled = true;
				txtValue.Text = keyValuePairs[e.Node].Value;
			}
			else
			{
				txtValue.Enabled = false;
				btnAddYamlNode.Enabled = false;
				btnEditYamlNode.Enabled = false;
				btnDeleteYamlNode.Enabled = false;
				btnMoveForward.Enabled = false;
				btnMoveBackward.Enabled = false;
				btnSaveChangeToFile.Enabled = false;
			}
		}

		private void BtnAddYamlNode_Click(object sender, EventArgs e)
		{
			MiniYamlNode node = keyValuePairs[yamlNodeList.SelectedNode];
			frmAddEditYamlNode addYamlNodeWin = new frmAddEditYamlNode(node, 0);
			if (addYamlNodeWin.ShowDialog() == DialogResult.OK)
			{
				addYamlNodeWin.Node.ParentNode = node;
				node.ChildNodes.Add(addYamlNodeWin.Node);
			}
		}

		private void BtnSaveChangeToFile_Click(object sender, EventArgs e)
		{
			miniYaml.Write();
			MessageBox.Show("Save Compeleted!", "Information", MessageBoxButtons.OK, MessageBoxIcon.Information);
		}

		private void BtnEditYamlNode_Click(object sender, EventArgs e)
		{
			MiniYamlNode node = keyValuePairs[yamlNodeList.SelectedNode];
			frmAddEditYamlNode editYamlNodeWin = new frmAddEditYamlNode(keyValuePairs[yamlNodeList.SelectedNode], 1);
			if (editYamlNodeWin.ShowDialog() == DialogResult.OK)
			{
				node = editYamlNodeWin.Node;
			}
		}

		public void RunStateChanged(RuntimeState state)
		{
			switch(state)
			{
				case RuntimeState.Compiling:
					yamlNodeList.Enabled = false;
					btnAddYamlNode.Enabled = false;
					btnDeleteYamlNode.Enabled = false;
					btnEditYamlNode.Enabled = false;
					btnMoveBackward.Enabled = false;
					btnMoveForward.Enabled = false;
					break;
				case RuntimeState.Running:
					yamlNodeList.Enabled = false;
					btnAddYamlNode.Enabled = false;
					btnDeleteYamlNode.Enabled = false;
					btnEditYamlNode.Enabled = false;
					btnMoveBackward.Enabled = false;
					btnMoveForward.Enabled = false;
					break;
				case RuntimeState.Stop:
					yamlNodeList.Enabled = true;
					btnAddYamlNode.Enabled = true;
					btnDeleteYamlNode.Enabled = true;
					btnEditYamlNode.Enabled = true;
					btnMoveBackward.Enabled = true;
					btnMoveForward.Enabled = true;
					break;
			}
		}
	}
}
