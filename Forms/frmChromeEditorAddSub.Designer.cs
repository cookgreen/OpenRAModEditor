namespace OpenRAModEditor
{
	partial class frmChromeEditorAddSub
	{
		/// <summary>
		/// Required designer variable.
		/// </summary>
		private System.ComponentModel.IContainer components = null;

		/// <summary>
		/// Clean up any resources being used.
		/// </summary>
		/// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
		protected override void Dispose(bool disposing)
		{
			if (disposing && (components != null))
			{
				components.Dispose();
			}
			base.Dispose(disposing);
		}

		#region Windows Form Designer generated code

		/// <summary>
		/// Required method for Designer support - do not modify
		/// the contents of this method with the code editor.
		/// </summary>
		private void InitializeComponent()
		{
			this.btnOK = new System.Windows.Forms.Button();
			this.btnCancel = new System.Windows.Forms.Button();
			this.txtChromeName = new System.Windows.Forms.TextBox();
			this.lbChromeSubName = new System.Windows.Forms.Label();
			this.previewImage = new System.Windows.Forms.PictureBox();
			this.groupBox1 = new System.Windows.Forms.GroupBox();
			this.lbHeight = new System.Windows.Forms.Label();
			this.lbWidth = new System.Windows.Forms.Label();
			this.label3 = new System.Windows.Forms.Label();
			this.label2 = new System.Windows.Forms.Label();
			this.txtChromeY = new System.Windows.Forms.TextBox();
			this.txtChromeWidth = new System.Windows.Forms.TextBox();
			this.txtChromeHeight = new System.Windows.Forms.TextBox();
			this.txtChromeX = new System.Windows.Forms.TextBox();
			((System.ComponentModel.ISupportInitialize)(this.previewImage)).BeginInit();
			this.groupBox1.SuspendLayout();
			this.SuspendLayout();
			// 
			// btnOK
			// 
			this.btnOK.Location = new System.Drawing.Point(400, 363);
			this.btnOK.Name = "btnOK";
			this.btnOK.Size = new System.Drawing.Size(75, 23);
			this.btnOK.TabIndex = 13;
			this.btnOK.Text = "OK";
			this.btnOK.UseVisualStyleBackColor = true;
			this.btnOK.Click += new System.EventHandler(this.BtnOK_Click);
			// 
			// btnCancel
			// 
			this.btnCancel.Location = new System.Drawing.Point(481, 363);
			this.btnCancel.Name = "btnCancel";
			this.btnCancel.Size = new System.Drawing.Size(75, 23);
			this.btnCancel.TabIndex = 12;
			this.btnCancel.Text = "Cancel";
			this.btnCancel.UseVisualStyleBackColor = true;
			this.btnCancel.Click += new System.EventHandler(this.BtnCancel_Click);
			// 
			// txtChromeName
			// 
			this.txtChromeName.Location = new System.Drawing.Point(78, 9);
			this.txtChromeName.Name = "txtChromeName";
			this.txtChromeName.Size = new System.Drawing.Size(478, 21);
			this.txtChromeName.TabIndex = 8;
			// 
			// lbChromeSubName
			// 
			this.lbChromeSubName.AutoSize = true;
			this.lbChromeSubName.Location = new System.Drawing.Point(13, 12);
			this.lbChromeSubName.Name = "lbChromeSubName";
			this.lbChromeSubName.Size = new System.Drawing.Size(35, 12);
			this.lbChromeSubName.TabIndex = 7;
			this.lbChromeSubName.Text = "Name:";
			// 
			// previewImage
			// 
			this.previewImage.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
			this.previewImage.Location = new System.Drawing.Point(15, 20);
			this.previewImage.Name = "previewImage";
			this.previewImage.Size = new System.Drawing.Size(301, 289);
			this.previewImage.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
			this.previewImage.TabIndex = 14;
			this.previewImage.TabStop = false;
			// 
			// groupBox1
			// 
			this.groupBox1.Controls.Add(this.lbHeight);
			this.groupBox1.Controls.Add(this.lbWidth);
			this.groupBox1.Controls.Add(this.label3);
			this.groupBox1.Controls.Add(this.label2);
			this.groupBox1.Controls.Add(this.txtChromeY);
			this.groupBox1.Controls.Add(this.txtChromeWidth);
			this.groupBox1.Controls.Add(this.txtChromeHeight);
			this.groupBox1.Controls.Add(this.txtChromeX);
			this.groupBox1.Controls.Add(this.previewImage);
			this.groupBox1.Location = new System.Drawing.Point(12, 40);
			this.groupBox1.Name = "groupBox1";
			this.groupBox1.Size = new System.Drawing.Size(544, 315);
			this.groupBox1.TabIndex = 23;
			this.groupBox1.TabStop = false;
			this.groupBox1.Text = "Image Preview";
			// 
			// lbHeight
			// 
			this.lbHeight.AutoSize = true;
			this.lbHeight.Location = new System.Drawing.Point(322, 101);
			this.lbHeight.Name = "lbHeight";
			this.lbHeight.Size = new System.Drawing.Size(47, 12);
			this.lbHeight.TabIndex = 30;
			this.lbHeight.Text = "Height:";
			// 
			// lbWidth
			// 
			this.lbWidth.AutoSize = true;
			this.lbWidth.Location = new System.Drawing.Point(322, 74);
			this.lbWidth.Name = "lbWidth";
			this.lbWidth.Size = new System.Drawing.Size(41, 12);
			this.lbWidth.TabIndex = 29;
			this.lbWidth.Text = "Width:";
			// 
			// label3
			// 
			this.label3.AutoSize = true;
			this.label3.Location = new System.Drawing.Point(322, 47);
			this.label3.Name = "label3";
			this.label3.Size = new System.Drawing.Size(17, 12);
			this.label3.TabIndex = 28;
			this.label3.Text = "Y:";
			// 
			// label2
			// 
			this.label2.AutoSize = true;
			this.label2.Location = new System.Drawing.Point(322, 20);
			this.label2.Name = "label2";
			this.label2.Size = new System.Drawing.Size(17, 12);
			this.label2.TabIndex = 27;
			this.label2.Text = "X:";
			// 
			// txtChromeY
			// 
			this.txtChromeY.Location = new System.Drawing.Point(400, 44);
			this.txtChromeY.Name = "txtChromeY";
			this.txtChromeY.Size = new System.Drawing.Size(138, 21);
			this.txtChromeY.TabIndex = 26;
			this.txtChromeY.TextChanged += new System.EventHandler(this.TxtChromeY_TextChanged);
			// 
			// txtChromeWidth
			// 
			this.txtChromeWidth.Location = new System.Drawing.Point(400, 71);
			this.txtChromeWidth.Name = "txtChromeWidth";
			this.txtChromeWidth.Size = new System.Drawing.Size(138, 21);
			this.txtChromeWidth.TabIndex = 25;
			this.txtChromeWidth.TextChanged += new System.EventHandler(this.TxtChromeWidth_TextChanged);
			// 
			// txtChromeHeight
			// 
			this.txtChromeHeight.Location = new System.Drawing.Point(400, 98);
			this.txtChromeHeight.Name = "txtChromeHeight";
			this.txtChromeHeight.Size = new System.Drawing.Size(138, 21);
			this.txtChromeHeight.TabIndex = 24;
			this.txtChromeHeight.TextChanged += new System.EventHandler(this.TxtChromeHeight_TextChanged);
			// 
			// txtChromeX
			// 
			this.txtChromeX.Location = new System.Drawing.Point(400, 17);
			this.txtChromeX.Name = "txtChromeX";
			this.txtChromeX.Size = new System.Drawing.Size(138, 21);
			this.txtChromeX.TabIndex = 23;
			this.txtChromeX.TextChanged += new System.EventHandler(this.TxtChromeX_TextChanged);
			// 
			// frmChromeEditorAddSub
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.ClientSize = new System.Drawing.Size(568, 398);
			this.Controls.Add(this.groupBox1);
			this.Controls.Add(this.btnOK);
			this.Controls.Add(this.btnCancel);
			this.Controls.Add(this.txtChromeName);
			this.Controls.Add(this.lbChromeSubName);
			this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
			this.MaximizeBox = false;
			this.MinimizeBox = false;
			this.Name = "frmChromeEditorAddSub";
			this.ShowIcon = false;
			this.ShowInTaskbar = false;
			this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
			this.Text = "Add Chrome";
			this.Load += new System.EventHandler(this.FrmChromeEditorAddSub_Load);
			((System.ComponentModel.ISupportInitialize)(this.previewImage)).EndInit();
			this.groupBox1.ResumeLayout(false);
			this.groupBox1.PerformLayout();
			this.ResumeLayout(false);
			this.PerformLayout();

		}

		#endregion

		private System.Windows.Forms.Button btnOK;
		private System.Windows.Forms.Button btnCancel;
		private System.Windows.Forms.TextBox txtChromeName;
		private System.Windows.Forms.Label lbChromeSubName;
		private System.Windows.Forms.PictureBox previewImage;
		private System.Windows.Forms.GroupBox groupBox1;
		private System.Windows.Forms.Label lbHeight;
		private System.Windows.Forms.Label lbWidth;
		private System.Windows.Forms.Label label3;
		private System.Windows.Forms.Label label2;
		private System.Windows.Forms.TextBox txtChromeY;
		private System.Windows.Forms.TextBox txtChromeWidth;
		private System.Windows.Forms.TextBox txtChromeHeight;
		private System.Windows.Forms.TextBox txtChromeX;
	}
}