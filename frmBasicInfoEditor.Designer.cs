namespace OpenRAModEditor
{
	partial class frmBasicInfoEditor
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
			this.lbModID = new System.Windows.Forms.Label();
			this.txtModID = new System.Windows.Forms.TextBox();
			this.lbEngineVersion = new System.Windows.Forms.Label();
			this.txtEngineVersion = new System.Windows.Forms.TextBox();
			this.lbModAssembly = new System.Windows.Forms.Label();
			this.txtModAssembly = new System.Windows.Forms.TextBox();
			this.lbPackagingInstallerName = new System.Windows.Forms.Label();
			this.txtPackingInstallerName = new System.Windows.Forms.TextBox();
			this.lbPackagingAuthor = new System.Windows.Forms.Label();
			this.txtPackagingAuthor = new System.Windows.Forms.TextBox();
			this.btnCancel = new System.Windows.Forms.Button();
			this.btnOK = new System.Windows.Forms.Button();
			this.btnOpenModConfig = new System.Windows.Forms.Button();
			this.SuspendLayout();
			// 
			// lbModID
			// 
			this.lbModID.AutoSize = true;
			this.lbModID.Location = new System.Drawing.Point(10, 15);
			this.lbModID.Name = "lbModID";
			this.lbModID.Size = new System.Drawing.Size(47, 12);
			this.lbModID.TabIndex = 2;
			this.lbModID.Text = "Mod ID:";
			// 
			// txtModID
			// 
			this.txtModID.Location = new System.Drawing.Point(111, 12);
			this.txtModID.Name = "txtModID";
			this.txtModID.Size = new System.Drawing.Size(194, 21);
			this.txtModID.TabIndex = 3;
			// 
			// lbEngineVersion
			// 
			this.lbEngineVersion.AutoSize = true;
			this.lbEngineVersion.Location = new System.Drawing.Point(10, 46);
			this.lbEngineVersion.Name = "lbEngineVersion";
			this.lbEngineVersion.Size = new System.Drawing.Size(95, 12);
			this.lbEngineVersion.TabIndex = 4;
			this.lbEngineVersion.Text = "Engine Version:";
			// 
			// txtEngineVersion
			// 
			this.txtEngineVersion.Location = new System.Drawing.Point(111, 43);
			this.txtEngineVersion.Name = "txtEngineVersion";
			this.txtEngineVersion.ReadOnly = true;
			this.txtEngineVersion.Size = new System.Drawing.Size(194, 21);
			this.txtEngineVersion.TabIndex = 5;
			// 
			// lbModAssembly
			// 
			this.lbModAssembly.AutoSize = true;
			this.lbModAssembly.Location = new System.Drawing.Point(10, 79);
			this.lbModAssembly.Name = "lbModAssembly";
			this.lbModAssembly.Size = new System.Drawing.Size(83, 12);
			this.lbModAssembly.TabIndex = 6;
			this.lbModAssembly.Text = "Mod Assembly:";
			// 
			// txtModAssembly
			// 
			this.txtModAssembly.Location = new System.Drawing.Point(111, 76);
			this.txtModAssembly.Name = "txtModAssembly";
			this.txtModAssembly.Size = new System.Drawing.Size(194, 21);
			this.txtModAssembly.TabIndex = 7;
			// 
			// lbPackagingInstallerName
			// 
			this.lbPackagingInstallerName.AutoSize = true;
			this.lbPackagingInstallerName.Location = new System.Drawing.Point(10, 116);
			this.lbPackagingInstallerName.Name = "lbPackagingInstallerName";
			this.lbPackagingInstallerName.Size = new System.Drawing.Size(155, 12);
			this.lbPackagingInstallerName.TabIndex = 8;
			this.lbPackagingInstallerName.Text = "Packaging Installer Name:";
			// 
			// txtPackingInstallerName
			// 
			this.txtPackingInstallerName.Location = new System.Drawing.Point(171, 113);
			this.txtPackingInstallerName.Name = "txtPackingInstallerName";
			this.txtPackingInstallerName.Size = new System.Drawing.Size(134, 21);
			this.txtPackingInstallerName.TabIndex = 9;
			// 
			// lbPackagingAuthor
			// 
			this.lbPackagingAuthor.AutoSize = true;
			this.lbPackagingAuthor.Location = new System.Drawing.Point(10, 149);
			this.lbPackagingAuthor.Name = "lbPackagingAuthor";
			this.lbPackagingAuthor.Size = new System.Drawing.Size(107, 12);
			this.lbPackagingAuthor.TabIndex = 10;
			this.lbPackagingAuthor.Text = "Packaging Author:";
			// 
			// txtPackagingAuthor
			// 
			this.txtPackagingAuthor.Location = new System.Drawing.Point(123, 146);
			this.txtPackagingAuthor.Name = "txtPackagingAuthor";
			this.txtPackagingAuthor.Size = new System.Drawing.Size(182, 21);
			this.txtPackagingAuthor.TabIndex = 11;
			// 
			// btnCancel
			// 
			this.btnCancel.Location = new System.Drawing.Point(230, 180);
			this.btnCancel.Name = "btnCancel";
			this.btnCancel.Size = new System.Drawing.Size(75, 23);
			this.btnCancel.TabIndex = 12;
			this.btnCancel.Text = "Cancel";
			this.btnCancel.UseVisualStyleBackColor = true;
			this.btnCancel.Click += new System.EventHandler(this.BtnCancel_Click);
			// 
			// btnOK
			// 
			this.btnOK.Location = new System.Drawing.Point(149, 180);
			this.btnOK.Name = "btnOK";
			this.btnOK.Size = new System.Drawing.Size(75, 23);
			this.btnOK.TabIndex = 13;
			this.btnOK.Text = "OK";
			this.btnOK.UseVisualStyleBackColor = true;
			this.btnOK.Click += new System.EventHandler(this.BtnOK_Click);
			// 
			// btnOpenModConfig
			// 
			this.btnOpenModConfig.Location = new System.Drawing.Point(12, 180);
			this.btnOpenModConfig.Name = "btnOpenModConfig";
			this.btnOpenModConfig.Size = new System.Drawing.Size(105, 23);
			this.btnOpenModConfig.TabIndex = 14;
			this.btnOpenModConfig.Text = "Open mod.config";
			this.btnOpenModConfig.UseVisualStyleBackColor = true;
			this.btnOpenModConfig.Visible = false;
			this.btnOpenModConfig.Click += new System.EventHandler(this.BtnOpenModConfig_Click);
			// 
			// frmBasicInfoEditor
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.ClientSize = new System.Drawing.Size(319, 215);
			this.Controls.Add(this.btnOpenModConfig);
			this.Controls.Add(this.btnOK);
			this.Controls.Add(this.btnCancel);
			this.Controls.Add(this.txtPackagingAuthor);
			this.Controls.Add(this.lbPackagingAuthor);
			this.Controls.Add(this.txtPackingInstallerName);
			this.Controls.Add(this.lbPackagingInstallerName);
			this.Controls.Add(this.txtModAssembly);
			this.Controls.Add(this.lbModAssembly);
			this.Controls.Add(this.txtEngineVersion);
			this.Controls.Add(this.lbEngineVersion);
			this.Controls.Add(this.txtModID);
			this.Controls.Add(this.lbModID);
			this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
			this.MaximizeBox = false;
			this.MinimizeBox = false;
			this.Name = "frmBasicInfoEditor";
			this.ShowIcon = false;
			this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
			this.Text = "Mod Basic Information Editor";
			this.ResumeLayout(false);
			this.PerformLayout();

		}

		#endregion
		private System.Windows.Forms.Label lbModID;
		private System.Windows.Forms.TextBox txtModID;
		private System.Windows.Forms.Label lbEngineVersion;
		private System.Windows.Forms.TextBox txtEngineVersion;
		private System.Windows.Forms.Label lbModAssembly;
		private System.Windows.Forms.TextBox txtModAssembly;
		private System.Windows.Forms.Label lbPackagingInstallerName;
		private System.Windows.Forms.TextBox txtPackingInstallerName;
		private System.Windows.Forms.Label lbPackagingAuthor;
		private System.Windows.Forms.TextBox txtPackagingAuthor;
		private System.Windows.Forms.Button btnCancel;
		private System.Windows.Forms.Button btnOK;
		private System.Windows.Forms.Button btnOpenModConfig;
	}
}