namespace RSS阅读器
{
    partial class MainForm
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            System.Windows.Forms.TreeNode treeNode1 = new System.Windows.Forms.TreeNode("节点0");
            System.Windows.Forms.TreeNode treeNode2 = new System.Windows.Forms.TreeNode("节点1");
            System.Windows.Forms.TreeNode treeNode3 = new System.Windows.Forms.TreeNode("节点2");
            System.Windows.Forms.TreeNode treeNode4 = new System.Windows.Forms.TreeNode("节点3");
            System.Windows.Forms.TreeNode treeNode5 = new System.Windows.Forms.TreeNode("节点4");
            System.Windows.Forms.TreeNode treeNode6 = new System.Windows.Forms.TreeNode("节点5");
            System.Windows.Forms.TreeNode treeNode7 = new System.Windows.Forms.TreeNode("RSS订阅列表", new System.Windows.Forms.TreeNode[] {
            treeNode1,
            treeNode2,
            treeNode3,
            treeNode4,
            treeNode5,
            treeNode6});
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(MainForm));
            this.RssListView = new System.Windows.Forms.ListView();
            this.columnHeader1 = new System.Windows.Forms.ColumnHeader();
            this.columnHeader2 = new System.Windows.Forms.ColumnHeader();
            this.columnHeader3 = new System.Windows.Forms.ColumnHeader();
            this.splitContainer1 = new System.Windows.Forms.SplitContainer();
            this.RssTreeView = new System.Windows.Forms.TreeView();
            this.contextMenuStrip1 = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.刷新ToolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
            this.新增频道ToolStripMenuItem2 = new System.Windows.Forms.ToolStripMenuItem();
            this.splitContainer2 = new System.Windows.Forms.SplitContainer();
            this.linkTabControl = new System.Windows.Forms.TabControl();
            this.toolStrip1 = new System.Windows.Forms.ToolStrip();
            this.tsbPrevious = new System.Windows.Forms.ToolStripButton();
            this.tsbNext = new System.Windows.Forms.ToolStripButton();
            this.tsbRefresh = new System.Windows.Forms.ToolStripButton();
            this.toolStripSeparator1 = new System.Windows.Forms.ToolStripSeparator();
            this.tsbAdd = new System.Windows.Forms.ToolStripButton();
            this.tsbLink = new System.Windows.Forms.ToolStripButton();
            this.tsbRssList = new System.Windows.Forms.ToolStripButton();
            this.mainMenu = new System.Windows.Forms.MenuStrip();
            this.tsmFile = new System.Windows.Forms.ToolStripMenuItem();
            this.链接管理ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripMenuItem1 = new System.Windows.Forms.ToolStripSeparator();
            this.关闭ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.tsmSettings = new System.Windows.Forms.ToolStripMenuItem();
            this.新增频道ToolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
            this.刷新ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.tsmAbout = new System.Windows.Forms.ToolStripMenuItem();
            this.tsmSetting = new System.Windows.Forms.ToolStripMenuItem();
            this.新增频道ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripMenuItem2 = new System.Windows.Forms.ToolStripMenuItem();
            this.statusStrip1 = new System.Windows.Forms.StatusStrip();
            this.rssToolStripStatusLabel = new System.Windows.Forms.ToolStripStatusLabel();
            this.timeToolStripStatusLabel = new System.Windows.Forms.ToolStripStatusLabel();
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer1)).BeginInit();
            this.splitContainer1.Panel1.SuspendLayout();
            this.splitContainer1.Panel2.SuspendLayout();
            this.splitContainer1.SuspendLayout();
            this.contextMenuStrip1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer2)).BeginInit();
            this.splitContainer2.Panel1.SuspendLayout();
            this.splitContainer2.Panel2.SuspendLayout();
            this.splitContainer2.SuspendLayout();
            this.toolStrip1.SuspendLayout();
            this.mainMenu.SuspendLayout();
            this.statusStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // RssListView
            // 
            this.RssListView.Activation = System.Windows.Forms.ItemActivation.OneClick;
            this.RssListView.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.columnHeader1,
            this.columnHeader2,
            this.columnHeader3});
            this.RssListView.Dock = System.Windows.Forms.DockStyle.Fill;
            this.RssListView.FullRowSelect = true;
            this.RssListView.HotTracking = true;
            this.RssListView.HoverSelection = true;
            this.RssListView.Location = new System.Drawing.Point(0, 0);
            this.RssListView.Margin = new System.Windows.Forms.Padding(4);
            this.RssListView.MultiSelect = false;
            this.RssListView.Name = "RssListView";
            this.RssListView.Size = new System.Drawing.Size(1181, 357);
            this.RssListView.TabIndex = 1;
            this.RssListView.UseCompatibleStateImageBehavior = false;
            this.RssListView.View = System.Windows.Forms.View.Details;
            this.RssListView.MouseDoubleClick += new System.Windows.Forms.MouseEventHandler(this.RssListView_MouseDoubleClick);
            this.RssListView.MouseMove += new System.Windows.Forms.MouseEventHandler(this.RssListView_MouseMove);
            // 
            // columnHeader1
            // 
            this.columnHeader1.Text = "标题";
            this.columnHeader1.Width = 250;
            // 
            // columnHeader2
            // 
            this.columnHeader2.Text = "描述";
            this.columnHeader2.Width = 400;
            // 
            // columnHeader3
            // 
            this.columnHeader3.Text = "路径";
            this.columnHeader3.Width = 150;
            // 
            // splitContainer1
            // 
            this.splitContainer1.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.splitContainer1.Location = new System.Drawing.Point(0, 73);
            this.splitContainer1.Margin = new System.Windows.Forms.Padding(4);
            this.splitContainer1.Name = "splitContainer1";
            // 
            // splitContainer1.Panel1
            // 
            this.splitContainer1.Panel1.Controls.Add(this.RssTreeView);
            // 
            // splitContainer1.Panel2
            // 
            this.splitContainer1.Panel2.Controls.Add(this.splitContainer2);
            this.splitContainer1.Size = new System.Drawing.Size(1569, 824);
            this.splitContainer1.SplitterDistance = 383;
            this.splitContainer1.SplitterWidth = 5;
            this.splitContainer1.TabIndex = 2;
            // 
            // RssTreeView
            // 
            this.RssTreeView.ContextMenuStrip = this.contextMenuStrip1;
            this.RssTreeView.Dock = System.Windows.Forms.DockStyle.Fill;
            this.RssTreeView.Location = new System.Drawing.Point(0, 0);
            this.RssTreeView.Margin = new System.Windows.Forms.Padding(4);
            this.RssTreeView.Name = "RssTreeView";
            treeNode1.Name = "节点0";
            treeNode1.Text = "节点0";
            treeNode2.Name = "节点1";
            treeNode2.Text = "节点1";
            treeNode3.Name = "节点2";
            treeNode3.Text = "节点2";
            treeNode4.Name = "节点3";
            treeNode4.Text = "节点3";
            treeNode5.Name = "节点4";
            treeNode5.Text = "节点4";
            treeNode6.Name = "节点5";
            treeNode6.Text = "节点5";
            treeNode7.Name = "RssRoot";
            treeNode7.Text = "RSS订阅列表";
            this.RssTreeView.Nodes.AddRange(new System.Windows.Forms.TreeNode[] {
            treeNode7});
            this.RssTreeView.Size = new System.Drawing.Size(383, 824);
            this.RssTreeView.TabIndex = 1;
            this.RssTreeView.AfterSelect += new System.Windows.Forms.TreeViewEventHandler(this.RssTreeView_AfterSelect);
            this.RssTreeView.DoubleClick += new System.EventHandler(this.RssTreeView_DoubleClick);
            // 
            // contextMenuStrip1
            // 
            this.contextMenuStrip1.ImageScalingSize = new System.Drawing.Size(24, 24);
            this.contextMenuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.刷新ToolStripMenuItem1,
            this.新增频道ToolStripMenuItem2});
            this.contextMenuStrip1.Name = "contextMenuStrip1";
            this.contextMenuStrip1.Size = new System.Drawing.Size(153, 64);
            // 
            // 刷新ToolStripMenuItem1
            // 
            this.刷新ToolStripMenuItem1.Name = "刷新ToolStripMenuItem1";
            this.刷新ToolStripMenuItem1.Size = new System.Drawing.Size(152, 30);
            this.刷新ToolStripMenuItem1.Text = "刷新列表";
            this.刷新ToolStripMenuItem1.Click += new System.EventHandler(this.刷新ToolStripMenuItem1_Click);
            // 
            // 新增频道ToolStripMenuItem2
            // 
            this.新增频道ToolStripMenuItem2.Name = "新增频道ToolStripMenuItem2";
            this.新增频道ToolStripMenuItem2.Size = new System.Drawing.Size(152, 30);
            this.新增频道ToolStripMenuItem2.Text = "新增频道";
            this.新增频道ToolStripMenuItem2.Click += new System.EventHandler(this.新增频道ToolStripMenuItem2_Click);
            // 
            // splitContainer2
            // 
            this.splitContainer2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.splitContainer2.Location = new System.Drawing.Point(0, 0);
            this.splitContainer2.Name = "splitContainer2";
            this.splitContainer2.Orientation = System.Windows.Forms.Orientation.Horizontal;
            // 
            // splitContainer2.Panel1
            // 
            this.splitContainer2.Panel1.Controls.Add(this.RssListView);
            // 
            // splitContainer2.Panel2
            // 
            this.splitContainer2.Panel2.Controls.Add(this.linkTabControl);
            this.splitContainer2.Size = new System.Drawing.Size(1181, 824);
            this.splitContainer2.SplitterDistance = 357;
            this.splitContainer2.TabIndex = 2;
            // 
            // linkTabControl
            // 
            this.linkTabControl.Dock = System.Windows.Forms.DockStyle.Fill;
            this.linkTabControl.Location = new System.Drawing.Point(0, 0);
            this.linkTabControl.Name = "linkTabControl";
            this.linkTabControl.SelectedIndex = 0;
            this.linkTabControl.Size = new System.Drawing.Size(1181, 463);
            this.linkTabControl.TabIndex = 0;
            this.linkTabControl.MouseDoubleClick += new System.Windows.Forms.MouseEventHandler(this.linkTabControl_MouseDoubleClick);
            // 
            // toolStrip1
            // 
            this.toolStrip1.ImageScalingSize = new System.Drawing.Size(24, 24);
            this.toolStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.tsbPrevious,
            this.tsbNext,
            this.tsbRefresh,
            this.toolStripSeparator1,
            this.tsbAdd,
            this.tsbLink,
            this.tsbRssList});
            this.toolStrip1.Location = new System.Drawing.Point(0, 32);
            this.toolStrip1.Name = "toolStrip1";
            this.toolStrip1.Size = new System.Drawing.Size(1569, 37);
            this.toolStrip1.TabIndex = 3;
            this.toolStrip1.Text = "toolStrip1";
            // 
            // tsbPrevious
            // 
            this.tsbPrevious.Font = new System.Drawing.Font("Microsoft YaHei UI", 10.5F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.tsbPrevious.Image = ((System.Drawing.Image)(resources.GetObject("tsbPrevious.Image")));
            this.tsbPrevious.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.tsbPrevious.Name = "tsbPrevious";
            this.tsbPrevious.Size = new System.Drawing.Size(82, 32);
            this.tsbPrevious.Text = "向前";
            this.tsbPrevious.ToolTipText = "选择前一个RSS文档";
            this.tsbPrevious.Click += new System.EventHandler(this.tsbPrevious_Click);
            // 
            // tsbNext
            // 
            this.tsbNext.Font = new System.Drawing.Font("Microsoft YaHei UI", 10.5F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.tsbNext.Image = ((System.Drawing.Image)(resources.GetObject("tsbNext.Image")));
            this.tsbNext.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.tsbNext.Name = "tsbNext";
            this.tsbNext.Size = new System.Drawing.Size(82, 32);
            this.tsbNext.Text = "向后";
            this.tsbNext.ToolTipText = "选择后一个RSS文档";
            this.tsbNext.Click += new System.EventHandler(this.tsbNext_Click);
            // 
            // tsbRefresh
            // 
            this.tsbRefresh.Font = new System.Drawing.Font("Microsoft YaHei UI", 10.5F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.tsbRefresh.Image = ((System.Drawing.Image)(resources.GetObject("tsbRefresh.Image")));
            this.tsbRefresh.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.tsbRefresh.Name = "tsbRefresh";
            this.tsbRefresh.Size = new System.Drawing.Size(82, 32);
            this.tsbRefresh.Text = "刷新";
            this.tsbRefresh.ToolTipText = "刷新文档";
            this.tsbRefresh.Click += new System.EventHandler(this.tsbRefresh_Click);
            // 
            // toolStripSeparator1
            // 
            this.toolStripSeparator1.Name = "toolStripSeparator1";
            this.toolStripSeparator1.Size = new System.Drawing.Size(6, 37);
            // 
            // tsbAdd
            // 
            this.tsbAdd.Font = new System.Drawing.Font("Microsoft YaHei UI", 10.5F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.tsbAdd.Image = ((System.Drawing.Image)(resources.GetObject("tsbAdd.Image")));
            this.tsbAdd.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.tsbAdd.Name = "tsbAdd";
            this.tsbAdd.Size = new System.Drawing.Size(124, 32);
            this.tsbAdd.Text = "新增频道";
            this.tsbAdd.Click += new System.EventHandler(this.tsbAdd_Click);
            // 
            // tsbLink
            // 
            this.tsbLink.Image = ((System.Drawing.Image)(resources.GetObject("tsbLink.Image")));
            this.tsbLink.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.tsbLink.Name = "tsbLink";
            this.tsbLink.Size = new System.Drawing.Size(74, 32);
            this.tsbLink.Text = "链接";
            this.tsbLink.Click += new System.EventHandler(this.tsbLink_Click);
            // 
            // tsbRssList
            // 
            this.tsbRssList.Image = ((System.Drawing.Image)(resources.GetObject("tsbRssList.Image")));
            this.tsbRssList.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.tsbRssList.Name = "tsbRssList";
            this.tsbRssList.Size = new System.Drawing.Size(142, 32);
            this.tsbRssList.Text = "RSS文档列表";
            this.tsbRssList.Click += new System.EventHandler(this.tsbRssList_Click);
            // 
            // mainMenu
            // 
            this.mainMenu.ImageScalingSize = new System.Drawing.Size(24, 24);
            this.mainMenu.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.tsmFile,
            this.tsmSettings,
            this.tsmAbout});
            this.mainMenu.Location = new System.Drawing.Point(0, 0);
            this.mainMenu.Name = "mainMenu";
            this.mainMenu.Size = new System.Drawing.Size(1569, 32);
            this.mainMenu.TabIndex = 4;
            this.mainMenu.Text = "menuStrip1";
            // 
            // tsmFile
            // 
            this.tsmFile.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.链接管理ToolStripMenuItem,
            this.toolStripMenuItem1,
            this.关闭ToolStripMenuItem});
            this.tsmFile.Name = "tsmFile";
            this.tsmFile.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Alt | System.Windows.Forms.Keys.F)));
            this.tsmFile.Size = new System.Drawing.Size(84, 28);
            this.tsmFile.Text = "文件(F)";
            // 
            // 链接管理ToolStripMenuItem
            // 
            this.链接管理ToolStripMenuItem.Name = "链接管理ToolStripMenuItem";
            this.链接管理ToolStripMenuItem.Size = new System.Drawing.Size(182, 34);
            this.链接管理ToolStripMenuItem.Text = "链接管理";
            this.链接管理ToolStripMenuItem.Click += new System.EventHandler(this.链接管理ToolStripMenuItem_Click);
            // 
            // toolStripMenuItem1
            // 
            this.toolStripMenuItem1.Name = "toolStripMenuItem1";
            this.toolStripMenuItem1.Size = new System.Drawing.Size(179, 6);
            // 
            // 关闭ToolStripMenuItem
            // 
            this.关闭ToolStripMenuItem.Name = "关闭ToolStripMenuItem";
            this.关闭ToolStripMenuItem.Size = new System.Drawing.Size(182, 34);
            this.关闭ToolStripMenuItem.Text = "关闭";
            this.关闭ToolStripMenuItem.Click += new System.EventHandler(this.关闭ToolStripMenuItem_Click);
            // 
            // tsmSettings
            // 
            this.tsmSettings.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.新增频道ToolStripMenuItem1,
            this.刷新ToolStripMenuItem});
            this.tsmSettings.Name = "tsmSettings";
            this.tsmSettings.Size = new System.Drawing.Size(120, 28);
            this.tsmSettings.Text = "频道设置(S)";
            // 
            // 新增频道ToolStripMenuItem1
            // 
            this.新增频道ToolStripMenuItem1.Name = "新增频道ToolStripMenuItem1";
            this.新增频道ToolStripMenuItem1.Size = new System.Drawing.Size(182, 34);
            this.新增频道ToolStripMenuItem1.Text = "新增频道";
            this.新增频道ToolStripMenuItem1.Click += new System.EventHandler(this.新增频道ToolStripMenuItem1_Click);
            // 
            // 刷新ToolStripMenuItem
            // 
            this.刷新ToolStripMenuItem.Name = "刷新ToolStripMenuItem";
            this.刷新ToolStripMenuItem.Size = new System.Drawing.Size(182, 34);
            this.刷新ToolStripMenuItem.Text = "刷新";
            this.刷新ToolStripMenuItem.Click += new System.EventHandler(this.刷新ToolStripMenuItem_Click);
            // 
            // tsmAbout
            // 
            this.tsmAbout.Name = "tsmAbout";
            this.tsmAbout.Size = new System.Drawing.Size(88, 28);
            this.tsmAbout.Text = "关于(H)";
            this.tsmAbout.Click += new System.EventHandler(this.tsmAbout_Click);
            // 
            // tsmSetting
            // 
            this.tsmSetting.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.新增频道ToolStripMenuItem,
            this.toolStripMenuItem2});
            this.tsmSetting.Name = "tsmSetting";
            this.tsmSetting.Size = new System.Drawing.Size(182, 28);
            this.tsmSetting.Text = "频道设置(S)";
            // 
            // 新增频道ToolStripMenuItem
            // 
            this.新增频道ToolStripMenuItem.Name = "新增频道ToolStripMenuItem";
            this.新增频道ToolStripMenuItem.Size = new System.Drawing.Size(182, 34);
            this.新增频道ToolStripMenuItem.Text = "新增频道";
            // 
            // toolStripMenuItem2
            // 
            this.toolStripMenuItem2.Name = "toolStripMenuItem2";
            this.toolStripMenuItem2.Size = new System.Drawing.Size(182, 34);
            // 
            // statusStrip1
            // 
            this.statusStrip1.ImageScalingSize = new System.Drawing.Size(24, 24);
            this.statusStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.rssToolStripStatusLabel,
            this.timeToolStripStatusLabel});
            this.statusStrip1.Location = new System.Drawing.Point(0, 876);
            this.statusStrip1.Name = "statusStrip1";
            this.statusStrip1.Size = new System.Drawing.Size(1569, 22);
            this.statusStrip1.TabIndex = 5;
            this.statusStrip1.Text = "statusStrip1";
            // 
            // rssToolStripStatusLabel
            // 
            this.rssToolStripStatusLabel.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Text;
            this.rssToolStripStatusLabel.Name = "rssToolStripStatusLabel";
            this.rssToolStripStatusLabel.Size = new System.Drawing.Size(1550, 15);
            this.rssToolStripStatusLabel.Spring = true;
            this.rssToolStripStatusLabel.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // timeToolStripStatusLabel
            // 
            this.timeToolStripStatusLabel.BorderSides = ((System.Windows.Forms.ToolStripStatusLabelBorderSides)((((System.Windows.Forms.ToolStripStatusLabelBorderSides.Left | System.Windows.Forms.ToolStripStatusLabelBorderSides.Top) 
            | System.Windows.Forms.ToolStripStatusLabelBorderSides.Right) 
            | System.Windows.Forms.ToolStripStatusLabelBorderSides.Bottom)));
            this.timeToolStripStatusLabel.BorderStyle = System.Windows.Forms.Border3DStyle.Sunken;
            this.timeToolStripStatusLabel.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Text;
            this.timeToolStripStatusLabel.Name = "timeToolStripStatusLabel";
            this.timeToolStripStatusLabel.Size = new System.Drawing.Size(4, 15);
            this.timeToolStripStatusLabel.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // timer1
            // 
            this.timer1.Enabled = true;
            this.timer1.Interval = 1000;
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(11F, 24F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1569, 898);
            this.Controls.Add(this.statusStrip1);
            this.Controls.Add(this.toolStrip1);
            this.Controls.Add(this.mainMenu);
            this.Controls.Add(this.splitContainer1);
            this.MainMenuStrip = this.mainMenu;
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "MainForm";
            this.Text = "RssReader";
            this.KeyDown += new System.Windows.Forms.KeyEventHandler(this.MainForm_KeyDown);
            this.splitContainer1.Panel1.ResumeLayout(false);
            this.splitContainer1.Panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer1)).EndInit();
            this.splitContainer1.ResumeLayout(false);
            this.contextMenuStrip1.ResumeLayout(false);
            this.splitContainer2.Panel1.ResumeLayout(false);
            this.splitContainer2.Panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer2)).EndInit();
            this.splitContainer2.ResumeLayout(false);
            this.toolStrip1.ResumeLayout(false);
            this.toolStrip1.PerformLayout();
            this.mainMenu.ResumeLayout(false);
            this.mainMenu.PerformLayout();
            this.statusStrip1.ResumeLayout(false);
            this.statusStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        public ListView RssListView;
        private ColumnHeader columnHeader1;
        private ColumnHeader columnHeader2;
        private ColumnHeader columnHeader3;
        private SplitContainer splitContainer1;
        private TreeView RssTreeView;
        private ToolStrip toolStrip1;
        private ToolStripButton tsbPrevious;
        private ToolStripButton tsbNext;
        private ToolStripButton tsbRefresh;
        private ToolStripSeparator toolStripSeparator1;
        private ToolStripButton tsbAdd;
        private ToolStripButton tsbLink;
        private ToolStripButton tsbRssList;
        private SplitContainer splitContainer2;
        private TabControl linkTabControl;
        private MenuStrip mainMenu;
        private ToolStripMenuItem tsmFile;
        private ToolStripMenuItem tsmSetting;
        private ToolStripMenuItem tsmAbout;
        private ToolStripMenuItem 链接管理ToolStripMenuItem;
        private ToolStripSeparator toolStripMenuItem1;
        private ToolStripMenuItem 关闭ToolStripMenuItem;
        private ToolStripMenuItem 新增频道ToolStripMenuItem;
        private ToolStripMenuItem toolStripMenuItem2;
        private ToolStripMenuItem tsmSettings;
        private ToolStripMenuItem 新增频道ToolStripMenuItem1;
        private ToolStripMenuItem 刷新ToolStripMenuItem;
        private ContextMenuStrip contextMenuStrip1;
        private ToolStripMenuItem 刷新ToolStripMenuItem1;
        private ToolStripMenuItem 新增频道ToolStripMenuItem2;
        private StatusStrip statusStrip1;
        private ToolStripStatusLabel rssToolStripStatusLabel;
        private ToolStripStatusLabel timeToolStripStatusLabel;
        private System.Windows.Forms.Timer timer1;
    }
}