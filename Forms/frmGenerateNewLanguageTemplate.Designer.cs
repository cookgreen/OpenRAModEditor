namespace OpenRAModEditor.Forms
{
	partial class frmGenerateNewLanguageTemplate
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
			this.label2 = new System.Windows.Forms.Label();
			this.label3 = new System.Windows.Forms.Label();
			this.txtNewLanguageID = new System.Windows.Forms.TextBox();
			this.txtNewLanguageDescription = new System.Windows.Forms.TextBox();
			this.comboBox1 = new System.Windows.Forms.ComboBox();
			this.button1 = new System.Windows.Forms.Button();
			this.button2 = new System.Windows.Forms.Button();
			this.SuspendLayout();
			// 
			// label1
			// 
			this.label1.AutoSize = true;
			this.label1.Location = new System.Drawing.Point(12, 9);
			this.label1.Name = "label1";
			this.label1.Size = new System.Drawing.Size(101, 12);
			this.label1.TabIndex = 0;
			this.label1.Text = "New Language ID:";
			// 
			// label2
			// 
			this.label2.AutoSize = true;
			this.label2.Location = new System.Drawing.Point(14, 44);
			this.label2.Name = "label2";
			this.label2.Size = new System.Drawing.Size(155, 12);
			this.label2.TabIndex = 1;
			this.label2.Text = "New Language Description:";
			// 
			// label3
			// 
			this.label3.AutoSize = true;
			this.label3.Location = new System.Drawing.Point(16, 83);
			this.label3.Name = "label3";
			this.label3.Size = new System.Drawing.Size(89, 12);
			this.label3.TabIndex = 2;
			this.label3.Text = "Generate from:";
			// 
			// txtNewLanguageID
			// 
			this.txtNewLanguageID.Location = new System.Drawing.Point(174, 6);
			this.txtNewLanguageID.Name = "txtNewLanguageID";
			this.txtNewLanguageID.Size = new System.Drawing.Size(223, 21);
			this.txtNewLanguageID.TabIndex = 3;
			// 
			// txtNewLanguageDescription
			// 
			this.txtNewLanguageDescription.Location = new System.Drawing.Point(174, 41);
			this.txtNewLanguageDescription.Name = "txtNewLanguageDescription";
			this.txtNewLanguageDescription.Size = new System.Drawing.Size(223, 21);
			this.txtNewLanguageDescription.TabIndex = 4;
			// 
			// comboBox1
			// 
			this.comboBox1.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
			this.comboBox1.FormattingEnabled = true;
			this.comboBox1.Location = new System.Drawing.Point(174, 80);
			this.comboBox1.Name = "comboBox1";
			this.comboBox1.Size = new System.Drawing.Size(223, 20);
			this.comboBox1.TabIndex = 5;
			// 
			// button1
			// 
			this.button1.Location = new System.Drawing.Point(322, 115);
			this.button1.Name = "button1";
			this.button1.Size = new System.Drawing.Size(75, 23);
			this.button1.TabIndex = 6;
			this.button1.Text = "Cancel";
			this.button1.UseVisualStyleBackColor = true;
			// 
			// button2
			// 
			this.button2.Location = new System.Drawing.Point(241, 115);
			this.button2.Name = "button2";
			this.button2.Size = new System.Drawing.Size(75, 23);
			this.button2.TabIndex = 7;
			this.button2.Text = "OK";
			this.button2.UseVisualStyleBackColor = true;
			// 
			// frmGenerateNewLanguageTemplate
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.ClientSize = new System.Drawing.Size(409, 150);
			this.Controls.Add(this.button2);
			this.Controls.Add(this.button1);
			this.Controls.Add(this.comboBox1);
			this.Controls.Add(this.txtNewLanguageDescription);
			this.Controls.Add(this.txtNewLanguageID);
			this.Controls.Add(this.label3);
			this.Controls.Add(this.label2);
			this.Controls.Add(this.label1);
			this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
			this.MaximizeBox = false;
			this.MinimizeBox = false;
			this.Name = "frmGenerateNewLanguageTemplate";
			this.ShowIcon = false;
			this.ShowInTaskbar = false;
			this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
			this.Text = "{ui_generate_new_language_template}";
			this.ResumeLayout(false);
			this.PerformLayout();

		}

		#endregion

		private System.Windows.Forms.Label label1;
		private System.Windows.Forms.Label label2;
		private System.Windows.Forms.Label label3;
		private System.Windows.Forms.TextBox txtNewLanguageID;
		private System.Windows.Forms.TextBox txtNewLanguageDescription;
		private System.Windows.Forms.ComboBox comboBox1;
		private System.Windows.Forms.Button button1;
		private System.Windows.Forms.Button button2;
	}
}