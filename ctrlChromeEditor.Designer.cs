namespace OpenRAModEditor
{
	partial class ctrlChromeEditor
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

		#region 组件设计器生成的代码

		/// <summary> 
		/// 设计器支持所需的方法 - 不要修改
		/// 使用代码编辑器修改此方法的内容。
		/// </summary>
		private void InitializeComponent()
		{
			this.tableLayoutPanel1 = new System.Windows.Forms.TableLayoutPanel();
			this.groupBox1 = new System.Windows.Forms.GroupBox();
			this.tableLayoutPanel3 = new System.Windows.Forms.TableLayoutPanel();
			this.chromeList = new System.Windows.Forms.TreeView();
			this.panel2 = new System.Windows.Forms.Panel();
			this.btnDelete = new System.Windows.Forms.Button();
			this.btnAdd = new System.Windows.Forms.Button();
			this.tableLayoutPanel2 = new System.Windows.Forms.TableLayoutPanel();
			this.panel1 = new System.Windows.Forms.Panel();
			this.txtChromeHeight = new System.Windows.Forms.TextBox();
			this.txtChromeWidth = new System.Windows.Forms.TextBox();
			this.txtChromeY = new System.Windows.Forms.TextBox();
			this.txtChromeX = new System.Windows.Forms.TextBox();
			this.lbHeight = new System.Windows.Forms.Label();
			this.lbWidth = new System.Windows.Forms.Label();
			this.label2 = new System.Windows.Forms.Label();
			this.label1 = new System.Windows.Forms.Label();
			this.pictureBox1 = new System.Windows.Forms.PictureBox();
			this.tableLayoutPanel1.SuspendLayout();
			this.groupBox1.SuspendLayout();
			this.tableLayoutPanel3.SuspendLayout();
			this.panel2.SuspendLayout();
			this.tableLayoutPanel2.SuspendLayout();
			this.panel1.SuspendLayout();
			((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
			this.SuspendLayout();
			// 
			// tableLayoutPanel1
			// 
			this.tableLayoutPanel1.ColumnCount = 2;
			this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 240F));
			this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100F));
			this.tableLayoutPanel1.Controls.Add(this.groupBox1, 0, 0);
			this.tableLayoutPanel1.Controls.Add(this.tableLayoutPanel2, 1, 0);
			this.tableLayoutPanel1.Dock = System.Windows.Forms.DockStyle.Fill;
			this.tableLayoutPanel1.Location = new System.Drawing.Point(0, 0);
			this.tableLayoutPanel1.Name = "tableLayoutPanel1";
			this.tableLayoutPanel1.RowCount = 1;
			this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
			this.tableLayoutPanel1.Size = new System.Drawing.Size(712, 546);
			this.tableLayoutPanel1.TabIndex = 0;
			// 
			// groupBox1
			// 
			this.groupBox1.Controls.Add(this.tableLayoutPanel3);
			this.groupBox1.Dock = System.Windows.Forms.DockStyle.Fill;
			this.groupBox1.Location = new System.Drawing.Point(3, 3);
			this.groupBox1.Name = "groupBox1";
			this.groupBox1.Size = new System.Drawing.Size(234, 540);
			this.groupBox1.TabIndex = 0;
			this.groupBox1.TabStop = false;
			this.groupBox1.Text = "Chrome";
			// 
			// tableLayoutPanel3
			// 
			this.tableLayoutPanel3.ColumnCount = 1;
			this.tableLayoutPanel3.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100F));
			this.tableLayoutPanel3.Controls.Add(this.chromeList, 0, 1);
			this.tableLayoutPanel3.Controls.Add(this.panel2, 0, 0);
			this.tableLayoutPanel3.Dock = System.Windows.Forms.DockStyle.Fill;
			this.tableLayoutPanel3.Location = new System.Drawing.Point(3, 17);
			this.tableLayoutPanel3.Name = "tableLayoutPanel3";
			this.tableLayoutPanel3.RowCount = 2;
			this.tableLayoutPanel3.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 40F));
			this.tableLayoutPanel3.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
			this.tableLayoutPanel3.Size = new System.Drawing.Size(228, 520);
			this.tableLayoutPanel3.TabIndex = 0;
			// 
			// chromeList
			// 
			this.chromeList.Dock = System.Windows.Forms.DockStyle.Fill;
			this.chromeList.Location = new System.Drawing.Point(3, 43);
			this.chromeList.Name = "chromeList";
			this.chromeList.Size = new System.Drawing.Size(222, 474);
			this.chromeList.TabIndex = 0;
			this.chromeList.AfterSelect += new System.Windows.Forms.TreeViewEventHandler(this.ChromeList_AfterSelect);
			// 
			// panel2
			// 
			this.panel2.Controls.Add(this.btnDelete);
			this.panel2.Controls.Add(this.btnAdd);
			this.panel2.Dock = System.Windows.Forms.DockStyle.Fill;
			this.panel2.Location = new System.Drawing.Point(3, 3);
			this.panel2.Name = "panel2";
			this.panel2.Size = new System.Drawing.Size(222, 34);
			this.panel2.TabIndex = 1;
			// 
			// btnDelete
			// 
			this.btnDelete.Enabled = false;
			this.btnDelete.Location = new System.Drawing.Point(84, 5);
			this.btnDelete.Name = "btnDelete";
			this.btnDelete.Size = new System.Drawing.Size(75, 23);
			this.btnDelete.TabIndex = 1;
			this.btnDelete.Text = "Delete";
			this.btnDelete.UseVisualStyleBackColor = true;
			// 
			// btnAdd
			// 
			this.btnAdd.Enabled = false;
			this.btnAdd.Location = new System.Drawing.Point(3, 5);
			this.btnAdd.Name = "btnAdd";
			this.btnAdd.Size = new System.Drawing.Size(75, 23);
			this.btnAdd.TabIndex = 0;
			this.btnAdd.Text = "Add";
			this.btnAdd.UseVisualStyleBackColor = true;
			this.btnAdd.Click += new System.EventHandler(this.BtnAdd_Click);
			// 
			// tableLayoutPanel2
			// 
			this.tableLayoutPanel2.ColumnCount = 2;
			this.tableLayoutPanel2.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100F));
			this.tableLayoutPanel2.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 220F));
			this.tableLayoutPanel2.Controls.Add(this.panel1, 1, 0);
			this.tableLayoutPanel2.Controls.Add(this.pictureBox1, 0, 0);
			this.tableLayoutPanel2.Dock = System.Windows.Forms.DockStyle.Fill;
			this.tableLayoutPanel2.Location = new System.Drawing.Point(243, 3);
			this.tableLayoutPanel2.Name = "tableLayoutPanel2";
			this.tableLayoutPanel2.RowCount = 1;
			this.tableLayoutPanel2.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
			this.tableLayoutPanel2.Size = new System.Drawing.Size(466, 540);
			this.tableLayoutPanel2.TabIndex = 1;
			// 
			// panel1
			// 
			this.panel1.Controls.Add(this.txtChromeHeight);
			this.panel1.Controls.Add(this.txtChromeWidth);
			this.panel1.Controls.Add(this.txtChromeY);
			this.panel1.Controls.Add(this.txtChromeX);
			this.panel1.Controls.Add(this.lbHeight);
			this.panel1.Controls.Add(this.lbWidth);
			this.panel1.Controls.Add(this.label2);
			this.panel1.Controls.Add(this.label1);
			this.panel1.Dock = System.Windows.Forms.DockStyle.Fill;
			this.panel1.Location = new System.Drawing.Point(249, 3);
			this.panel1.Name = "panel1";
			this.panel1.Size = new System.Drawing.Size(214, 534);
			this.panel1.TabIndex = 1;
			// 
			// txtChromeHeight
			// 
			this.txtChromeHeight.Enabled = false;
			this.txtChromeHeight.Location = new System.Drawing.Point(65, 81);
			this.txtChromeHeight.Name = "txtChromeHeight";
			this.txtChromeHeight.Size = new System.Drawing.Size(142, 21);
			this.txtChromeHeight.TabIndex = 7;
			// 
			// txtChromeWidth
			// 
			this.txtChromeWidth.Enabled = false;
			this.txtChromeWidth.Location = new System.Drawing.Point(65, 56);
			this.txtChromeWidth.Name = "txtChromeWidth";
			this.txtChromeWidth.Size = new System.Drawing.Size(142, 21);
			this.txtChromeWidth.TabIndex = 6;
			// 
			// txtChromeY
			// 
			this.txtChromeY.Enabled = false;
			this.txtChromeY.Location = new System.Drawing.Point(65, 32);
			this.txtChromeY.Name = "txtChromeY";
			this.txtChromeY.Size = new System.Drawing.Size(142, 21);
			this.txtChromeY.TabIndex = 5;
			// 
			// txtChromeX
			// 
			this.txtChromeX.Enabled = false;
			this.txtChromeX.Location = new System.Drawing.Point(65, 7);
			this.txtChromeX.Name = "txtChromeX";
			this.txtChromeX.Size = new System.Drawing.Size(142, 21);
			this.txtChromeX.TabIndex = 4;
			// 
			// lbHeight
			// 
			this.lbHeight.AutoSize = true;
			this.lbHeight.Location = new System.Drawing.Point(12, 84);
			this.lbHeight.Name = "lbHeight";
			this.lbHeight.Size = new System.Drawing.Size(47, 12);
			this.lbHeight.TabIndex = 3;
			this.lbHeight.Text = "Height:";
			// 
			// lbWidth
			// 
			this.lbWidth.AutoSize = true;
			this.lbWidth.Location = new System.Drawing.Point(12, 59);
			this.lbWidth.Name = "lbWidth";
			this.lbWidth.Size = new System.Drawing.Size(41, 12);
			this.lbWidth.TabIndex = 2;
			this.lbWidth.Text = "Width:";
			// 
			// label2
			// 
			this.label2.AutoSize = true;
			this.label2.Location = new System.Drawing.Point(12, 35);
			this.label2.Name = "label2";
			this.label2.Size = new System.Drawing.Size(17, 12);
			this.label2.TabIndex = 1;
			this.label2.Text = "Y:";
			// 
			// label1
			// 
			this.label1.AutoSize = true;
			this.label1.Location = new System.Drawing.Point(12, 10);
			this.label1.Name = "label1";
			this.label1.Size = new System.Drawing.Size(17, 12);
			this.label1.TabIndex = 0;
			this.label1.Text = "X:";
			// 
			// pictureBox1
			// 
			this.pictureBox1.Dock = System.Windows.Forms.DockStyle.Fill;
			this.pictureBox1.Location = new System.Drawing.Point(3, 3);
			this.pictureBox1.Name = "pictureBox1";
			this.pictureBox1.Size = new System.Drawing.Size(240, 534);
			this.pictureBox1.TabIndex = 2;
			this.pictureBox1.TabStop = false;
			// 
			// ctrlChromeEditor
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.Controls.Add(this.tableLayoutPanel1);
			this.Name = "ctrlChromeEditor";
			this.Size = new System.Drawing.Size(712, 546);
			this.Load += new System.EventHandler(this.CtrlChromeEditor_Load);
			this.tableLayoutPanel1.ResumeLayout(false);
			this.groupBox1.ResumeLayout(false);
			this.tableLayoutPanel3.ResumeLayout(false);
			this.panel2.ResumeLayout(false);
			this.tableLayoutPanel2.ResumeLayout(false);
			this.panel1.ResumeLayout(false);
			this.panel1.PerformLayout();
			((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
			this.ResumeLayout(false);

		}

		#endregion

		private System.Windows.Forms.TableLayoutPanel tableLayoutPanel1;
		private System.Windows.Forms.GroupBox groupBox1;
		private System.Windows.Forms.TreeView chromeList;
		private System.Windows.Forms.TableLayoutPanel tableLayoutPanel3;
		private System.Windows.Forms.Panel panel2;
		private System.Windows.Forms.Button btnAdd;
		private System.Windows.Forms.Button btnDelete;
		private System.Windows.Forms.TableLayoutPanel tableLayoutPanel2;
		private System.Windows.Forms.Panel panel1;
		private System.Windows.Forms.TextBox txtChromeHeight;
		private System.Windows.Forms.TextBox txtChromeWidth;
		private System.Windows.Forms.TextBox txtChromeY;
		private System.Windows.Forms.TextBox txtChromeX;
		private System.Windows.Forms.Label lbHeight;
		private System.Windows.Forms.Label lbWidth;
		private System.Windows.Forms.Label label2;
		private System.Windows.Forms.Label label1;
		private System.Windows.Forms.PictureBox pictureBox1;
	}
}
