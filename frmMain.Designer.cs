namespace OpenRAModEditor
{
	partial class frmMain
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
			this.components = new System.ComponentModel.Container();
			System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmMain));
			this.toolBar = new System.Windows.Forms.ToolStrip();
			this.btnSave = new System.Windows.Forms.ToolStripButton();
			this.btnRunMod = new System.Windows.Forms.ToolStripButton();
			this.splitContainer1 = new System.Windows.Forms.SplitContainer();
			this.groupBox1 = new System.Windows.Forms.GroupBox();
			this.modFileList = new System.Windows.Forms.TreeView();
			this.menu = new System.Windows.Forms.MenuStrip();
			this.fileToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
			this.mnuExit = new System.Windows.Forms.ToolStripMenuItem();
			this.modToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
			this.menuBasicInfomation = new System.Windows.Forms.ToolStripMenuItem();
			this.mnuRunMod = new System.Windows.Forms.ToolStripMenuItem();
			this.helpToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
			this.mnuOpenRAWiki = new System.Windows.Forms.ToolStripMenuItem();
			this.mnuOpenRATraitWiki = new System.Windows.Forms.ToolStripMenuItem();
			this.mnuAbout = new System.Windows.Forms.ToolStripMenuItem();
			this.images = new System.Windows.Forms.ImageList(this.components);
			this.toolBar.SuspendLayout();
			((System.ComponentModel.ISupportInitialize)(this.splitContainer1)).BeginInit();
			this.splitContainer1.Panel1.SuspendLayout();
			this.splitContainer1.SuspendLayout();
			this.groupBox1.SuspendLayout();
			this.menu.SuspendLayout();
			this.SuspendLayout();
			// 
			// toolBar
			// 
			this.toolBar.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.btnSave,
            this.btnRunMod});
			this.toolBar.Location = new System.Drawing.Point(0, 25);
			this.toolBar.Name = "toolBar";
			this.toolBar.Size = new System.Drawing.Size(978, 25);
			this.toolBar.TabIndex = 0;
			this.toolBar.Text = "toolStrip1";
			// 
			// btnSave
			// 
			this.btnSave.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
			this.btnSave.Image = ((System.Drawing.Image)(resources.GetObject("btnSave.Image")));
			this.btnSave.ImageTransparentColor = System.Drawing.Color.Magenta;
			this.btnSave.Name = "btnSave";
			this.btnSave.Size = new System.Drawing.Size(23, 22);
			this.btnSave.Text = "Save";
			// 
			// btnRunMod
			// 
			this.btnRunMod.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
			this.btnRunMod.Image = ((System.Drawing.Image)(resources.GetObject("btnRunMod.Image")));
			this.btnRunMod.ImageTransparentColor = System.Drawing.Color.Magenta;
			this.btnRunMod.Name = "btnRunMod";
			this.btnRunMod.Size = new System.Drawing.Size(23, 22);
			this.btnRunMod.Text = "Run Mod";
			// 
			// splitContainer1
			// 
			this.splitContainer1.Dock = System.Windows.Forms.DockStyle.Fill;
			this.splitContainer1.Location = new System.Drawing.Point(0, 50);
			this.splitContainer1.Name = "splitContainer1";
			// 
			// splitContainer1.Panel1
			// 
			this.splitContainer1.Panel1.Controls.Add(this.groupBox1);
			this.splitContainer1.Size = new System.Drawing.Size(978, 552);
			this.splitContainer1.SplitterDistance = 170;
			this.splitContainer1.TabIndex = 1;
			// 
			// groupBox1
			// 
			this.groupBox1.Controls.Add(this.modFileList);
			this.groupBox1.Dock = System.Windows.Forms.DockStyle.Fill;
			this.groupBox1.Location = new System.Drawing.Point(0, 0);
			this.groupBox1.Name = "groupBox1";
			this.groupBox1.Size = new System.Drawing.Size(170, 552);
			this.groupBox1.TabIndex = 0;
			this.groupBox1.TabStop = false;
			this.groupBox1.Text = "File List";
			// 
			// modFileList
			// 
			this.modFileList.Dock = System.Windows.Forms.DockStyle.Fill;
			this.modFileList.Font = new System.Drawing.Font("宋体", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
			this.modFileList.ImageIndex = 0;
			this.modFileList.ImageList = this.images;
			this.modFileList.Location = new System.Drawing.Point(3, 17);
			this.modFileList.Name = "modFileList";
			this.modFileList.SelectedImageIndex = 0;
			this.modFileList.Size = new System.Drawing.Size(164, 532);
			this.modFileList.TabIndex = 0;
			this.modFileList.AfterExpand += new System.Windows.Forms.TreeViewEventHandler(this.ModFileList_AfterExpand);
			this.modFileList.AfterSelect += new System.Windows.Forms.TreeViewEventHandler(this.ModFileList_AfterSelect);
			// 
			// menu
			// 
			this.menu.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.fileToolStripMenuItem,
            this.modToolStripMenuItem,
            this.helpToolStripMenuItem});
			this.menu.Location = new System.Drawing.Point(0, 0);
			this.menu.Name = "menu";
			this.menu.Size = new System.Drawing.Size(978, 25);
			this.menu.TabIndex = 2;
			this.menu.Text = "menuStrip1";
			// 
			// fileToolStripMenuItem
			// 
			this.fileToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.mnuExit});
			this.fileToolStripMenuItem.Name = "fileToolStripMenuItem";
			this.fileToolStripMenuItem.Size = new System.Drawing.Size(39, 21);
			this.fileToolStripMenuItem.Text = "File";
			// 
			// mnuExit
			// 
			this.mnuExit.Name = "mnuExit";
			this.mnuExit.Size = new System.Drawing.Size(96, 22);
			this.mnuExit.Text = "Exit";
			this.mnuExit.Click += new System.EventHandler(this.MnuExit_Click);
			// 
			// modToolStripMenuItem
			// 
			this.modToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.menuBasicInfomation,
            this.mnuRunMod});
			this.modToolStripMenuItem.Name = "modToolStripMenuItem";
			this.modToolStripMenuItem.Size = new System.Drawing.Size(48, 21);
			this.modToolStripMenuItem.Text = "Mod";
			// 
			// menuBasicInfomation
			// 
			this.menuBasicInfomation.Name = "menuBasicInfomation";
			this.menuBasicInfomation.Size = new System.Drawing.Size(173, 22);
			this.menuBasicInfomation.Text = "Basic Infomation";
			this.menuBasicInfomation.Click += new System.EventHandler(this.MenuBasicInfomation_Click);
			// 
			// mnuRunMod
			// 
			this.mnuRunMod.Name = "mnuRunMod";
			this.mnuRunMod.Size = new System.Drawing.Size(173, 22);
			this.mnuRunMod.Text = "Run";
			this.mnuRunMod.Click += new System.EventHandler(this.MnuRunMod_Click);
			// 
			// helpToolStripMenuItem
			// 
			this.helpToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.mnuOpenRAWiki,
            this.mnuOpenRATraitWiki,
            this.mnuAbout});
			this.helpToolStripMenuItem.Name = "helpToolStripMenuItem";
			this.helpToolStripMenuItem.Size = new System.Drawing.Size(47, 21);
			this.helpToolStripMenuItem.Text = "Help";
			// 
			// mnuOpenRAWiki
			// 
			this.mnuOpenRAWiki.Name = "mnuOpenRAWiki";
			this.mnuOpenRAWiki.Size = new System.Drawing.Size(183, 22);
			this.mnuOpenRAWiki.Text = "OpenRA Wiki";
			this.mnuOpenRAWiki.Click += new System.EventHandler(this.MnuOpenRAWiki_Click);
			// 
			// mnuOpenRATraitWiki
			// 
			this.mnuOpenRATraitWiki.Name = "mnuOpenRATraitWiki";
			this.mnuOpenRATraitWiki.Size = new System.Drawing.Size(183, 22);
			this.mnuOpenRATraitWiki.Text = "OpenRA Trait Wiki";
			this.mnuOpenRATraitWiki.Click += new System.EventHandler(this.MnuOpenRATraitWiki_Click);
			// 
			// mnuAbout
			// 
			this.mnuAbout.Name = "mnuAbout";
			this.mnuAbout.Size = new System.Drawing.Size(183, 22);
			this.mnuAbout.Text = "About";
			this.mnuAbout.Click += new System.EventHandler(this.MnuAbout_Click);
			// 
			// images
			// 
			this.images.ImageStream = ((System.Windows.Forms.ImageListStreamer)(resources.GetObject("images.ImageStream")));
			this.images.TransparentColor = System.Drawing.Color.Transparent;
			this.images.Images.SetKeyName(0, "folder.png");
			this.images.Images.SetKeyName(1, "file.png");
			this.images.Images.SetKeyName(2, "file_yaml.png");
			// 
			// frmMain
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.ClientSize = new System.Drawing.Size(978, 602);
			this.Controls.Add(this.splitContainer1);
			this.Controls.Add(this.toolBar);
			this.Controls.Add(this.menu);
			this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
			this.MainMenuStrip = this.menu;
			this.Name = "frmMain";
			this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
			this.Text = "OpenRA Mod Editor";
			this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
			this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.FrmMain_FormClosed);
			this.toolBar.ResumeLayout(false);
			this.toolBar.PerformLayout();
			this.splitContainer1.Panel1.ResumeLayout(false);
			((System.ComponentModel.ISupportInitialize)(this.splitContainer1)).EndInit();
			this.splitContainer1.ResumeLayout(false);
			this.groupBox1.ResumeLayout(false);
			this.menu.ResumeLayout(false);
			this.menu.PerformLayout();
			this.ResumeLayout(false);
			this.PerformLayout();

		}

		#endregion

		private System.Windows.Forms.ToolStrip toolBar;
		private System.Windows.Forms.ToolStripButton btnRunMod;
		private System.Windows.Forms.SplitContainer splitContainer1;
		private System.Windows.Forms.TreeView modFileList;
		private System.Windows.Forms.MenuStrip menu;
		private System.Windows.Forms.ToolStripMenuItem fileToolStripMenuItem;
		private System.Windows.Forms.ToolStripMenuItem mnuExit;
		private System.Windows.Forms.ToolStripMenuItem modToolStripMenuItem;
		private System.Windows.Forms.ToolStripMenuItem menuBasicInfomation;
		private System.Windows.Forms.ToolStripMenuItem mnuRunMod;
		private System.Windows.Forms.ToolStripMenuItem helpToolStripMenuItem;
		private System.Windows.Forms.ToolStripMenuItem mnuOpenRAWiki;
		private System.Windows.Forms.ToolStripMenuItem mnuOpenRATraitWiki;
		private System.Windows.Forms.ToolStripMenuItem mnuAbout;
		private System.Windows.Forms.ToolStripButton btnSave;
		private System.Windows.Forms.GroupBox groupBox1;
		private System.Windows.Forms.ImageList images;
	}
}