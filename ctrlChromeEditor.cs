using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO;

namespace OpenRAModEditor
{
	public partial class ctrlChromeEditor : UserControl
	{
		private OraMod oraMod;
		private string chromeFile;
		private Dictionary<TreeNode, MiniYamlNode> dic;
		private int selectionMode = -1;
		private MiniYaml chromeYaml;
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
			chromeYaml = new MiniYaml(chromeFileFullPath);
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
				MiniYamlNode miniYamlNode = dic[e.Node];
				string miniYamlNodeValue = miniYamlNode.Value.Trim();
				if (miniYamlNodeValue.Where(o => o == ',').Count() == 3)
				{
					selectionMode = -1;
					btnAdd.Enabled = false;
					btnDelete.Enabled = true;

					var token = miniYamlNode.Value.Trim().Split(',');

					Bitmap bitmap = new Bitmap(oraMod.Manifest.Resources[miniYamlNode.ParentNode.Value.Trim()]);
					var bitmapData = bitmap.LockBits(new Rectangle(
						 int.Parse(token[0]), int.Parse(token[1]),
						 int.Parse(token[2]), int.Parse(token[3])),
						 System.Drawing.Imaging.ImageLockMode.ReadWrite,
						 bitmap.PixelFormat);
					bitmap.UnlockBits(bitmapData);//clip the image

					try
					{
						Bitmap newBitmap = new Bitmap(int.Parse(token[2]), int.Parse(token[3]),
							 bitmapData.Stride, bitmap.PixelFormat, bitmapData.Scan0);
						pictureBox1.Image = newBitmap;
					}
					catch { }

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
					selectionMode = 0;
					btnAdd.Enabled = true;
					btnDelete.Enabled = true;

					var fullPath = oraMod.Manifest.Resources[miniYamlNodeValue];
					var extension = Path.GetExtension(fullPath);
					if (extension == ".png " ||
						extension == ".jpg")
					{
						pictureBox1.Image = new Bitmap(fullPath);
					}

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
				selectionMode = 1;
				btnAdd.Enabled = true;
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

		private void BtnAdd_Click(object sender, EventArgs e)
		{
			switch (selectionMode)
			{
				case 0:
					frmChromeEditorAddSub addSubWin = new frmChromeEditorAddSub(oraMod, dic[chromeList.SelectedNode]);
					if(addSubWin.ShowDialog() == DialogResult.OK)
					{
						MiniYamlNode miniYamlNode = new MiniYamlNode()
						{
							Name = addSubWin.ChromeName,
							Value = addSubWin.Coord
						};
						dic[chromeList.SelectedNode].ChildNodes.Add(miniYamlNode);
						var treeNode = chromeList.SelectedNode.Nodes.Add(addSubWin.ChromeName);
						dic.Add(treeNode, miniYamlNode);
						chromeYaml.Save();
					}
					break;
				case 1:
					frmChromeEditorAdd addWin = new frmChromeEditorAdd(oraMod, chromeYaml);
					if (addWin.ShowDialog() == DialogResult.OK)
					{
						MiniYamlNode miniYamlNode = new MiniYamlNode()
						{
							Name = addWin.ChromeName,
							Value = addWin.Resource
						};
						chromeYaml.Nodes.Add(miniYamlNode);
						var treeNode = chromeList.SelectedNode.Nodes.Add(addWin.ChromeName);
						dic.Add(treeNode, miniYamlNode);
						chromeYaml.Save();
					}
					break;
			}
		}
	}
}
