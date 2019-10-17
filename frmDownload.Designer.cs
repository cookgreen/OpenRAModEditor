namespace OpenRAModEditor
{
	partial class frmDownload
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
			this.progressBar2 = new System.Windows.Forms.ProgressBar();
			this.label2 = new System.Windows.Forms.Label();
			this.label3 = new System.Windows.Forms.Label();
			this.btnCancel = new System.Windows.Forms.Button();
			this.btnHide = new System.Windows.Forms.Button();
			this.lbSpeed = new System.Windows.Forms.Label();
			this.SuspendLayout();
			// 
			// progressBar2
			// 
			this.progressBar2.Location = new System.Drawing.Point(12, 44);
			this.progressBar2.Name = "progressBar2";
			this.progressBar2.Size = new System.Drawing.Size(427, 48);
			this.progressBar2.TabIndex = 1;
			// 
			// label2
			// 
			this.label2.AutoSize = true;
			this.label2.Location = new System.Drawing.Point(12, 20);
			this.label2.Name = "label2";
			this.label2.Size = new System.Drawing.Size(95, 12);
			this.label2.TabIndex = 3;
			this.label2.Text = "Total Progress:";
			// 
			// label3
			// 
			this.label3.AutoSize = true;
			this.label3.Location = new System.Drawing.Point(392, 20);
			this.label3.Name = "label3";
			this.label3.Size = new System.Drawing.Size(35, 12);
			this.label3.TabIndex = 4;
			this.label3.Text = "KiB/S";
			// 
			// btnCancel
			// 
			this.btnCancel.Location = new System.Drawing.Point(364, 112);
			this.btnCancel.Name = "btnCancel";
			this.btnCancel.Size = new System.Drawing.Size(75, 23);
			this.btnCancel.TabIndex = 6;
			this.btnCancel.Text = "Cancel";
			this.btnCancel.UseVisualStyleBackColor = true;
			this.btnCancel.Click += new System.EventHandler(this.BtnCancel_Click);
			// 
			// btnHide
			// 
			this.btnHide.Location = new System.Drawing.Point(283, 112);
			this.btnHide.Name = "btnHide";
			this.btnHide.Size = new System.Drawing.Size(75, 23);
			this.btnHide.TabIndex = 7;
			this.btnHide.Text = "Hide";
			this.btnHide.UseVisualStyleBackColor = true;
			this.btnHide.Click += new System.EventHandler(this.BtnHide_Click);
			// 
			// lbSpeed
			// 
			this.lbSpeed.AutoSize = true;
			this.lbSpeed.Location = new System.Drawing.Point(347, 20);
			this.lbSpeed.Name = "lbSpeed";
			this.lbSpeed.Size = new System.Drawing.Size(11, 12);
			this.lbSpeed.TabIndex = 8;
			this.lbSpeed.Text = "0";
			// 
			// frmDownload
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.ClientSize = new System.Drawing.Size(451, 148);
			this.Controls.Add(this.lbSpeed);
			this.Controls.Add(this.btnHide);
			this.Controls.Add(this.btnCancel);
			this.Controls.Add(this.label3);
			this.Controls.Add(this.label2);
			this.Controls.Add(this.progressBar2);
			this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
			this.MaximizeBox = false;
			this.MinimizeBox = false;
			this.Name = "frmDownload";
			this.ShowIcon = false;
			this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
			this.Text = "Downloading";
			this.ResumeLayout(false);
			this.PerformLayout();

		}

		#endregion
		private System.Windows.Forms.ProgressBar progressBar2;
		private System.Windows.Forms.Label label2;
		private System.Windows.Forms.Label label3;
		private System.Windows.Forms.Button btnCancel;
		private System.Windows.Forms.Button btnHide;
		private System.Windows.Forms.Label lbSpeed;
	}
}