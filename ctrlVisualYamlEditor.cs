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
	public partial class ctrlVisualYamlEditor : UserControl
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
			txtValue.Text = keyValuePairs[e.Node].Value;
		}
	}
}
