namespace OpenRAModEditor
{
	partial class ctrlVisualYamlEditor
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
			this.splitContainer1 = new System.Windows.Forms.SplitContainer();
			this.groupBox1 = new System.Windows.Forms.GroupBox();
			this.yamlNodeList = new System.Windows.Forms.TreeView();
			this.groupBox2 = new System.Windows.Forms.GroupBox();
			this.tableLayoutPanel1 = new System.Windows.Forms.TableLayoutPanel();
			this.btnMoveBackward = new System.Windows.Forms.Button();
			this.btnDeleteYamlNode = new System.Windows.Forms.Button();
			this.panel1 = new System.Windows.Forms.Panel();
			this.btnSaveChangeToFile = new System.Windows.Forms.Button();
			this.btnAddYamlNode = new System.Windows.Forms.Button();
			this.btnEditYamlNode = new System.Windows.Forms.Button();
			this.btnMoveForward = new System.Windows.Forms.Button();
			this.groupBox3 = new System.Windows.Forms.GroupBox();
			this.txtValue = new System.Windows.Forms.RichTextBox();
			((System.ComponentModel.ISupportInitialize)(this.splitContainer1)).BeginInit();
			this.splitContainer1.Panel1.SuspendLayout();
			this.splitContainer1.Panel2.SuspendLayout();
			this.splitContainer1.SuspendLayout();
			this.groupBox1.SuspendLayout();
			this.groupBox2.SuspendLayout();
			this.tableLayoutPanel1.SuspendLayout();
			this.panel1.SuspendLayout();
			this.groupBox3.SuspendLayout();
			this.SuspendLayout();
			// 
			// splitContainer1
			// 
			this.splitContainer1.Dock = System.Windows.Forms.DockStyle.Fill;
			this.splitContainer1.Location = new System.Drawing.Point(0, 0);
			this.splitContainer1.Name = "splitContainer1";
			// 
			// splitContainer1.Panel1
			// 
			this.splitContainer1.Panel1.Controls.Add(this.groupBox1);
			// 
			// splitContainer1.Panel2
			// 
			this.splitContainer1.Panel2.Controls.Add(this.groupBox2);
			this.splitContainer1.Size = new System.Drawing.Size(770, 578);
			this.splitContainer1.SplitterDistance = 386;
			this.splitContainer1.TabIndex = 0;
			// 
			// groupBox1
			// 
			this.groupBox1.Controls.Add(this.yamlNodeList);
			this.groupBox1.Dock = System.Windows.Forms.DockStyle.Fill;
			this.groupBox1.Location = new System.Drawing.Point(0, 0);
			this.groupBox1.Name = "groupBox1";
			this.groupBox1.Size = new System.Drawing.Size(386, 578);
			this.groupBox1.TabIndex = 0;
			this.groupBox1.TabStop = false;
			this.groupBox1.Text = "Yaml Tree";
			// 
			// yamlNodeList
			// 
			this.yamlNodeList.Dock = System.Windows.Forms.DockStyle.Fill;
			this.yamlNodeList.Font = new System.Drawing.Font("宋体", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
			this.yamlNodeList.Location = new System.Drawing.Point(3, 17);
			this.yamlNodeList.Name = "yamlNodeList";
			this.yamlNodeList.Size = new System.Drawing.Size(380, 558);
			this.yamlNodeList.TabIndex = 0;
			this.yamlNodeList.AfterSelect += new System.Windows.Forms.TreeViewEventHandler(this.YamlNodeList_AfterSelect);
			// 
			// groupBox2
			// 
			this.groupBox2.Controls.Add(this.tableLayoutPanel1);
			this.groupBox2.Dock = System.Windows.Forms.DockStyle.Fill;
			this.groupBox2.Location = new System.Drawing.Point(0, 0);
			this.groupBox2.Name = "groupBox2";
			this.groupBox2.Size = new System.Drawing.Size(380, 578);
			this.groupBox2.TabIndex = 0;
			this.groupBox2.TabStop = false;
			this.groupBox2.Text = "Yaml Operation";
			// 
			// tableLayoutPanel1
			// 
			this.tableLayoutPanel1.ColumnCount = 1;
			this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100F));
			this.tableLayoutPanel1.Controls.Add(this.btnMoveBackward, 0, 5);
			this.tableLayoutPanel1.Controls.Add(this.btnDeleteYamlNode, 0, 3);
			this.tableLayoutPanel1.Controls.Add(this.panel1, 0, 7);
			this.tableLayoutPanel1.Controls.Add(this.btnAddYamlNode, 0, 1);
			this.tableLayoutPanel1.Controls.Add(this.btnEditYamlNode, 0, 2);
			this.tableLayoutPanel1.Controls.Add(this.btnMoveForward, 0, 4);
			this.tableLayoutPanel1.Controls.Add(this.groupBox3, 0, 0);
			this.tableLayoutPanel1.Dock = System.Windows.Forms.DockStyle.Fill;
			this.tableLayoutPanel1.Location = new System.Drawing.Point(3, 17);
			this.tableLayoutPanel1.Name = "tableLayoutPanel1";
			this.tableLayoutPanel1.RowCount = 8;
			this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 70F));
			this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 30F));
			this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 30F));
			this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 30F));
			this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 30F));
			this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 30F));
			this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
			this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 50F));
			this.tableLayoutPanel1.Size = new System.Drawing.Size(374, 558);
			this.tableLayoutPanel1.TabIndex = 0;
			// 
			// btnMoveBackward
			// 
			this.btnMoveBackward.Enabled = false;
			this.btnMoveBackward.Location = new System.Drawing.Point(3, 193);
			this.btnMoveBackward.Name = "btnMoveBackward";
			this.btnMoveBackward.Size = new System.Drawing.Size(97, 23);
			this.btnMoveBackward.TabIndex = 6;
			this.btnMoveBackward.Text = "Move Backward";
			this.btnMoveBackward.UseVisualStyleBackColor = true;
			// 
			// btnDeleteYamlNode
			// 
			this.btnDeleteYamlNode.Enabled = false;
			this.btnDeleteYamlNode.Location = new System.Drawing.Point(3, 133);
			this.btnDeleteYamlNode.Name = "btnDeleteYamlNode";
			this.btnDeleteYamlNode.Size = new System.Drawing.Size(97, 23);
			this.btnDeleteYamlNode.TabIndex = 4;
			this.btnDeleteYamlNode.Text = "Delete Node";
			this.btnDeleteYamlNode.UseVisualStyleBackColor = true;
			// 
			// panel1
			// 
			this.panel1.Controls.Add(this.btnSaveChangeToFile);
			this.panel1.Dock = System.Windows.Forms.DockStyle.Fill;
			this.panel1.Location = new System.Drawing.Point(3, 511);
			this.panel1.Name = "panel1";
			this.panel1.Size = new System.Drawing.Size(368, 44);
			this.panel1.TabIndex = 0;
			// 
			// btnSaveChangeToFile
			// 
			this.btnSaveChangeToFile.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Right)));
			this.btnSaveChangeToFile.Enabled = false;
			this.btnSaveChangeToFile.Location = new System.Drawing.Point(266, 3);
			this.btnSaveChangeToFile.Name = "btnSaveChangeToFile";
			this.btnSaveChangeToFile.Size = new System.Drawing.Size(99, 38);
			this.btnSaveChangeToFile.TabIndex = 1;
			this.btnSaveChangeToFile.Text = "Save File ";
			this.btnSaveChangeToFile.UseVisualStyleBackColor = true;
			this.btnSaveChangeToFile.Click += new System.EventHandler(this.BtnSaveChangeToFile_Click);
			// 
			// btnAddYamlNode
			// 
			this.btnAddYamlNode.Enabled = false;
			this.btnAddYamlNode.Location = new System.Drawing.Point(3, 73);
			this.btnAddYamlNode.Name = "btnAddYamlNode";
			this.btnAddYamlNode.Size = new System.Drawing.Size(97, 23);
			this.btnAddYamlNode.TabIndex = 2;
			this.btnAddYamlNode.Text = "Add Node";
			this.btnAddYamlNode.UseVisualStyleBackColor = true;
			this.btnAddYamlNode.Click += new System.EventHandler(this.BtnAddYamlNode_Click);
			// 
			// btnEditYamlNode
			// 
			this.btnEditYamlNode.Enabled = false;
			this.btnEditYamlNode.Location = new System.Drawing.Point(3, 103);
			this.btnEditYamlNode.Name = "btnEditYamlNode";
			this.btnEditYamlNode.Size = new System.Drawing.Size(97, 23);
			this.btnEditYamlNode.TabIndex = 3;
			this.btnEditYamlNode.Text = "Edit Node";
			this.btnEditYamlNode.UseVisualStyleBackColor = true;
			this.btnEditYamlNode.Click += new System.EventHandler(this.BtnEditYamlNode_Click);
			// 
			// btnMoveForward
			// 
			this.btnMoveForward.Enabled = false;
			this.btnMoveForward.Location = new System.Drawing.Point(3, 163);
			this.btnMoveForward.Name = "btnMoveForward";
			this.btnMoveForward.Size = new System.Drawing.Size(97, 23);
			this.btnMoveForward.TabIndex = 5;
			this.btnMoveForward.Text = "Move Forward";
			this.btnMoveForward.UseVisualStyleBackColor = true;
			// 
			// groupBox3
			// 
			this.groupBox3.Controls.Add(this.txtValue);
			this.groupBox3.Dock = System.Windows.Forms.DockStyle.Fill;
			this.groupBox3.Location = new System.Drawing.Point(3, 3);
			this.groupBox3.Name = "groupBox3";
			this.groupBox3.Size = new System.Drawing.Size(368, 64);
			this.groupBox3.TabIndex = 7;
			this.groupBox3.TabStop = false;
			this.groupBox3.Text = "Node Value";
			// 
			// txtValue
			// 
			this.txtValue.Dock = System.Windows.Forms.DockStyle.Fill;
			this.txtValue.Enabled = false;
			this.txtValue.Location = new System.Drawing.Point(3, 17);
			this.txtValue.Name = "txtValue";
			this.txtValue.Size = new System.Drawing.Size(362, 44);
			this.txtValue.TabIndex = 0;
			this.txtValue.Text = "";
			// 
			// ctrlVisualYamlEditor
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.Controls.Add(this.splitContainer1);
			this.Name = "ctrlVisualYamlEditor";
			this.Size = new System.Drawing.Size(770, 578);
			this.Load += new System.EventHandler(this.CtrlVisualYamlEditor_Load);
			this.splitContainer1.Panel1.ResumeLayout(false);
			this.splitContainer1.Panel2.ResumeLayout(false);
			((System.ComponentModel.ISupportInitialize)(this.splitContainer1)).EndInit();
			this.splitContainer1.ResumeLayout(false);
			this.groupBox1.ResumeLayout(false);
			this.groupBox2.ResumeLayout(false);
			this.tableLayoutPanel1.ResumeLayout(false);
			this.panel1.ResumeLayout(false);
			this.groupBox3.ResumeLayout(false);
			this.ResumeLayout(false);

		}

		#endregion

		private System.Windows.Forms.SplitContainer splitContainer1;
		private System.Windows.Forms.TreeView yamlNodeList;
		private System.Windows.Forms.GroupBox groupBox1;
		private System.Windows.Forms.GroupBox groupBox2;
		private System.Windows.Forms.TableLayoutPanel tableLayoutPanel1;
		private System.Windows.Forms.Panel panel1;
		private System.Windows.Forms.Button btnMoveForward;
		private System.Windows.Forms.Button btnDeleteYamlNode;
		private System.Windows.Forms.Button btnAddYamlNode;
		private System.Windows.Forms.Button btnEditYamlNode;
		private System.Windows.Forms.Button btnMoveBackward;
		private System.Windows.Forms.GroupBox groupBox3;
		private System.Windows.Forms.RichTextBox txtValue;
		private System.Windows.Forms.Button btnSaveChangeToFile;
	}
}