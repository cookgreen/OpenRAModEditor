namespace OpenRAModEditor
{
	partial class frmModResourceBrowser
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
			this.components = new System.ComponentModel.Container();
			System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmModResourceBrowser));
			this.resourceDirList = new System.Windows.Forms.ListBox();
			this.resourceView = new System.Windows.Forms.ListView();
			this.btnCancel = new System.Windows.Forms.Button();
			this.btnOK = new System.Windows.Forms.Button();
			this.imageList1 = new System.Windows.Forms.ImageList(this.components);
			this.SuspendLayout();
			// 
			// resourceDirList
			// 
			this.resourceDirList.FormattingEnabled = true;
			this.resourceDirList.ItemHeight = 12;
			this.resourceDirList.Location = new System.Drawing.Point(13, 13);
			this.resourceDirList.Name = "resourceDirList";
			this.resourceDirList.Size = new System.Drawing.Size(174, 436);
			this.resourceDirList.TabIndex = 0;
			this.resourceDirList.SelectedIndexChanged += new System.EventHandler(this.ResourceDirList_SelectedIndexChanged);
			// 
			// resourceView
			// 
			this.resourceView.LargeImageList = this.imageList1;
			this.resourceView.Location = new System.Drawing.Point(194, 13);
			this.resourceView.Name = "resourceView";
			this.resourceView.Size = new System.Drawing.Size(445, 436);
			this.resourceView.TabIndex = 1;
			this.resourceView.UseCompatibleStateImageBehavior = false;
			// 
			// btnCancel
			// 
			this.btnCancel.Location = new System.Drawing.Point(564, 455);
			this.btnCancel.Name = "btnCancel";
			this.btnCancel.Size = new System.Drawing.Size(75, 23);
			this.btnCancel.TabIndex = 2;
			this.btnCancel.Text = "Cancel";
			this.btnCancel.UseVisualStyleBackColor = true;
			this.btnCancel.Click += new System.EventHandler(this.BtnCancel_Click);
			// 
			// btnOK
			// 
			this.btnOK.Location = new System.Drawing.Point(483, 454);
			this.btnOK.Name = "btnOK";
			this.btnOK.Size = new System.Drawing.Size(75, 23);
			this.btnOK.TabIndex = 3;
			this.btnOK.Text = "OK";
			this.btnOK.UseVisualStyleBackColor = true;
			this.btnOK.Click += new System.EventHandler(this.BtnOK_Click);
			// 
			// imageList1
			// 
			this.imageList1.ImageStream = ((System.Windows.Forms.ImageListStreamer)(resources.GetObject("imageList1.ImageStream")));
			this.imageList1.TransparentColor = System.Drawing.Color.Transparent;
			this.imageList1.Images.SetKeyName(0, "file.png");
			// 
			// frmModResourceBrowser
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.ClientSize = new System.Drawing.Size(651, 489);
			this.Controls.Add(this.btnOK);
			this.Controls.Add(this.btnCancel);
			this.Controls.Add(this.resourceView);
			this.Controls.Add(this.resourceDirList);
			this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
			this.MaximizeBox = false;
			this.MinimizeBox = false;
			this.Name = "frmModResourceBrowser";
			this.ShowIcon = false;
			this.ShowInTaskbar = false;
			this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
			this.Text = "Resource Browser";
			this.Load += new System.EventHandler(this.FrmModResourceBrowser_Load);
			this.ResumeLayout(false);

		}

		#endregion

		private System.Windows.Forms.ListBox resourceDirList;
		private System.Windows.Forms.ListView resourceView;
		private System.Windows.Forms.Button btnCancel;
		private System.Windows.Forms.Button btnOK;
		private System.Windows.Forms.ImageList imageList1;
	}
}