namespace OpenRAModEditor
{
	partial class ctrlTraitDetails
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
			this.label1 = new System.Windows.Forms.Label();
			this.parameterList = new System.Windows.Forms.ListView();
			this.colParameterName = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
			this.colParameterDesc = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
			this.tableLayoutPanel1.SuspendLayout();
			this.SuspendLayout();
			// 
			// tableLayoutPanel1
			// 
			this.tableLayoutPanel1.ColumnCount = 1;
			this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100F));
			this.tableLayoutPanel1.Controls.Add(this.label1, 0, 0);
			this.tableLayoutPanel1.Controls.Add(this.parameterList, 0, 2);
			this.tableLayoutPanel1.Dock = System.Windows.Forms.DockStyle.Fill;
			this.tableLayoutPanel1.Location = new System.Drawing.Point(0, 0);
			this.tableLayoutPanel1.Name = "tableLayoutPanel1";
			this.tableLayoutPanel1.RowCount = 3;
			this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 30F));
			this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 20F));
			this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
			this.tableLayoutPanel1.Size = new System.Drawing.Size(561, 536);
			this.tableLayoutPanel1.TabIndex = 0;
			// 
			// label1
			// 
			this.label1.AutoSize = true;
			this.label1.Font = new System.Drawing.Font("宋体", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
			this.label1.Location = new System.Drawing.Point(3, 0);
			this.label1.Name = "label1";
			this.label1.Size = new System.Drawing.Size(142, 21);
			this.label1.TabIndex = 0;
			this.label1.Text = "Dummy Trait";
			this.label1.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
			// 
			// parameterList
			// 
			this.parameterList.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.colParameterName,
            this.colParameterDesc});
			this.parameterList.Dock = System.Windows.Forms.DockStyle.Fill;
			this.parameterList.Location = new System.Drawing.Point(3, 53);
			this.parameterList.Name = "parameterList";
			this.parameterList.Size = new System.Drawing.Size(555, 480);
			this.parameterList.TabIndex = 1;
			this.parameterList.UseCompatibleStateImageBehavior = false;
			this.parameterList.View = System.Windows.Forms.View.Details;
			// 
			// colParameterName
			// 
			this.colParameterName.Text = "Parameter Name";
			this.colParameterName.Width = 272;
			// 
			// colParameterDesc
			// 
			this.colParameterDesc.Text = "Parameter Desc";
			this.colParameterDesc.Width = 275;
			// 
			// ctrlTraitDetails
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.Controls.Add(this.tableLayoutPanel1);
			this.Name = "ctrlTraitDetails";
			this.Size = new System.Drawing.Size(561, 536);
			this.tableLayoutPanel1.ResumeLayout(false);
			this.tableLayoutPanel1.PerformLayout();
			this.ResumeLayout(false);

		}

		#endregion

		private System.Windows.Forms.TableLayoutPanel tableLayoutPanel1;
		private System.Windows.Forms.Label label1;
		private System.Windows.Forms.ListView parameterList;
		private System.Windows.Forms.ColumnHeader colParameterName;
		private System.Windows.Forms.ColumnHeader colParameterDesc;
	}
}
