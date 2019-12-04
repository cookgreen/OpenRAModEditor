namespace OpenRAModEditor
{
	partial class frmSettingExternalApplicationAddEdit
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
			this.lbExtension = new System.Windows.Forms.Label();
			this.lbAppPath = new System.Windows.Forms.Label();
			this.txtExtension = new System.Windows.Forms.TextBox();
			this.txtPath = new System.Windows.Forms.TextBox();
			this.btnBrowse = new System.Windows.Forms.Button();
			this.btnCancel = new System.Windows.Forms.Button();
			this.btnOK = new System.Windows.Forms.Button();
			this.SuspendLayout();
			// 
			// lbExtension
			// 
			this.lbExtension.AutoSize = true;
			this.lbExtension.Location = new System.Drawing.Point(12, 13);
			this.lbExtension.Name = "lbExtension";
			this.lbExtension.Size = new System.Drawing.Size(65, 12);
			this.lbExtension.TabIndex = 0;
			this.lbExtension.Text = "Extension:";
			// 
			// lbAppPath
			// 
			this.lbAppPath.AutoSize = true;
			this.lbAppPath.Location = new System.Drawing.Point(13, 48);
			this.lbAppPath.Name = "lbAppPath";
			this.lbAppPath.Size = new System.Drawing.Size(35, 12);
			this.lbAppPath.TabIndex = 1;
			this.lbAppPath.Text = "Path:";
			// 
			// txtExtension
			// 
			this.txtExtension.Location = new System.Drawing.Point(84, 10);
			this.txtExtension.Name = "txtExtension";
			this.txtExtension.Size = new System.Drawing.Size(200, 21);
			this.txtExtension.TabIndex = 2;
			// 
			// txtPath
			// 
			this.txtPath.Location = new System.Drawing.Point(84, 45);
			this.txtPath.Name = "txtPath";
			this.txtPath.ReadOnly = true;
			this.txtPath.Size = new System.Drawing.Size(151, 21);
			this.txtPath.TabIndex = 3;
			// 
			// btnBrowse
			// 
			this.btnBrowse.Location = new System.Drawing.Point(241, 43);
			this.btnBrowse.Name = "btnBrowse";
			this.btnBrowse.Size = new System.Drawing.Size(43, 23);
			this.btnBrowse.TabIndex = 4;
			this.btnBrowse.Text = "...";
			this.btnBrowse.UseVisualStyleBackColor = true;
			this.btnBrowse.Click += new System.EventHandler(this.BtnBrowse_Click);
			// 
			// btnCancel
			// 
			this.btnCancel.Location = new System.Drawing.Point(209, 78);
			this.btnCancel.Name = "btnCancel";
			this.btnCancel.Size = new System.Drawing.Size(75, 23);
			this.btnCancel.TabIndex = 5;
			this.btnCancel.Text = "Cancel";
			this.btnCancel.UseVisualStyleBackColor = true;
			this.btnCancel.Click += new System.EventHandler(this.BtnCancel_Click);
			// 
			// btnOK
			// 
			this.btnOK.Location = new System.Drawing.Point(128, 78);
			this.btnOK.Name = "btnOK";
			this.btnOK.Size = new System.Drawing.Size(75, 23);
			this.btnOK.TabIndex = 6;
			this.btnOK.Text = "OK";
			this.btnOK.UseVisualStyleBackColor = true;
			this.btnOK.Click += new System.EventHandler(this.BtnOK_Click);
			// 
			// frmSettingExternalApplicationAddEdit
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.ClientSize = new System.Drawing.Size(296, 113);
			this.Controls.Add(this.btnOK);
			this.Controls.Add(this.btnCancel);
			this.Controls.Add(this.btnBrowse);
			this.Controls.Add(this.txtPath);
			this.Controls.Add(this.txtExtension);
			this.Controls.Add(this.lbAppPath);
			this.Controls.Add(this.lbExtension);
			this.MaximizeBox = false;
			this.MinimizeBox = false;
			this.Name = "frmSettingExternalApplicationAddEdit";
			this.ShowIcon = false;
			this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
			this.Text = "{!}DUMMY TITLE";
			this.ResumeLayout(false);
			this.PerformLayout();

		}

		#endregion

		private System.Windows.Forms.Label lbExtension;
		private System.Windows.Forms.Label lbAppPath;
		private System.Windows.Forms.TextBox txtExtension;
		private System.Windows.Forms.TextBox txtPath;
		private System.Windows.Forms.Button btnBrowse;
		private System.Windows.Forms.Button btnCancel;
		private System.Windows.Forms.Button btnOK;
	}
}