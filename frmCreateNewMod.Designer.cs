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
			this.label1 = new System.Windows.Forms.Label();
			this.cmbVersionList = new System.Windows.Forms.ComboBox();
			this.label2 = new System.Windows.Forms.Label();
			this.txtModID = new System.Windows.Forms.TextBox();
			this.label3 = new System.Windows.Forms.Label();
			this.txtModName = new System.Windows.Forms.TextBox();
			this.label4 = new System.Windows.Forms.Label();
			this.txtModAuthor = new System.Windows.Forms.TextBox();
			this.btnCreate = new System.Windows.Forms.Button();
			this.btnCancel = new System.Windows.Forms.Button();
			this.label5 = new System.Windows.Forms.Label();
			this.txtPath = new System.Windows.Forms.TextBox();
			this.btnBrowse = new System.Windows.Forms.Button();
			this.SuspendLayout();
			// 
			// label1
			// 
			this.label1.AutoSize = true;
			this.label1.Location = new System.Drawing.Point(13, 36);
			this.label1.Name = "label1";
			this.label1.Size = new System.Drawing.Size(53, 12);
			this.label1.TabIndex = 0;
			this.label1.Text = "Version:";
			// 
			// cmbVersionList
			// 
			this.cmbVersionList.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
			this.cmbVersionList.FormattingEnabled = true;
			this.cmbVersionList.Items.AddRange(new object[] {
            "20190314",
            "20190825"});
			this.cmbVersionList.Location = new System.Drawing.Point(79, 33);
			this.cmbVersionList.Name = "cmbVersionList";
			this.cmbVersionList.Size = new System.Drawing.Size(233, 20);
			this.cmbVersionList.TabIndex = 1;
			// 
			// label2
			// 
			this.label2.AutoSize = true;
			this.label2.Location = new System.Drawing.Point(13, 62);
			this.label2.Name = "label2";
			this.label2.Size = new System.Drawing.Size(47, 12);
			this.label2.TabIndex = 2;
			this.label2.Text = "Mod ID:";
			// 
			// txtModID
			// 
			this.txtModID.Location = new System.Drawing.Point(79, 59);
			this.txtModID.Name = "txtModID";
			this.txtModID.Size = new System.Drawing.Size(233, 21);
			this.txtModID.TabIndex = 3;
			// 
			// label3
			// 
			this.label3.AutoSize = true;
			this.label3.Location = new System.Drawing.Point(13, 89);
			this.label3.Name = "label3";
			this.label3.Size = new System.Drawing.Size(59, 12);
			this.label3.TabIndex = 4;
			this.label3.Text = "Mod Name:";
			// 
			// txtModName
			// 
			this.txtModName.Location = new System.Drawing.Point(79, 86);
			this.txtModName.Name = "txtModName";
			this.txtModName.Size = new System.Drawing.Size(233, 21);
			this.txtModName.TabIndex = 5;
			// 
			// label4
			// 
			this.label4.AutoSize = true;
			this.label4.Location = new System.Drawing.Point(13, 116);
			this.label4.Name = "label4";
			this.label4.Size = new System.Drawing.Size(47, 12);
			this.label4.TabIndex = 6;
			this.label4.Text = "Author:";
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
			// label5
			// 
			this.label5.AutoSize = true;
			this.label5.Location = new System.Drawing.Point(13, 9);
			this.label5.Name = "label5";
			this.label5.Size = new System.Drawing.Size(59, 12);
			this.label5.TabIndex = 10;
			this.label5.Text = "Mod Path:";
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
			this.Controls.Add(this.label5);
			this.Controls.Add(this.btnCancel);
			this.Controls.Add(this.btnCreate);
			this.Controls.Add(this.txtModAuthor);
			this.Controls.Add(this.label4);
			this.Controls.Add(this.txtModName);
			this.Controls.Add(this.label3);
			this.Controls.Add(this.txtModID);
			this.Controls.Add(this.label2);
			this.Controls.Add(this.cmbVersionList);
			this.Controls.Add(this.label1);
			this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
			this.MaximizeBox = false;
			this.MinimizeBox = false;
			this.Name = "frmCreateNewMod";
			this.ShowIcon = false;
			this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
			this.Text = "Create New Mod";
			this.ResumeLayout(false);
			this.PerformLayout();

		}

		#endregion

		private System.Windows.Forms.Label label1;
		private System.Windows.Forms.ComboBox cmbVersionList;
		private System.Windows.Forms.Label label2;
		private System.Windows.Forms.TextBox txtModID;
		private System.Windows.Forms.Label label3;
		private System.Windows.Forms.TextBox txtModName;
		private System.Windows.Forms.Label label4;
		private System.Windows.Forms.TextBox txtModAuthor;
		private System.Windows.Forms.Button btnCreate;
		private System.Windows.Forms.Button btnCancel;
		private System.Windows.Forms.Label label5;
		private System.Windows.Forms.TextBox txtPath;
		private System.Windows.Forms.Button btnBrowse;
	}
}