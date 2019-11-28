using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace OpenRAModEditor
{
	public partial class ctrlChromeEditor : UserControl
	{
		private OraMod oraMod;
		private string chromeFile;
		private Dictionary<TreeNode, MiniYamlNode> dic;
		public ctrlChromeEditor(OraMod oraMod, string chromeFile)
		{
			InitializeComponent();
			this.oraMod = oraMod;
			this.chromeFile = chromeFile;
			dic = new Dictionary<TreeNode, MiniYamlNode>();
		}

		private void CtrlChromeEditor_Load(object sender, EventArgs e)
		{
			chromeList.Nodes.Clear();
			var chromeFileFullPath = oraMod.Manifest.Chrome[chromeFile];
			MiniYaml chromeYaml = new MiniYaml(chromeFileFullPath);
			var treeNode = chromeList.Nodes.Add(chromeFile);
			foreach (var node in chromeYaml.Nodes)
			{
				var newNode = treeNode.Nodes.Add(node.Name);
				dic.Add(newNode, node);
				foreach (var subNode in node.ChildNodes)
				{
					var sNode = newNode.Nodes.Add(subNode.Name);
					dic.Add(sNode, subNode);
				}
			}
		}

		private void ChromeList_AfterSelect(object sender, TreeViewEventArgs e)
		{
			if (dic.ContainsKey(e.Node))
			{
				btnDelete.Enabled = true;
				MiniYamlNode miniYamlNode = dic[e.Node];
				string miniYamlNodeValue = miniYamlNode.Value.Trim();
				if (miniYamlNodeValue.Where(o => o == ',').Count() == 3)
				{
					var token = miniYamlNode.Value.Trim().Split(',');

					txtChromeX.Enabled = true;
					txtChromeY.Enabled = true;
					txtChromeWidth.Enabled = true;
					txtChromeHeight.Enabled = true;

					txtChromeX.Text = token[0];
					txtChromeY.Text = token[1];
					txtChromeWidth.Text = token[2];
					txtChromeHeight.Text = token[3];
				}
				else
				{
					pictureBox1.Image = new Bitmap(oraMod.Manifest.Resources[miniYamlNodeValue]);

					txtChromeX.Enabled = false;
					txtChromeY.Enabled = false;
					txtChromeWidth.Enabled = false;
					txtChromeHeight.Enabled = false;

					txtChromeX.Text = null;
					txtChromeY.Text = null;
					txtChromeWidth.Text = null;
					txtChromeHeight.Text = null;
				}
			}
			else
			{
				btnDelete.Enabled = false;

				txtChromeX.Enabled = false;
				txtChromeY.Enabled = false;
				txtChromeWidth.Enabled = false;
				txtChromeHeight.Enabled = false;

				txtChromeX.Text = null;
				txtChromeY.Text = null;
				txtChromeWidth.Text = null;
				txtChromeHeight.Text = null;
			}
		}
	}
}
