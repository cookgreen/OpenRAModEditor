namespace OpenRAModEditor
{
	partial class frmAddEditYamlNode
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
			this.lbNodeName = new System.Windows.Forms.Label();
			this.lbNodeValue = new System.Windows.Forms.Label();
			this.txtNodeName = new System.Windows.Forms.TextBox();
			this.txtNodeValue = new System.Windows.Forms.TextBox();
			this.btnCancel = new System.Windows.Forms.Button();
			this.btnOK = new System.Windows.Forms.Button();
			this.SuspendLayout();
			// 
			// lbNodeName
			// 
			this.lbNodeName.AutoSize = true;
			this.lbNodeName.Location = new System.Drawing.Point(12, 19);
			this.lbNodeName.Name = "lbNodeName";
			this.lbNodeName.Size = new System.Drawing.Size(65, 12);
			this.lbNodeName.TabIndex = 0;
			this.lbNodeName.Text = "Node Name:";
			// 
			// lbNodeValue
			// 
			this.lbNodeValue.AutoSize = true;
			this.lbNodeValue.Location = new System.Drawing.Point(12, 57);
			this.lbNodeValue.Name = "lbNodeValue";
			this.lbNodeValue.Size = new System.Drawing.Size(71, 12);
			this.lbNodeValue.TabIndex = 1;
			this.lbNodeValue.Text = "Node Value:";
			// 
			// txtNodeName
			// 
			this.txtNodeName.Location = new System.Drawing.Point(83, 16);
			this.txtNodeName.Name = "txtNodeName";
			this.txtNodeName.Size = new System.Drawing.Size(217, 21);
			this.txtNodeName.TabIndex = 2;
			// 
			// txtNodeValue
			// 
			this.txtNodeValue.Location = new System.Drawing.Point(83, 54);
			this.txtNodeValue.Name = "txtNodeValue";
			this.txtNodeValue.Size = new System.Drawing.Size(217, 21);
			this.txtNodeValue.TabIndex = 3;
			// 
			// btnCancel
			// 
			this.btnCancel.Location = new System.Drawing.Point(225, 84);
			this.btnCancel.Name = "btnCancel";
			this.btnCancel.Size = new System.Drawing.Size(75, 23);
			this.btnCancel.TabIndex = 4;
			this.btnCancel.Text = "Cancel";
			this.btnCancel.UseVisualStyleBackColor = true;
			this.btnCancel.Click += new System.EventHandler(this.BtnCancel_Click);
			// 
			// btnOK
			// 
			this.btnOK.Location = new System.Drawing.Point(144, 84);
			this.btnOK.Name = "btnOK";
			this.btnOK.Size = new System.Drawing.Size(75, 23);
			this.btnOK.TabIndex = 5;
			this.btnOK.Text = "OK";
			this.btnOK.UseVisualStyleBackColor = true;
			this.btnOK.Click += new System.EventHandler(this.BtnOK_Click);
			// 
			// frmAddEditYamlNode
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.ClientSize = new System.Drawing.Size(312, 119);
			this.Controls.Add(this.btnOK);
			this.Controls.Add(this.btnCancel);
			this.Controls.Add(this.txtNodeValue);
			this.Controls.Add(this.txtNodeName);
			this.Controls.Add(this.lbNodeValue);
			this.Controls.Add(this.lbNodeName);
			this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
			this.MaximizeBox = false;
			this.MinimizeBox = false;
			this.Name = "frmAddEditYamlNode";
			this.ShowIcon = false;
			this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
			this.Text = "!{DUMMY TITLE}";
			this.Load += new System.EventHandler(this.FrmAddEditYamlNode_Load);
			this.ResumeLayout(false);
			this.PerformLayout();

		}

		#endregion

		private System.Windows.Forms.Label lbNodeName;
		private System.Windows.Forms.Label lbNodeValue;
		private System.Windows.Forms.TextBox txtNodeName;
		private System.Windows.Forms.TextBox txtNodeValue;
		private System.Windows.Forms.Button btnCancel;
		private System.Windows.Forms.Button btnOK;
	}
}