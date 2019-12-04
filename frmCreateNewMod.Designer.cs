namespace OpenRAModEditor
{
	partial class frmCreateNewMod
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
			this.lbModVersion = new System.Windows.Forms.Label();
			this.cmbVersionList = new System.Windows.Forms.ComboBox();
			this.lbModID = new System.Windows.Forms.Label();
			this.txtModID = new System.Windows.Forms.TextBox();
			this.lbModName = new System.Windows.Forms.Label();
			this.txtModName = new System.Windows.Forms.TextBox();
			this.lbModAuthor = new System.Windows.Forms.Label();
			this.txtModAuthor = new System.Windows.Forms.TextBox();
			this.btnCreate = new System.Windows.Forms.Button();
			this.btnCancel = new System.Windows.Forms.Button();
			this.lbModPath = new System.Windows.Forms.Label();
			this.txtPath = new System.Windows.Forms.TextBox();
			this.btnBrowse = new System.Windows.Forms.Button();
			this.SuspendLayout();
			// 
			// lbModVersion
			// 
			this.lbModVersion.AutoSize = true;
			this.lbModVersion.Location = new System.Drawing.Point(13, 36);
			this.lbModVersion.Name = "lbModVersion";
			this.lbModVersion.Size = new System.Drawing.Size(53, 12);
			this.lbModVersion.TabIndex = 0;
			this.lbModVersion.Text = "Version:";
			// 
			// cmbVersionList
			// 
			this.cmbVersionList.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
			this.cmbVersionList.FormattingEnabled = true;
			this.cmbVersionList.Location = new System.Drawing.Point(79, 33);
			this.cmbVersionList.Name = "cmbVersionList";
			this.cmbVersionList.Size = new System.Drawing.Size(233, 20);
			this.cmbVersionList.TabIndex = 1;
			// 
			// lbModID
			// 
			this.lbModID.AutoSize = true;
			this.lbModID.Location = new System.Drawing.Point(13, 62);
			this.lbModID.Name = "lbModID";
			this.lbModID.Size = new System.Drawing.Size(47, 12);
			this.lbModID.TabIndex = 2;
			this.lbModID.Text = "Mod ID:";
			// 
			// txtModID
			// 
			this.txtModID.Location = new System.Drawing.Point(79, 59);
			this.txtModID.Name = "txtModID";
			this.txtModID.Size = new System.Drawing.Size(233, 21);
			this.txtModID.TabIndex = 3;
			// 
			// lbModName
			// 
			this.lbModName.AutoSize = true;
			this.lbModName.Location = new System.Drawing.Point(13, 89);
			this.lbModName.Name = "lbModName";
			this.lbModName.Size = new System.Drawing.Size(59, 12);
			this.lbModName.TabIndex = 4;
			this.lbModName.Text = "Mod Name:";
			// 
			// txtModName
			// 
			this.txtModName.Location = new System.Drawing.Point(79, 86);
			this.txtModName.Name = "txtModName";
			this.txtModName.Size = new System.Drawing.Size(233, 21);
			this.txtModName.TabIndex = 5;
			// 
			// lbModAuthor
			// 
			this.lbModAuthor.AutoSize = true;
			this.lbModAuthor.Location = new System.Drawing.Point(13, 116);
			this.lbModAuthor.Name = "lbModAuthor";
			this.lbModAuthor.Size = new System.Drawing.Size(47, 12);
			this.lbModAuthor.TabIndex = 6;
			this.lbModAuthor.Text = "Author:";
			// 
			// txtModAuthor
			// 
			this.txtModAuthor.Location = new System.Drawing.Point(79, 113);
			this.txtModAuthor.Name = "txtModAuthor";
			this.txtModAuthor.Size = new System.Drawing.Size(233, 21);
			this.txtModAuthor.TabIndex = 7;
			// 
			// btnCreate
			// 
			this.btnCreate.Location = new System.Drawing.Point(84, 145);
			this.btnCreate.Name = "btnCreate";
			this.btnCreate.Size = new System.Drawing.Size(75, 23);
			this.btnCreate.TabIndex = 8;
			this.btnCreate.Text = "Create";
			this.btnCreate.UseVisualStyleBackColor = true;
			this.btnCreate.Click += new System.EventHandler(this.BtnCreate_Click);
			// 
			// btnCancel
			// 
			this.btnCancel.Location = new System.Drawing.Point(165, 145);
			this.btnCancel.Name = "btnCancel";
			this.btnCancel.Size = new System.Drawing.Size(75, 23);
			this.btnCancel.TabIndex = 9;
			this.btnCancel.Text = "Cancel";
			this.btnCancel.UseVisualStyleBackColor = true;
			this.btnCancel.Click += new System.EventHandler(this.BtnCancel_Click);
			// 
			// lbModPath
			// 
			this.lbModPath.AutoSize = true;
			this.lbModPath.Location = new System.Drawing.Point(13, 9);
			this.lbModPath.Name = "lbModPath";
			this.lbModPath.Size = new System.Drawing.Size(59, 12);
			this.lbModPath.TabIndex = 10;
			this.lbModPath.Text = "Mod Path:";
			// 
			// txtPath
			// 
			this.txtPath.Location = new System.Drawing.Point(79, 6);
			this.txtPath.Name = "txtPath";
			this.txtPath.ReadOnly = true;
			this.txtPath.Size = new System.Drawing.Size(179, 21);
			this.txtPath.TabIndex = 11;
			// 
			// btnBrowse
			// 
			this.btnBrowse.Location = new System.Drawing.Point(264, 4);
			this.btnBrowse.Name = "btnBrowse";
			this.btnBrowse.Size = new System.Drawing.Size(48, 23);
			this.btnBrowse.TabIndex = 12;
			this.btnBrowse.Text = "...";
			this.btnBrowse.UseVisualStyleBackColor = true;
			this.btnBrowse.Click += new System.EventHandler(this.BtnBrowse_Click);
			// 
			// frmCreateNewMod
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.ClientSize = new System.Drawing.Size(324, 180);
			this.Controls.Add(this.btnBrowse);
			this.Controls.Add(this.txtPath);
			this.Controls.Add(this.lbModPath);
			this.Controls.Add(this.btnCancel);
			this.Controls.Add(this.btnCreate);
			this.Controls.Add(this.txtModAuthor);
			this.Controls.Add(this.lbModAuthor);
			this.Controls.Add(this.txtModName);
			this.Controls.Add(this.lbModName);
			this.Controls.Add(this.txtModID);
			this.Controls.Add(this.lbModID);
			this.Controls.Add(this.cmbVersionList);
			this.Controls.Add(this.lbModVersion);
			this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
			this.MaximizeBox = false;
			this.MinimizeBox = false;
			this.Name = "frmCreateNewMod";
			this.ShowIcon = false;
			this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
			this.Text = "Create New Mod";
			this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.FrmCreateNewMod_FormClosed);
			this.Load += new System.EventHandler(this.FrmCreateNewMod_Load);
			this.ResumeLayout(false);
			this.PerformLayout();

		}

		#endregion

		private System.Windows.Forms.Label lbModVersion;
		private System.Windows.Forms.ComboBox cmbVersionList;
		private System.Windows.Forms.Label lbModID;
		private System.Windows.Forms.TextBox txtModID;
		private System.Windows.Forms.Label lbModName;
		private System.Windows.Forms.TextBox txtModName;
		private System.Windows.Forms.Label lbModAuthor;
		private System.Windows.Forms.TextBox txtModAuthor;
		private System.Windows.Forms.Button btnCreate;
		private System.Windows.Forms.Button btnCancel;
		private System.Windows.Forms.Label lbModPath;
		private System.Windows.Forms.TextBox txtPath;
		private System.Windows.Forms.Button btnBrowse;
	}
}