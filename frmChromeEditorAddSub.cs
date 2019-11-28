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
	public partial class frmChromeEditorAddSub : Form
	{
		private OraMod oraMod;
		private MiniYamlNode parentChromeNode;
		private Bitmap originalBitmap;
		public string ChromeName { get; set; }
		public string Coord { get; set; }
		public frmChromeEditorAddSub(OraMod oraMod, MiniYamlNode parentChromeNode)
		{
			InitializeComponent();
			this.oraMod = oraMod;
			this.parentChromeNode = parentChromeNode;
		}

		private void FrmChromeEditorAddSub_Load(object sender, EventArgs e)
		{
			string imageFullPath = oraMod.Manifest.Resources[parentChromeNode.Value.Trim()];
			Bitmap bitmap = new Bitmap(imageFullPath);
			originalBitmap = bitmap;
			previewImage.Image = bitmap;
			txtChromeX.Text = "0";
			txtChromeY.Text = "0";
			txtChromeWidth.Text = bitmap.Width.ToString();
			txtChromeHeight.Text = bitmap.Height.ToString();
		}

		private void TxtChromeX_TextChanged(object sender, EventArgs e)
		{
			recalculatePreviewImage();
		}

		private void TxtChromeY_TextChanged(object sender, EventArgs e)
		{
			recalculatePreviewImage();
		}

		private void TxtChromeWidth_TextChanged(object sender, EventArgs e)
		{
			recalculatePreviewImage();
		}

		private void TxtChromeHeight_TextChanged(object sender, EventArgs e)
		{
			recalculatePreviewImage();
		}

		private void recalculatePreviewImage()
		{
			if (!string.IsNullOrEmpty(txtChromeX.Text) &&
				!string.IsNullOrEmpty(txtChromeY.Text) &&
				!string.IsNullOrEmpty(txtChromeWidth.Text) &&
				!string.IsNullOrEmpty(txtChromeHeight.Text))
			{
				try
				{
					var bitmapData = originalBitmap.LockBits(new Rectangle(
								 int.Parse(txtChromeX.Text),
								 int.Parse(txtChromeY.Text),
								 int.Parse(txtChromeWidth.Text),
								 int.Parse(txtChromeHeight.Text)),
								 System.Drawing.Imaging.ImageLockMode.ReadWrite,
								 originalBitmap.PixelFormat
					);
					originalBitmap.UnlockBits(bitmapData);//clip the image
					Bitmap newBitmap = new Bitmap(
						int.Parse(txtChromeWidth.Text),
						int.Parse(txtChromeHeight.Text),
						bitmapData.Stride,
						originalBitmap.PixelFormat,
						bitmapData.Scan0);
					previewImage.Image = newBitmap;
				}
				catch {
					MessageBox.Show("Wrong input!", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
				}
			}
		}

		private void BtnOK_Click(object sender, EventArgs e)
		{
			if (!string.IsNullOrEmpty(txtChromeX.Text) &&
				!string.IsNullOrEmpty(txtChromeY.Text) &&
				!string.IsNullOrEmpty(txtChromeWidth.Text) &&
				!string.IsNullOrEmpty(txtChromeHeight.Text) &&
				!string.IsNullOrEmpty(txtChromeName.Text))
			{
				if (parentChromeNode.ChildNodes.Where(o => o.Name == txtChromeName.Text).Count() == 0)
				{
					ChromeName = txtChromeName.Text;
					Coord = string.Format("{0},{1},{2},{3}", txtChromeX.Text, txtChromeY.Text, txtChromeWidth.Text, txtChromeHeight.Text);
					DialogResult = DialogResult.OK;
					Close();
				}
				else
				{
					MessageBox.Show(string.Format("The node with name {0} has already existed!", txtChromeName.Text), "Error",
					 MessageBoxButtons.OK, MessageBoxIcon.Error);
				}
			}
			else
			{
				MessageBox.Show("Please fill all specific fields!", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
			}
		}

		private void BtnCancel_Click(object sender, EventArgs e)
		{
			DialogResult = DialogResult.Cancel;
			Close();
		}
	}
}
