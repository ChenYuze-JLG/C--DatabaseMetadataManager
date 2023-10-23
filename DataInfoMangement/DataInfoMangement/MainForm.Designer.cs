
namespace DataInfoMangement
{
    partial class MainForm
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
            this.components = new System.ComponentModel.Container();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle3 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle4 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle5 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle13 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle14 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle8 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle9 = new System.Windows.Forms.DataGridViewCellStyle();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(MainForm));
            this.menuStripMain = new System.Windows.Forms.MenuStrip();
            this.文件ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.打开数据库ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.关闭数据库ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.退出ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.编辑ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.帮助ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripMain = new System.Windows.Forms.ToolStrip();
            this.tabControlMain = new System.Windows.Forms.TabControl();
            this.tabPageDBStruct = new System.Windows.Forms.TabPage();
            this.splitContainerDBStruct = new System.Windows.Forms.SplitContainer();
            this.dataGridViewDBStruct = new System.Windows.Forms.DataGridView();
            this.contextMenuStripDBStruct = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.查看表ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.tableLayoutPanelDBStructButton = new System.Windows.Forms.TableLayoutPanel();
            this.buttonAddTable = new System.Windows.Forms.Button();
            this.buttonDeleteTable = new System.Windows.Forms.Button();
            this.tabPageDTStruct = new System.Windows.Forms.TabPage();
            this.splitContainerDTStruct = new System.Windows.Forms.SplitContainer();
            this.dataGridViewDTStruct = new System.Windows.Forms.DataGridView();
            this.tableLayoutPanelDTStructButton = new System.Windows.Forms.TableLayoutPanel();
            this.buttonEditTable = new System.Windows.Forms.Button();
            this.buttonFlush = new System.Windows.Forms.Button();
            this.toolStripButtonConnectSetting = new System.Windows.Forms.ToolStripButton();
            this.toolStripButtonAutoConnect = new System.Windows.Forms.ToolStripButton();
            this.toolStripButtonCloseDB = new System.Windows.Forms.ToolStripButton();
            this.toolStripButtonHelp = new System.Windows.Forms.ToolStripButton();
            this.menuStripMain.SuspendLayout();
            this.toolStripMain.SuspendLayout();
            this.tabControlMain.SuspendLayout();
            this.tabPageDBStruct.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.splitContainerDBStruct)).BeginInit();
            this.splitContainerDBStruct.Panel1.SuspendLayout();
            this.splitContainerDBStruct.Panel2.SuspendLayout();
            this.splitContainerDBStruct.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewDBStruct)).BeginInit();
            this.contextMenuStripDBStruct.SuspendLayout();
            this.tableLayoutPanelDBStructButton.SuspendLayout();
            this.tabPageDTStruct.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.splitContainerDTStruct)).BeginInit();
            this.splitContainerDTStruct.Panel1.SuspendLayout();
            this.splitContainerDTStruct.Panel2.SuspendLayout();
            this.splitContainerDTStruct.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewDTStruct)).BeginInit();
            this.tableLayoutPanelDTStructButton.SuspendLayout();
            this.SuspendLayout();
            // 
            // menuStripMain
            // 
            this.menuStripMain.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.menuStripMain.AutoSize = false;
            this.menuStripMain.BackColor = System.Drawing.SystemColors.ControlLight;
            this.menuStripMain.Dock = System.Windows.Forms.DockStyle.None;
            this.menuStripMain.GripMargin = new System.Windows.Forms.Padding(2, 2, 0, 28);
            this.menuStripMain.ImageScalingSize = new System.Drawing.Size(24, 24);
            this.menuStripMain.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.文件ToolStripMenuItem,
            this.编辑ToolStripMenuItem,
            this.帮助ToolStripMenuItem});
            this.menuStripMain.Location = new System.Drawing.Point(-2, -1);
            this.menuStripMain.Name = "menuStripMain";
            this.menuStripMain.Size = new System.Drawing.Size(980, 32);
            this.menuStripMain.TabIndex = 0;
            this.menuStripMain.Text = "menuStrip1";
            // 
            // 文件ToolStripMenuItem
            // 
            this.文件ToolStripMenuItem.BackColor = System.Drawing.SystemColors.ControlLight;
            this.文件ToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.打开数据库ToolStripMenuItem,
            this.关闭数据库ToolStripMenuItem,
            this.退出ToolStripMenuItem});
            this.文件ToolStripMenuItem.Name = "文件ToolStripMenuItem";
            this.文件ToolStripMenuItem.Size = new System.Drawing.Size(62, 28);
            this.文件ToolStripMenuItem.Text = "文件";
            // 
            // 打开数据库ToolStripMenuItem
            // 
            this.打开数据库ToolStripMenuItem.Name = "打开数据库ToolStripMenuItem";
            this.打开数据库ToolStripMenuItem.Size = new System.Drawing.Size(200, 34);
            this.打开数据库ToolStripMenuItem.Text = "打开数据库";
            this.打开数据库ToolStripMenuItem.Click += new System.EventHandler(this.打开数据库ToolStripMenuItem_Click);
            // 
            // 关闭数据库ToolStripMenuItem
            // 
            this.关闭数据库ToolStripMenuItem.Name = "关闭数据库ToolStripMenuItem";
            this.关闭数据库ToolStripMenuItem.Size = new System.Drawing.Size(200, 34);
            this.关闭数据库ToolStripMenuItem.Text = "关闭数据库";
            this.关闭数据库ToolStripMenuItem.Click += new System.EventHandler(this.关闭数据库ToolStripMenuItem_Click);
            // 
            // 退出ToolStripMenuItem
            // 
            this.退出ToolStripMenuItem.Name = "退出ToolStripMenuItem";
            this.退出ToolStripMenuItem.Size = new System.Drawing.Size(200, 34);
            this.退出ToolStripMenuItem.Text = "退出";
            this.退出ToolStripMenuItem.Click += new System.EventHandler(this.退出ToolStripMenuItem_Click);
            // 
            // 编辑ToolStripMenuItem
            // 
            this.编辑ToolStripMenuItem.BackColor = System.Drawing.SystemColors.ControlLight;
            this.编辑ToolStripMenuItem.Name = "编辑ToolStripMenuItem";
            this.编辑ToolStripMenuItem.Size = new System.Drawing.Size(62, 28);
            this.编辑ToolStripMenuItem.Text = "编辑";
            // 
            // 帮助ToolStripMenuItem
            // 
            this.帮助ToolStripMenuItem.BackColor = System.Drawing.SystemColors.ControlLight;
            this.帮助ToolStripMenuItem.Name = "帮助ToolStripMenuItem";
            this.帮助ToolStripMenuItem.Size = new System.Drawing.Size(62, 28);
            this.帮助ToolStripMenuItem.Text = "帮助";
            this.帮助ToolStripMenuItem.Click += new System.EventHandler(this.帮助ToolStripMenuItem_Click);
            // 
            // toolStripMain
            // 
            this.toolStripMain.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.toolStripMain.AutoSize = false;
            this.toolStripMain.Dock = System.Windows.Forms.DockStyle.None;
            this.toolStripMain.ImageScalingSize = new System.Drawing.Size(24, 24);
            this.toolStripMain.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.toolStripButtonConnectSetting,
            this.toolStripButtonAutoConnect,
            this.toolStripButtonCloseDB,
            this.toolStripButtonHelp});
            this.toolStripMain.Location = new System.Drawing.Point(-2, 31);
            this.toolStripMain.Name = "toolStripMain";
            this.toolStripMain.Size = new System.Drawing.Size(980, 40);
            this.toolStripMain.TabIndex = 1;
            this.toolStripMain.Text = "toolStrip1";
            // 
            // tabControlMain
            // 
            this.tabControlMain.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.tabControlMain.Controls.Add(this.tabPageDBStruct);
            this.tabControlMain.Controls.Add(this.tabPageDTStruct);
            this.tabControlMain.Location = new System.Drawing.Point(-2, 76);
            this.tabControlMain.Name = "tabControlMain";
            this.tabControlMain.SelectedIndex = 0;
            this.tabControlMain.Size = new System.Drawing.Size(980, 470);
            this.tabControlMain.TabIndex = 2;
            // 
            // tabPageDBStruct
            // 
            this.tabPageDBStruct.Controls.Add(this.splitContainerDBStruct);
            this.tabPageDBStruct.Location = new System.Drawing.Point(4, 28);
            this.tabPageDBStruct.Name = "tabPageDBStruct";
            this.tabPageDBStruct.Padding = new System.Windows.Forms.Padding(3);
            this.tabPageDBStruct.Size = new System.Drawing.Size(972, 438);
            this.tabPageDBStruct.TabIndex = 0;
            this.tabPageDBStruct.Text = "数据库结构";
            this.tabPageDBStruct.UseVisualStyleBackColor = true;
            // 
            // splitContainerDBStruct
            // 
            this.splitContainerDBStruct.Dock = System.Windows.Forms.DockStyle.Fill;
            this.splitContainerDBStruct.FixedPanel = System.Windows.Forms.FixedPanel.Panel2;
            this.splitContainerDBStruct.Location = new System.Drawing.Point(3, 3);
            this.splitContainerDBStruct.Name = "splitContainerDBStruct";
            this.splitContainerDBStruct.Orientation = System.Windows.Forms.Orientation.Horizontal;
            // 
            // splitContainerDBStruct.Panel1
            // 
            this.splitContainerDBStruct.Panel1.AutoScroll = true;
            this.splitContainerDBStruct.Panel1.Controls.Add(this.dataGridViewDBStruct);
            // 
            // splitContainerDBStruct.Panel2
            // 
            this.splitContainerDBStruct.Panel2.AutoScroll = true;
            this.splitContainerDBStruct.Panel2.Controls.Add(this.tableLayoutPanelDBStructButton);
            this.splitContainerDBStruct.Size = new System.Drawing.Size(966, 432);
            this.splitContainerDBStruct.SplitterDistance = 370;
            this.splitContainerDBStruct.TabIndex = 1;
            // 
            // dataGridViewDBStruct
            // 
            this.dataGridViewDBStruct.AllowUserToAddRows = false;
            dataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            this.dataGridViewDBStruct.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle3;
            this.dataGridViewDBStruct.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.AllCells;
            this.dataGridViewDBStruct.AutoSizeRowsMode = System.Windows.Forms.DataGridViewAutoSizeRowsMode.DisplayedCells;
            dataGridViewCellStyle4.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle4.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle4.Font = new System.Drawing.Font("宋体", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            dataGridViewCellStyle4.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle4.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle4.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle4.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dataGridViewDBStruct.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle4;
            this.dataGridViewDBStruct.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridViewDBStruct.ContextMenuStrip = this.contextMenuStripDBStruct;
            dataGridViewCellStyle5.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle5.BackColor = System.Drawing.SystemColors.Window;
            dataGridViewCellStyle5.Font = new System.Drawing.Font("宋体", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            dataGridViewCellStyle5.ForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle5.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle5.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle5.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dataGridViewDBStruct.DefaultCellStyle = dataGridViewCellStyle5;
            this.dataGridViewDBStruct.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dataGridViewDBStruct.Location = new System.Drawing.Point(0, 0);
            this.dataGridViewDBStruct.Name = "dataGridViewDBStruct";
            this.dataGridViewDBStruct.ReadOnly = true;
            dataGridViewCellStyle13.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle13.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle13.Font = new System.Drawing.Font("宋体", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            dataGridViewCellStyle13.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle13.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle13.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle13.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dataGridViewDBStruct.RowHeadersDefaultCellStyle = dataGridViewCellStyle13;
            this.dataGridViewDBStruct.RowHeadersWidth = 62;
            dataGridViewCellStyle14.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            this.dataGridViewDBStruct.RowsDefaultCellStyle = dataGridViewCellStyle14;
            this.dataGridViewDBStruct.RowTemplate.DefaultCellStyle.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            this.dataGridViewDBStruct.RowTemplate.Height = 30;
            this.dataGridViewDBStruct.Size = new System.Drawing.Size(966, 370);
            this.dataGridViewDBStruct.TabIndex = 0;
            // 
            // contextMenuStripDBStruct
            // 
            this.contextMenuStripDBStruct.ImageScalingSize = new System.Drawing.Size(24, 24);
            this.contextMenuStripDBStruct.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.查看表ToolStripMenuItem});
            this.contextMenuStripDBStruct.Name = "contextMenuStripDBStruct";
            this.contextMenuStripDBStruct.Size = new System.Drawing.Size(135, 34);
            // 
            // 查看表ToolStripMenuItem
            // 
            this.查看表ToolStripMenuItem.Name = "查看表ToolStripMenuItem";
            this.查看表ToolStripMenuItem.Size = new System.Drawing.Size(134, 30);
            this.查看表ToolStripMenuItem.Text = "查看表";
            this.查看表ToolStripMenuItem.Click += new System.EventHandler(this.查看表ToolStripMenuItem_Click);
            // 
            // tableLayoutPanelDBStructButton
            // 
            this.tableLayoutPanelDBStructButton.ColumnCount = 5;
            this.tableLayoutPanelDBStructButton.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 20F));
            this.tableLayoutPanelDBStructButton.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 20F));
            this.tableLayoutPanelDBStructButton.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 20F));
            this.tableLayoutPanelDBStructButton.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 20F));
            this.tableLayoutPanelDBStructButton.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 20F));
            this.tableLayoutPanelDBStructButton.Controls.Add(this.buttonAddTable, 1, 1);
            this.tableLayoutPanelDBStructButton.Controls.Add(this.buttonDeleteTable, 3, 1);
            this.tableLayoutPanelDBStructButton.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayoutPanelDBStructButton.Location = new System.Drawing.Point(0, 0);
            this.tableLayoutPanelDBStructButton.Name = "tableLayoutPanelDBStructButton";
            this.tableLayoutPanelDBStructButton.RowCount = 3;
            this.tableLayoutPanelDBStructButton.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 25F));
            this.tableLayoutPanelDBStructButton.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 60F));
            this.tableLayoutPanelDBStructButton.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 15F));
            this.tableLayoutPanelDBStructButton.Size = new System.Drawing.Size(966, 58);
            this.tableLayoutPanelDBStructButton.TabIndex = 0;
            // 
            // buttonAddTable
            // 
            this.buttonAddTable.Location = new System.Drawing.Point(196, 17);
            this.buttonAddTable.Name = "buttonAddTable";
            this.buttonAddTable.Size = new System.Drawing.Size(100, 28);
            this.buttonAddTable.TabIndex = 0;
            this.buttonAddTable.Text = "添加表";
            this.buttonAddTable.UseVisualStyleBackColor = true;
            this.buttonAddTable.Click += new System.EventHandler(this.buttonAddTable_Click);
            // 
            // buttonDeleteTable
            // 
            this.buttonDeleteTable.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.buttonDeleteTable.Location = new System.Drawing.Point(669, 17);
            this.buttonDeleteTable.Name = "buttonDeleteTable";
            this.buttonDeleteTable.Size = new System.Drawing.Size(100, 28);
            this.buttonDeleteTable.TabIndex = 1;
            this.buttonDeleteTable.Text = "删除表";
            this.buttonDeleteTable.UseVisualStyleBackColor = true;
            this.buttonDeleteTable.Click += new System.EventHandler(this.buttonDeleteTable_Click);
            // 
            // tabPageDTStruct
            // 
            this.tabPageDTStruct.Controls.Add(this.splitContainerDTStruct);
            this.tabPageDTStruct.Location = new System.Drawing.Point(4, 28);
            this.tabPageDTStruct.Name = "tabPageDTStruct";
            this.tabPageDTStruct.Padding = new System.Windows.Forms.Padding(3);
            this.tabPageDTStruct.Size = new System.Drawing.Size(972, 438);
            this.tabPageDTStruct.TabIndex = 1;
            this.tabPageDTStruct.Text = "数据表结构";
            this.tabPageDTStruct.UseVisualStyleBackColor = true;
            // 
            // splitContainerDTStruct
            // 
            this.splitContainerDTStruct.Dock = System.Windows.Forms.DockStyle.Fill;
            this.splitContainerDTStruct.Location = new System.Drawing.Point(3, 3);
            this.splitContainerDTStruct.Name = "splitContainerDTStruct";
            this.splitContainerDTStruct.Orientation = System.Windows.Forms.Orientation.Horizontal;
            // 
            // splitContainerDTStruct.Panel1
            // 
            this.splitContainerDTStruct.Panel1.Controls.Add(this.dataGridViewDTStruct);
            // 
            // splitContainerDTStruct.Panel2
            // 
            this.splitContainerDTStruct.Panel2.Controls.Add(this.tableLayoutPanelDTStructButton);
            this.splitContainerDTStruct.Size = new System.Drawing.Size(966, 432);
            this.splitContainerDTStruct.SplitterDistance = 370;
            this.splitContainerDTStruct.TabIndex = 0;
            // 
            // dataGridViewDTStruct
            // 
            this.dataGridViewDTStruct.AllowUserToAddRows = false;
            this.dataGridViewDTStruct.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.AllCells;
            this.dataGridViewDTStruct.AutoSizeRowsMode = System.Windows.Forms.DataGridViewAutoSizeRowsMode.DisplayedCells;
            dataGridViewCellStyle8.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle8.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle8.Font = new System.Drawing.Font("宋体", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            dataGridViewCellStyle8.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle8.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle8.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle8.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dataGridViewDTStruct.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle8;
            this.dataGridViewDTStruct.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridViewCellStyle9.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle9.BackColor = System.Drawing.SystemColors.Window;
            dataGridViewCellStyle9.Font = new System.Drawing.Font("宋体", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            dataGridViewCellStyle9.ForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle9.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle9.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle9.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dataGridViewDTStruct.DefaultCellStyle = dataGridViewCellStyle9;
            this.dataGridViewDTStruct.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dataGridViewDTStruct.Location = new System.Drawing.Point(0, 0);
            this.dataGridViewDTStruct.Name = "dataGridViewDTStruct";
            this.dataGridViewDTStruct.ReadOnly = true;
            this.dataGridViewDTStruct.RowHeadersWidth = 62;
            this.dataGridViewDTStruct.RowTemplate.Height = 30;
            this.dataGridViewDTStruct.Size = new System.Drawing.Size(966, 370);
            this.dataGridViewDTStruct.TabIndex = 0;
            // 
            // tableLayoutPanelDTStructButton
            // 
            this.tableLayoutPanelDTStructButton.ColumnCount = 5;
            this.tableLayoutPanelDTStructButton.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 20F));
            this.tableLayoutPanelDTStructButton.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 20F));
            this.tableLayoutPanelDTStructButton.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 20F));
            this.tableLayoutPanelDTStructButton.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 20F));
            this.tableLayoutPanelDTStructButton.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 20F));
            this.tableLayoutPanelDTStructButton.Controls.Add(this.buttonEditTable, 1, 1);
            this.tableLayoutPanelDTStructButton.Controls.Add(this.buttonFlush, 3, 1);
            this.tableLayoutPanelDTStructButton.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayoutPanelDTStructButton.Location = new System.Drawing.Point(0, 0);
            this.tableLayoutPanelDTStructButton.Name = "tableLayoutPanelDTStructButton";
            this.tableLayoutPanelDTStructButton.RowCount = 3;
            this.tableLayoutPanelDTStructButton.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 25F));
            this.tableLayoutPanelDTStructButton.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 60F));
            this.tableLayoutPanelDTStructButton.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 15F));
            this.tableLayoutPanelDTStructButton.Size = new System.Drawing.Size(966, 58);
            this.tableLayoutPanelDTStructButton.TabIndex = 1;
            // 
            // buttonEditTable
            // 
            this.buttonEditTable.Location = new System.Drawing.Point(196, 17);
            this.buttonEditTable.Name = "buttonEditTable";
            this.buttonEditTable.Size = new System.Drawing.Size(100, 28);
            this.buttonEditTable.TabIndex = 0;
            this.buttonEditTable.Text = "编辑表";
            this.buttonEditTable.UseVisualStyleBackColor = true;
            this.buttonEditTable.Click += new System.EventHandler(this.buttonEditTable_Click);
            // 
            // buttonFlush
            // 
            this.buttonFlush.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.buttonFlush.Location = new System.Drawing.Point(669, 17);
            this.buttonFlush.Name = "buttonFlush";
            this.buttonFlush.Size = new System.Drawing.Size(100, 28);
            this.buttonFlush.TabIndex = 1;
            this.buttonFlush.Text = "刷新表";
            this.buttonFlush.UseVisualStyleBackColor = true;
            this.buttonFlush.Click += new System.EventHandler(this.buttonFlush_Click);
            // 
            // toolStripButtonConnectSetting
            // 
            this.toolStripButtonConnectSetting.Image = global::DataInfoMangement.Properties.Resources.SysSettings;
            this.toolStripButtonConnectSetting.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.toolStripButtonConnectSetting.Margin = new System.Windows.Forms.Padding(3);
            this.toolStripButtonConnectSetting.Name = "toolStripButtonConnectSetting";
            this.toolStripButtonConnectSetting.Size = new System.Drawing.Size(34, 34);
            this.toolStripButtonConnectSetting.Click += new System.EventHandler(this.toolStripButtonConnectSetting_Click);
            // 
            // toolStripButtonAutoConnect
            // 
            this.toolStripButtonAutoConnect.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.toolStripButtonAutoConnect.Image = global::DataInfoMangement.Properties.Resources.Clean;
            this.toolStripButtonAutoConnect.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.toolStripButtonAutoConnect.Margin = new System.Windows.Forms.Padding(3);
            this.toolStripButtonAutoConnect.Name = "toolStripButtonAutoConnect";
            this.toolStripButtonAutoConnect.Size = new System.Drawing.Size(34, 34);
            this.toolStripButtonAutoConnect.Text = "toolStripButton1";
            this.toolStripButtonAutoConnect.Click += new System.EventHandler(this.toolStripButtonAutoConnect_Click);
            // 
            // toolStripButtonCloseDB
            // 
            this.toolStripButtonCloseDB.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.toolStripButtonCloseDB.Image = global::DataInfoMangement.Properties.Resources.Stop;
            this.toolStripButtonCloseDB.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.toolStripButtonCloseDB.Margin = new System.Windows.Forms.Padding(3);
            this.toolStripButtonCloseDB.Name = "toolStripButtonCloseDB";
            this.toolStripButtonCloseDB.Size = new System.Drawing.Size(34, 34);
            this.toolStripButtonCloseDB.Text = "toolStripButton3";
            this.toolStripButtonCloseDB.Click += new System.EventHandler(this.toolStripButtonCloseDB_Click);
            // 
            // toolStripButtonHelp
            // 
            this.toolStripButtonHelp.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.toolStripButtonHelp.Image = global::DataInfoMangement.Properties.Resources.Help;
            this.toolStripButtonHelp.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.toolStripButtonHelp.Margin = new System.Windows.Forms.Padding(3);
            this.toolStripButtonHelp.Name = "toolStripButtonHelp";
            this.toolStripButtonHelp.Size = new System.Drawing.Size(34, 34);
            this.toolStripButtonHelp.Text = "toolStripButton2";
            this.toolStripButtonHelp.Click += new System.EventHandler(this.toolStripButtonHelp_Click);
            // 
            // MainForm
            // 
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.None;
            this.BackColor = System.Drawing.SystemColors.Control;
            this.ClientSize = new System.Drawing.Size(978, 544);
            this.Controls.Add(this.tabControlMain);
            this.Controls.Add(this.toolStripMain);
            this.Controls.Add(this.menuStripMain);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MainMenuStrip = this.menuStripMain;
            this.Name = "MainForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "元数据管理器";
            this.menuStripMain.ResumeLayout(false);
            this.menuStripMain.PerformLayout();
            this.toolStripMain.ResumeLayout(false);
            this.toolStripMain.PerformLayout();
            this.tabControlMain.ResumeLayout(false);
            this.tabPageDBStruct.ResumeLayout(false);
            this.splitContainerDBStruct.Panel1.ResumeLayout(false);
            this.splitContainerDBStruct.Panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.splitContainerDBStruct)).EndInit();
            this.splitContainerDBStruct.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewDBStruct)).EndInit();
            this.contextMenuStripDBStruct.ResumeLayout(false);
            this.tableLayoutPanelDBStructButton.ResumeLayout(false);
            this.tabPageDTStruct.ResumeLayout(false);
            this.splitContainerDTStruct.Panel1.ResumeLayout(false);
            this.splitContainerDTStruct.Panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.splitContainerDTStruct)).EndInit();
            this.splitContainerDTStruct.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewDTStruct)).EndInit();
            this.tableLayoutPanelDTStructButton.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.MenuStrip menuStripMain;
        private System.Windows.Forms.ToolStripMenuItem 文件ToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem 打开数据库ToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem 关闭数据库ToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem 退出ToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem 编辑ToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem 帮助ToolStripMenuItem;
        private System.Windows.Forms.ToolStrip toolStripMain;
        private System.Windows.Forms.ToolStripButton toolStripButtonConnectSetting;
        private System.Windows.Forms.TabControl tabControlMain;
        private System.Windows.Forms.TabPage tabPageDBStruct;
        private System.Windows.Forms.TabPage tabPageDTStruct;
        private System.Windows.Forms.DataGridView dataGridViewDBStruct;
        private System.Windows.Forms.SplitContainer splitContainerDBStruct;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanelDBStructButton;
        private System.Windows.Forms.Button buttonAddTable;
        private System.Windows.Forms.Button buttonDeleteTable;
        private System.Windows.Forms.ContextMenuStrip contextMenuStripDBStruct;
        private System.Windows.Forms.ToolStripMenuItem 查看表ToolStripMenuItem;
        private System.Windows.Forms.SplitContainer splitContainerDTStruct;
        private System.Windows.Forms.DataGridView dataGridViewDTStruct;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanelDTStructButton;
        private System.Windows.Forms.Button buttonEditTable;
        private System.Windows.Forms.Button buttonFlush;
        private System.Windows.Forms.ToolStripButton toolStripButtonHelp;
        private System.Windows.Forms.ToolStripButton toolStripButtonCloseDB;
        private System.Windows.Forms.ToolStripButton toolStripButtonAutoConnect;
    }
}

