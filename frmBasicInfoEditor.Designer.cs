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
			this.label1 = new System.Windows.Forms.Label();
			this.txtModID = new System.Windows.Forms.TextBox();
			this.label2 = new System.Windows.Forms.Label();
			this.txtEngineVersion = new System.Windows.Forms.TextBox();
			this.label3 = new System.Windows.Forms.Label();
			this.txtModAssembly = new System.Windows.Forms.TextBox();
			this.label4 = new System.Windows.Forms.Label();
			this.txtPackingInstallerName = new System.Windows.Forms.TextBox();
			this.label5 = new System.Windows.Forms.Label();
			this.txtPackagingAuthor = new System.Windows.Forms.TextBox();
			this.btnCancel = new System.Windows.Forms.Button();
			this.btnOK = new System.Windows.Forms.Button();
			this.btnOpenModConfig = new System.Windows.Forms.Button();
			this.SuspendLayout();
			// 
			// label1
			// 
			this.label1.AutoSize = true;
			this.label1.Location = new System.Drawing.Point(10, 15);
			this.label1.Name = "label1";
			this.label1.Size = new System.Drawing.Size(47, 12);
			this.label1.TabIndex = 2;
			this.label1.Text = "Mod ID:";
			// 
			// txtModID
			// 
			this.txtModID.Location = new System.Drawing.Point(111, 12);
			this.txtModID.Name = "txtModID";
			this.txtModID.Size = new System.Drawing.Size(194, 21);
			this.txtModID.TabIndex = 3;
			// 
			// label2
			// 
			this.label2.AutoSize = true;
			this.label2.Location = new System.Drawing.Point(10, 46);
			this.label2.Name = "label2";
			this.label2.Size = new System.Drawing.Size(95, 12);
			this.label2.TabIndex = 4;
			this.label2.Text = "Engine Version:";
			// 
			// txtEngineVersion
			// 
			this.txtEngineVersion.Location = new System.Drawing.Point(111, 43);
			this.txtEngineVersion.Name = "txtEngineVersion";
			this.txtEngineVersion.ReadOnly = true;
			this.txtEngineVersion.Size = new System.Drawing.Size(194, 21);
			this.txtEngineVersion.TabIndex = 5;
			// 
			// label3
			// 
			this.label3.AutoSize = true;
			this.label3.Location = new System.Drawing.Point(10, 79);
			this.label3.Name = "label3";
			this.label3.Size = new System.Drawing.Size(83, 12);
			this.label3.TabIndex = 6;
			this.label3.Text = "Mod Assembly:";
			// 
			// txtModAssembly
			// 
			this.txtModAssembly.Location = new System.Drawing.Point(111, 76);
			this.txtModAssembly.Name = "txtModAssembly";
			this.txtModAssembly.Size = new System.Drawing.Size(194, 21);
			this.txtModAssembly.TabIndex = 7;
			// 
			// label4
			// 
			this.label4.AutoSize = true;
			this.label4.Location = new System.Drawing.Point(10, 116);
			this.label4.Name = "label4";
			this.label4.Size = new System.Drawing.Size(155, 12);
			this.label4.TabIndex = 8;
			this.label4.Text = "Packaging Installer Name:";
			// 
			// txtPackingInstallerName
			// 
			this.txtPackingInstallerName.Location = new System.Drawing.Point(171, 113);
			this.txtPackingInstallerName.Name = "txtPackingInstallerName";
			this.txtPackingInstallerName.Size = new System.Drawing.Size(134, 21);
			this.txtPackingInstallerName.TabIndex = 9;
			// 
			// label5
			// 
			this.label5.AutoSize = true;
			this.label5.Location = new System.Drawing.Point(10, 149);
			this.label5.Name = "label5";
			this.label5.Size = new System.Drawing.Size(107, 12);
			this.label5.TabIndex = 10;
			this.label5.Text = "Packaging Author:";
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
			this.Controls.Add(this.label5);
			this.Controls.Add(this.txtPackingInstallerName);
			this.Controls.Add(this.label4);
			this.Controls.Add(this.txtModAssembly);
			this.Controls.Add(this.label3);
			this.Controls.Add(this.txtEngineVersion);
			this.Controls.Add(this.label2);
			this.Controls.Add(this.txtModID);
			this.Controls.Add(this.label1);
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
		private System.Windows.Forms.Label label1;
		private System.Windows.Forms.TextBox txtModID;
		private System.Windows.Forms.Label label2;
		private System.Windows.Forms.TextBox txtEngineVersion;
		private System.Windows.Forms.Label label3;
		private System.Windows.Forms.TextBox txtModAssembly;
		private System.Windows.Forms.Label label4;
		private System.Windows.Forms.TextBox txtPackingInstallerName;
		private System.Windows.Forms.Label label5;
		private System.Windows.Forms.TextBox txtPackagingAuthor;
		private System.Windows.Forms.Button btnCancel;
		private System.Windows.Forms.Button btnOK;
		private System.Windows.Forms.Button btnOpenModConfig;
	}
}