namespace OpenRAModEditor
{
	partial class frmSettings
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
			System.Windows.Forms.TreeNode treeNode4 = new System.Windows.Forms.TreeNode("External Application");
			this.settingCategories = new System.Windows.Forms.TreeView();
			this.panel = new System.Windows.Forms.Panel();
			this.btnCancel = new System.Windows.Forms.Button();
			this.btnOK = new System.Windows.Forms.Button();
			this.SuspendLayout();
			// 
			// settingCategories
			// 
			this.settingCategories.FullRowSelect = true;
			this.settingCategories.Location = new System.Drawing.Point(13, 13);
			this.settingCategories.Name = "settingCategories";
			treeNode4.Name = "节点0";
			treeNode4.Text = "External Application";
			this.settingCategories.Nodes.AddRange(new System.Windows.Forms.TreeNode[] {
            treeNode4});
			this.settingCategories.Size = new System.Drawing.Size(191, 379);
			this.settingCategories.TabIndex = 0;
			this.settingCategories.AfterSelect += new System.Windows.Forms.TreeViewEventHandler(this.SettingCategories_AfterSelect);
			// 
			// panel
			// 
			this.panel.Location = new System.Drawing.Point(210, 13);
			this.panel.Name = "panel";
			this.panel.Size = new System.Drawing.Size(475, 379);
			this.panel.TabIndex = 1;
			// 
			// btnCancel
			// 
			this.btnCancel.Location = new System.Drawing.Point(610, 398);
			this.btnCancel.Name = "btnCancel";
			this.btnCancel.Size = new System.Drawing.Size(75, 23);
			this.btnCancel.TabIndex = 2;
			this.btnCancel.Text = "Cancel";
			this.btnCancel.UseVisualStyleBackColor = true;
			this.btnCancel.Click += new System.EventHandler(this.BtnCancel_Click);
			// 
			// btnOK
			// 
			this.btnOK.Location = new System.Drawing.Point(529, 398);
			this.btnOK.Name = "btnOK";
			this.btnOK.Size = new System.Drawing.Size(75, 23);
			this.btnOK.TabIndex = 3;
			this.btnOK.Text = "OK";
			this.btnOK.UseVisualStyleBackColor = true;
			this.btnOK.Click += new System.EventHandler(this.BtnOK_Click);
			// 
			// frmSettings
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.ClientSize = new System.Drawing.Size(697, 433);
			this.Controls.Add(this.btnOK);
			this.Controls.Add(this.btnCancel);
			this.Controls.Add(this.panel);
			this.Controls.Add(this.settingCategories);
			this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
			this.MaximizeBox = false;
			this.MinimizeBox = false;
			this.Name = "frmSettings";
			this.ShowIcon = false;
			this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
			this.Text = "Settings";
			this.ResumeLayout(false);

		}

		#endregion

		private System.Windows.Forms.TreeView settingCategories;
		private System.Windows.Forms.Panel panel;
		private System.Windows.Forms.Button btnCancel;
		private System.Windows.Forms.Button btnOK;
	}
}