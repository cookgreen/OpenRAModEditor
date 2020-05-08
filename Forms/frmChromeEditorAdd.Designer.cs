namespace OpenRAModEditor
{
	partial class frmChromeEditorAdd
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
			this.lbChromeName = new System.Windows.Forms.Label();
			this.txtChromeName = new System.Windows.Forms.TextBox();
			this.lbChromeResource = new System.Windows.Forms.Label();
			this.txtResourcePath = new System.Windows.Forms.TextBox();
			this.btnChoose = new System.Windows.Forms.Button();
			this.btnCancel = new System.Windows.Forms.Button();
			this.btnOK = new System.Windows.Forms.Button();
			this.SuspendLayout();
			// 
			// lbChromeName
			// 
			this.lbChromeName.AutoSize = true;
			this.lbChromeName.Location = new System.Drawing.Point(13, 13);
			this.lbChromeName.Name = "lbChromeName";
			this.lbChromeName.Size = new System.Drawing.Size(35, 12);
			this.lbChromeName.TabIndex = 0;
			this.lbChromeName.Text = "Name:";
			// 
			// txtChromeName
			// 
			this.txtChromeName.Location = new System.Drawing.Point(78, 10);
			this.txtChromeName.Name = "txtChromeName";
			this.txtChromeName.Size = new System.Drawing.Size(218, 21);
			this.txtChromeName.TabIndex = 1;
			// 
			// lbChromeResource
			// 
			this.lbChromeResource.AutoSize = true;
			this.lbChromeResource.Location = new System.Drawing.Point(13, 45);
			this.lbChromeResource.Name = "lbChromeResource";
			this.lbChromeResource.Size = new System.Drawing.Size(59, 12);
			this.lbChromeResource.TabIndex = 2;
			this.lbChromeResource.Text = "Resource:";
			// 
			// txtResourcePath
			// 
			this.txtResourcePath.Location = new System.Drawing.Point(78, 42);
			this.txtResourcePath.Name = "txtResourcePath";
			this.txtResourcePath.ReadOnly = true;
			this.txtResourcePath.Size = new System.Drawing.Size(179, 21);
			this.txtResourcePath.TabIndex = 3;
			// 
			// btnChoose
			// 
			this.btnChoose.Location = new System.Drawing.Point(263, 40);
			this.btnChoose.Name = "btnChoose";
			this.btnChoose.Size = new System.Drawing.Size(33, 23);
			this.btnChoose.TabIndex = 4;
			this.btnChoose.Text = "...";
			this.btnChoose.UseVisualStyleBackColor = true;
			this.btnChoose.Click += new System.EventHandler(this.BtnChoose_Click);
			// 
			// btnCancel
			// 
			this.btnCancel.Location = new System.Drawing.Point(221, 69);
			this.btnCancel.Name = "btnCancel";
			this.btnCancel.Size = new System.Drawing.Size(75, 23);
			this.btnCancel.TabIndex = 5;
			this.btnCancel.Text = "Cancel";
			this.btnCancel.UseVisualStyleBackColor = true;
			this.btnCancel.Click += new System.EventHandler(this.BtnCancel_Click);
			// 
			// btnOK
			// 
			this.btnOK.Location = new System.Drawing.Point(140, 69);
			this.btnOK.Name = "btnOK";
			this.btnOK.Size = new System.Drawing.Size(75, 23);
			this.btnOK.TabIndex = 6;
			this.btnOK.Text = "OK";
			this.btnOK.UseVisualStyleBackColor = true;
			this.btnOK.Click += new System.EventHandler(this.BtnOK_Click);
			// 
			// frmChromeEditorAdd
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.ClientSize = new System.Drawing.Size(308, 100);
			this.Controls.Add(this.btnOK);
			this.Controls.Add(this.btnCancel);
			this.Controls.Add(this.btnChoose);
			this.Controls.Add(this.txtResourcePath);
			this.Controls.Add(this.lbChromeResource);
			this.Controls.Add(this.txtChromeName);
			this.Controls.Add(this.lbChromeName);
			this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
			this.MaximizeBox = false;
			this.MinimizeBox = false;
			this.Name = "frmChromeEditorAdd";
			this.ShowIcon = false;
			this.ShowInTaskbar = false;
			this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
			this.Text = "Add Chrome";
			this.ResumeLayout(false);
			this.PerformLayout();

		}

		#endregion

		private System.Windows.Forms.Label lbChromeName;
		private System.Windows.Forms.TextBox txtChromeName;
		private System.Windows.Forms.Label lbChromeResource;
		private System.Windows.Forms.TextBox txtResourcePath;
		private System.Windows.Forms.Button btnChoose;
		private System.Windows.Forms.Button btnCancel;
		private System.Windows.Forms.Button btnOK;
	}
}