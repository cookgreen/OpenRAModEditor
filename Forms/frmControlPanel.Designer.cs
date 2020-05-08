namespace OpenRAModEditor
{
	partial class frmControlPanel
	{
		/// <summary>
		/// 必需的设计器变量。
		/// </summary>
		private System.ComponentModel.IContainer components = null;

		/// <summary>
		/// 清理所有正在使用的资源。
		/// </summary>
		/// <param name="disposing">如果应释放托管资源，为 true；否则为 false。</param>
		protected override void Dispose(bool disposing)
		{
			if (disposing && (components != null))
			{
				components.Dispose();
			}
			base.Dispose(disposing);
		}

		#region Windows 窗体设计器生成的代码

		/// <summary>
		/// 设计器支持所需的方法 - 不要修改
		/// 使用代码编辑器修改此方法的内容。
		/// </summary>
		private void InitializeComponent()
		{
			this.btnNewMod = new System.Windows.Forms.Button();
			this.btnOpenMod = new System.Windows.Forms.Button();
			this.btnExit = new System.Windows.Forms.Button();
			this.SuspendLayout();
			// 
			// btnNewMod
			// 
			this.btnNewMod.Location = new System.Drawing.Point(35, 27);
			this.btnNewMod.Name = "btnNewMod";
			this.btnNewMod.Size = new System.Drawing.Size(177, 57);
			this.btnNewMod.TabIndex = 0;
			this.btnNewMod.Text = "New Mod";
			this.btnNewMod.UseVisualStyleBackColor = true;
			this.btnNewMod.Click += new System.EventHandler(this.BtnNewMod_Click);
			// 
			// btnOpenMod
			// 
			this.btnOpenMod.Location = new System.Drawing.Point(35, 106);
			this.btnOpenMod.Name = "btnOpenMod";
			this.btnOpenMod.Size = new System.Drawing.Size(177, 57);
			this.btnOpenMod.TabIndex = 1;
			this.btnOpenMod.Text = "Open Mod";
			this.btnOpenMod.UseVisualStyleBackColor = true;
			this.btnOpenMod.Click += new System.EventHandler(this.BtnOpenMod_Click);
			// 
			// btnExit
			// 
			this.btnExit.Location = new System.Drawing.Point(35, 184);
			this.btnExit.Name = "btnExit";
			this.btnExit.Size = new System.Drawing.Size(177, 57);
			this.btnExit.TabIndex = 2;
			this.btnExit.Text = "Exit";
			this.btnExit.UseVisualStyleBackColor = true;
			this.btnExit.Click += new System.EventHandler(this.BtnExit_Click);
			// 
			// frmControlPanel
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.ClientSize = new System.Drawing.Size(256, 275);
			this.Controls.Add(this.btnExit);
			this.Controls.Add(this.btnOpenMod);
			this.Controls.Add(this.btnNewMod);
			this.MaximizeBox = false;
			this.MinimizeBox = false;
			this.Name = "frmControlPanel";
			this.ShowIcon = false;
			this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
			this.Text = "OpenRA Mod Editor";
			this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.FrmControlPanel_FormClosed);
			this.ResumeLayout(false);

		}

		#endregion

		private System.Windows.Forms.Button btnNewMod;
		private System.Windows.Forms.Button btnOpenMod;
		private System.Windows.Forms.Button btnExit;
	}
}

