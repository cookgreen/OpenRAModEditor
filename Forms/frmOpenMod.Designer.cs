﻿namespace OpenRAModEditor
{
	partial class frmOpenMod
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
			this.lbModPath = new System.Windows.Forms.Label();
			this.txtModPath = new System.Windows.Forms.TextBox();
			this.btnBrowse = new System.Windows.Forms.Button();
			this.lbModVersion = new System.Windows.Forms.Label();
			this.txtVersion = new System.Windows.Forms.TextBox();
			this.btnCancel = new System.Windows.Forms.Button();
			this.btnOpen = new System.Windows.Forms.Button();
			this.SuspendLayout();
			// 
			// lbModPath
			// 
			this.lbModPath.AutoSize = true;
			this.lbModPath.Location = new System.Drawing.Point(12, 19);
			this.lbModPath.Name = "lbModPath";
			this.lbModPath.Size = new System.Drawing.Size(59, 12);
			this.lbModPath.TabIndex = 0;
			this.lbModPath.Text = "Mod Path:";
			// 
			// txtModPath
			// 
			this.txtModPath.Location = new System.Drawing.Point(91, 16);
			this.txtModPath.Name = "txtModPath";
			this.txtModPath.ReadOnly = true;
			this.txtModPath.Size = new System.Drawing.Size(231, 21);
			this.txtModPath.TabIndex = 1;
			// 
			// btnBrowse
			// 
			this.btnBrowse.Location = new System.Drawing.Point(328, 14);
			this.btnBrowse.Name = "btnBrowse";
			this.btnBrowse.Size = new System.Drawing.Size(46, 23);
			this.btnBrowse.TabIndex = 2;
			this.btnBrowse.Text = "...";
			this.btnBrowse.UseVisualStyleBackColor = true;
			this.btnBrowse.Click += new System.EventHandler(this.BtnBrowse_Click);
			// 
			// lbModVersion
			// 
			this.lbModVersion.AutoSize = true;
			this.lbModVersion.Location = new System.Drawing.Point(12, 58);
			this.lbModVersion.Name = "lbModVersion";
			this.lbModVersion.Size = new System.Drawing.Size(53, 12);
			this.lbModVersion.TabIndex = 3;
			this.lbModVersion.Text = "Version:";
			// 
			// txtVersion
			// 
			this.txtVersion.Location = new System.Drawing.Point(91, 55);
			this.txtVersion.Name = "txtVersion";
			this.txtVersion.ReadOnly = true;
			this.txtVersion.Size = new System.Drawing.Size(283, 21);
			this.txtVersion.TabIndex = 4;
			// 
			// btnCancel
			// 
			this.btnCancel.Location = new System.Drawing.Point(299, 87);
			this.btnCancel.Name = "btnCancel";
			this.btnCancel.Size = new System.Drawing.Size(75, 23);
			this.btnCancel.TabIndex = 5;
			this.btnCancel.Text = "Cancel";
			this.btnCancel.UseVisualStyleBackColor = true;
			this.btnCancel.Click += new System.EventHandler(this.BtnCancel_Click);
			// 
			// btnOpen
			// 
			this.btnOpen.Enabled = false;
			this.btnOpen.Location = new System.Drawing.Point(218, 87);
			this.btnOpen.Name = "btnOpen";
			this.btnOpen.Size = new System.Drawing.Size(75, 23);
			this.btnOpen.TabIndex = 6;
			this.btnOpen.Text = "Open";
			this.btnOpen.UseVisualStyleBackColor = true;
			this.btnOpen.Click += new System.EventHandler(this.BtnOpen_Click);
			// 
			// frmOpenMod
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.ClientSize = new System.Drawing.Size(386, 122);
			this.Controls.Add(this.btnOpen);
			this.Controls.Add(this.btnCancel);
			this.Controls.Add(this.txtVersion);
			this.Controls.Add(this.lbModVersion);
			this.Controls.Add(this.btnBrowse);
			this.Controls.Add(this.txtModPath);
			this.Controls.Add(this.lbModPath);
			this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
			this.MaximizeBox = false;
			this.MinimizeBox = false;
			this.Name = "frmOpenMod";
			this.ShowIcon = false;
			this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
			this.Text = "Open Mod";
			this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.FrmOpenMod_FormClosed);
			this.ResumeLayout(false);
			this.PerformLayout();

		}

		#endregion

		private System.Windows.Forms.Label lbModPath;
		private System.Windows.Forms.TextBox txtModPath;
		private System.Windows.Forms.Button btnBrowse;
		private System.Windows.Forms.Label lbModVersion;
		private System.Windows.Forms.TextBox txtVersion;
		private System.Windows.Forms.Button btnCancel;
		private System.Windows.Forms.Button btnOpen;
	}
}