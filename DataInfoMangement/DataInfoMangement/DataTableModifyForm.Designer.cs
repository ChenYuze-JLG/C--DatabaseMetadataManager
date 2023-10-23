
namespace DataInfoMangement
{
    partial class DataTableModifyForm
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle3 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle4 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle5 = new System.Windows.Forms.DataGridViewCellStyle();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(DataTableModifyForm));
            this.groupBoxTableName = new System.Windows.Forms.GroupBox();
            this.textBoxTableName = new System.Windows.Forms.TextBox();
            this.tabControl1 = new System.Windows.Forms.TabControl();
            this.tabPageWords = new System.Windows.Forms.TabPage();
            this.splitContainerWords = new System.Windows.Forms.SplitContainer();
            this.flowLayoutPanelWordsButton = new System.Windows.Forms.FlowLayoutPanel();
            this.buttonAddWord = new System.Windows.Forms.Button();
            this.buttonDeleteWord = new System.Windows.Forms.Button();
            this.dataGridViewWords = new System.Windows.Forms.DataGridView();
            this.tabPageConstraint = new System.Windows.Forms.TabPage();
            this.splitContainerConstraint = new System.Windows.Forms.SplitContainer();
            this.flowLayoutPanelConstraintButton = new System.Windows.Forms.FlowLayoutPanel();
            this.buttonAddFK = new System.Windows.Forms.Button();
            this.buttonDeleteFK = new System.Windows.Forms.Button();
            this.dataGridViewConstraint = new System.Windows.Forms.DataGridView();
            this.splitContainerMain = new System.Windows.Forms.SplitContainer();
            this.richTextBoxCode = new System.Windows.Forms.RichTextBox();
            this.flowLayoutPanelGlobalButton = new System.Windows.Forms.FlowLayoutPanel();
            this.buttonCancel = new System.Windows.Forms.Button();
            this.buttonOK = new System.Windows.Forms.Button();
            this.groupBoxTableName.SuspendLayout();
            this.tabControl1.SuspendLayout();
            this.tabPageWords.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.splitContainerWords)).BeginInit();
            this.splitContainerWords.Panel1.SuspendLayout();
            this.splitContainerWords.Panel2.SuspendLayout();
            this.splitContainerWords.SuspendLayout();
            this.flowLayoutPanelWordsButton.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewWords)).BeginInit();
            this.tabPageConstraint.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.splitContainerConstraint)).BeginInit();
            this.splitContainerConstraint.Panel1.SuspendLayout();
            this.splitContainerConstraint.Panel2.SuspendLayout();
            this.splitContainerConstraint.SuspendLayout();
            this.flowLayoutPanelConstraintButton.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewConstraint)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.splitContainerMain)).BeginInit();
            this.splitContainerMain.Panel1.SuspendLayout();
            this.splitContainerMain.Panel2.SuspendLayout();
            this.splitContainerMain.SuspendLayout();
            this.flowLayoutPanelGlobalButton.SuspendLayout();
            this.SuspendLayout();
            // 
            // groupBoxTableName
            // 
            this.groupBoxTableName.Controls.Add(this.textBoxTableName);
            this.groupBoxTableName.Dock = System.Windows.Forms.DockStyle.Top;
            this.groupBoxTableName.Location = new System.Drawing.Point(0, 0);
            this.groupBoxTableName.Name = "groupBoxTableName";
            this.groupBoxTableName.Size = new System.Drawing.Size(378, 74);
            this.groupBoxTableName.TabIndex = 0;
            this.groupBoxTableName.TabStop = false;
            this.groupBoxTableName.Text = "数据表";
            // 
            // textBoxTableName
            // 
            this.textBoxTableName.Dock = System.Windows.Forms.DockStyle.Fill;
            this.textBoxTableName.Location = new System.Drawing.Point(3, 24);
            this.textBoxTableName.Name = "textBoxTableName";
            this.textBoxTableName.Size = new System.Drawing.Size(372, 28);
            this.textBoxTableName.TabIndex = 0;
            // 
            // tabControl1
            // 
            this.tabControl1.Controls.Add(this.tabPageWords);
            this.tabControl1.Controls.Add(this.tabPageConstraint);
            this.tabControl1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tabControl1.Location = new System.Drawing.Point(0, 0);
            this.tabControl1.Name = "tabControl1";
            this.tabControl1.SelectedIndex = 0;
            this.tabControl1.Size = new System.Drawing.Size(378, 266);
            this.tabControl1.TabIndex = 1;
            // 
            // tabPageWords
            // 
            this.tabPageWords.Controls.Add(this.splitContainerWords);
            this.tabPageWords.Location = new System.Drawing.Point(4, 28);
            this.tabPageWords.Name = "tabPageWords";
            this.tabPageWords.Padding = new System.Windows.Forms.Padding(3);
            this.tabPageWords.Size = new System.Drawing.Size(370, 234);
            this.tabPageWords.TabIndex = 0;
            this.tabPageWords.Text = "字段";
            this.tabPageWords.UseVisualStyleBackColor = true;
            // 
            // splitContainerWords
            // 
            this.splitContainerWords.Dock = System.Windows.Forms.DockStyle.Fill;
            this.splitContainerWords.FixedPanel = System.Windows.Forms.FixedPanel.Panel1;
            this.splitContainerWords.Location = new System.Drawing.Point(3, 3);
            this.splitContainerWords.Name = "splitContainerWords";
            this.splitContainerWords.Orientation = System.Windows.Forms.Orientation.Horizontal;
            // 
            // splitContainerWords.Panel1
            // 
            this.splitContainerWords.Panel1.Controls.Add(this.flowLayoutPanelWordsButton);
            // 
            // splitContainerWords.Panel2
            // 
            this.splitContainerWords.Panel2.Controls.Add(this.dataGridViewWords);
            this.splitContainerWords.Size = new System.Drawing.Size(364, 228);
            this.splitContainerWords.SplitterDistance = 31;
            this.splitContainerWords.TabIndex = 0;
            // 
            // flowLayoutPanelWordsButton
            // 
            this.flowLayoutPanelWordsButton.Controls.Add(this.buttonAddWord);
            this.flowLayoutPanelWordsButton.Controls.Add(this.buttonDeleteWord);
            this.flowLayoutPanelWordsButton.Dock = System.Windows.Forms.DockStyle.Fill;
            this.flowLayoutPanelWordsButton.Location = new System.Drawing.Point(0, 0);
            this.flowLayoutPanelWordsButton.Name = "flowLayoutPanelWordsButton";
            this.flowLayoutPanelWordsButton.Size = new System.Drawing.Size(364, 31);
            this.flowLayoutPanelWordsButton.TabIndex = 0;
            // 
            // buttonAddWord
            // 
            this.buttonAddWord.AutoSize = true;
            this.buttonAddWord.BackColor = System.Drawing.Color.Transparent;
            this.buttonAddWord.Location = new System.Drawing.Point(3, 3);
            this.buttonAddWord.Name = "buttonAddWord";
            this.buttonAddWord.Size = new System.Drawing.Size(90, 28);
            this.buttonAddWord.TabIndex = 0;
            this.buttonAddWord.Text = "添加字段";
            this.buttonAddWord.UseVisualStyleBackColor = false;
            this.buttonAddWord.Click += new System.EventHandler(this.buttonAddWord_Click);
            // 
            // buttonDeleteWord
            // 
            this.buttonDeleteWord.AutoSize = true;
            this.buttonDeleteWord.BackColor = System.Drawing.Color.Transparent;
            this.buttonDeleteWord.Location = new System.Drawing.Point(99, 3);
            this.buttonDeleteWord.Name = "buttonDeleteWord";
            this.buttonDeleteWord.Size = new System.Drawing.Size(90, 28);
            this.buttonDeleteWord.TabIndex = 1;
            this.buttonDeleteWord.Text = "删除字段";
            this.buttonDeleteWord.UseVisualStyleBackColor = false;
            this.buttonDeleteWord.Click += new System.EventHandler(this.buttonDeleteWord_Click);
            // 
            // dataGridViewWords
            // 
            this.dataGridViewWords.AllowUserToAddRows = false;
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            this.dataGridViewWords.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle1;
            this.dataGridViewWords.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dataGridViewWords.AutoSizeRowsMode = System.Windows.Forms.DataGridViewAutoSizeRowsMode.DisplayedCells;
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle2.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle2.Font = new System.Drawing.Font("宋体", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            dataGridViewCellStyle2.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dataGridViewWords.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle2;
            this.dataGridViewWords.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle3.BackColor = System.Drawing.SystemColors.Window;
            dataGridViewCellStyle3.Font = new System.Drawing.Font("宋体", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            dataGridViewCellStyle3.ForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle3.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle3.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle3.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dataGridViewWords.DefaultCellStyle = dataGridViewCellStyle3;
            this.dataGridViewWords.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dataGridViewWords.Location = new System.Drawing.Point(0, 0);
            this.dataGridViewWords.Name = "dataGridViewWords";
            this.dataGridViewWords.RowHeadersWidth = 62;
            this.dataGridViewWords.RowTemplate.Height = 30;
            this.dataGridViewWords.Size = new System.Drawing.Size(364, 193);
            this.dataGridViewWords.TabIndex = 0;
            // 
            // tabPageConstraint
            // 
            this.tabPageConstraint.Controls.Add(this.splitContainerConstraint);
            this.tabPageConstraint.Location = new System.Drawing.Point(4, 28);
            this.tabPageConstraint.Name = "tabPageConstraint";
            this.tabPageConstraint.Padding = new System.Windows.Forms.Padding(3);
            this.tabPageConstraint.Size = new System.Drawing.Size(370, 234);
            this.tabPageConstraint.TabIndex = 1;
            this.tabPageConstraint.Text = "外键约束";
            this.tabPageConstraint.UseVisualStyleBackColor = true;
            // 
            // splitContainerConstraint
            // 
            this.splitContainerConstraint.Dock = System.Windows.Forms.DockStyle.Fill;
            this.splitContainerConstraint.FixedPanel = System.Windows.Forms.FixedPanel.Panel1;
            this.splitContainerConstraint.Location = new System.Drawing.Point(3, 3);
            this.splitContainerConstraint.Name = "splitContainerConstraint";
            this.splitContainerConstraint.Orientation = System.Windows.Forms.Orientation.Horizontal;
            // 
            // splitContainerConstraint.Panel1
            // 
            this.splitContainerConstraint.Panel1.Controls.Add(this.flowLayoutPanelConstraintButton);
            // 
            // splitContainerConstraint.Panel2
            // 
            this.splitContainerConstraint.Panel2.Controls.Add(this.dataGridViewConstraint);
            this.splitContainerConstraint.Size = new System.Drawing.Size(364, 228);
            this.splitContainerConstraint.SplitterDistance = 31;
            this.splitContainerConstraint.TabIndex = 1;
            // 
            // flowLayoutPanelConstraintButton
            // 
            this.flowLayoutPanelConstraintButton.Controls.Add(this.buttonAddFK);
            this.flowLayoutPanelConstraintButton.Controls.Add(this.buttonDeleteFK);
            this.flowLayoutPanelConstraintButton.Dock = System.Windows.Forms.DockStyle.Top;
            this.flowLayoutPanelConstraintButton.Location = new System.Drawing.Point(0, 0);
            this.flowLayoutPanelConstraintButton.Name = "flowLayoutPanelConstraintButton";
            this.flowLayoutPanelConstraintButton.Size = new System.Drawing.Size(364, 31);
            this.flowLayoutPanelConstraintButton.TabIndex = 0;
            // 
            // buttonAddFK
            // 
            this.buttonAddFK.AutoSize = true;
            this.buttonAddFK.BackColor = System.Drawing.Color.Transparent;
            this.buttonAddFK.Location = new System.Drawing.Point(3, 3);
            this.buttonAddFK.Name = "buttonAddFK";
            this.buttonAddFK.Size = new System.Drawing.Size(90, 28);
            this.buttonAddFK.TabIndex = 0;
            this.buttonAddFK.Text = "添加外键";
            this.buttonAddFK.UseVisualStyleBackColor = false;
            this.buttonAddFK.Click += new System.EventHandler(this.buttonAddFK_Click);
            // 
            // buttonDeleteFK
            // 
            this.buttonDeleteFK.AutoSize = true;
            this.buttonDeleteFK.BackColor = System.Drawing.Color.Transparent;
            this.buttonDeleteFK.Location = new System.Drawing.Point(99, 3);
            this.buttonDeleteFK.Name = "buttonDeleteFK";
            this.buttonDeleteFK.Size = new System.Drawing.Size(90, 28);
            this.buttonDeleteFK.TabIndex = 1;
            this.buttonDeleteFK.Text = "删除外键";
            this.buttonDeleteFK.UseVisualStyleBackColor = false;
            this.buttonDeleteFK.Click += new System.EventHandler(this.buttonDeleteFK_Click);
            // 
            // dataGridViewConstraint
            // 
            this.dataGridViewConstraint.AllowUserToAddRows = false;
            this.dataGridViewConstraint.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dataGridViewConstraint.AutoSizeRowsMode = System.Windows.Forms.DataGridViewAutoSizeRowsMode.DisplayedCells;
            dataGridViewCellStyle4.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle4.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle4.Font = new System.Drawing.Font("宋体", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            dataGridViewCellStyle4.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle4.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle4.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle4.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dataGridViewConstraint.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle4;
            this.dataGridViewConstraint.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridViewCellStyle5.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle5.BackColor = System.Drawing.SystemColors.Window;
            dataGridViewCellStyle5.Font = new System.Drawing.Font("宋体", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            dataGridViewCellStyle5.ForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle5.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle5.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle5.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dataGridViewConstraint.DefaultCellStyle = dataGridViewCellStyle5;
            this.dataGridViewConstraint.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dataGridViewConstraint.Location = new System.Drawing.Point(0, 0);
            this.dataGridViewConstraint.Name = "dataGridViewConstraint";
            this.dataGridViewConstraint.RowHeadersWidth = 62;
            this.dataGridViewConstraint.RowTemplate.Height = 30;
            this.dataGridViewConstraint.Size = new System.Drawing.Size(364, 193);
            this.dataGridViewConstraint.TabIndex = 0;
            // 
            // splitContainerMain
            // 
            this.splitContainerMain.Dock = System.Windows.Forms.DockStyle.Fill;
            this.splitContainerMain.Location = new System.Drawing.Point(0, 74);
            this.splitContainerMain.Name = "splitContainerMain";
            this.splitContainerMain.Orientation = System.Windows.Forms.Orientation.Horizontal;
            // 
            // splitContainerMain.Panel1
            // 
            this.splitContainerMain.Panel1.Controls.Add(this.tabControl1);
            // 
            // splitContainerMain.Panel2
            // 
            this.splitContainerMain.Panel2.Controls.Add(this.richTextBoxCode);
            this.splitContainerMain.Size = new System.Drawing.Size(378, 420);
            this.splitContainerMain.SplitterDistance = 266;
            this.splitContainerMain.TabIndex = 2;
            // 
            // richTextBoxCode
            // 
            this.richTextBoxCode.Dock = System.Windows.Forms.DockStyle.Fill;
            this.richTextBoxCode.Location = new System.Drawing.Point(0, 0);
            this.richTextBoxCode.Name = "richTextBoxCode";
            this.richTextBoxCode.Size = new System.Drawing.Size(378, 150);
            this.richTextBoxCode.TabIndex = 0;
            this.richTextBoxCode.Text = "";
            // 
            // flowLayoutPanelGlobalButton
            // 
            this.flowLayoutPanelGlobalButton.Controls.Add(this.buttonCancel);
            this.flowLayoutPanelGlobalButton.Controls.Add(this.buttonOK);
            this.flowLayoutPanelGlobalButton.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.flowLayoutPanelGlobalButton.FlowDirection = System.Windows.Forms.FlowDirection.RightToLeft;
            this.flowLayoutPanelGlobalButton.Location = new System.Drawing.Point(0, 456);
            this.flowLayoutPanelGlobalButton.Name = "flowLayoutPanelGlobalButton";
            this.flowLayoutPanelGlobalButton.Size = new System.Drawing.Size(378, 38);
            this.flowLayoutPanelGlobalButton.TabIndex = 3;
            // 
            // buttonCancel
            // 
            this.buttonCancel.Location = new System.Drawing.Point(275, 3);
            this.buttonCancel.Name = "buttonCancel";
            this.buttonCancel.Size = new System.Drawing.Size(100, 30);
            this.buttonCancel.TabIndex = 0;
            this.buttonCancel.Text = "取消";
            this.buttonCancel.UseVisualStyleBackColor = true;
            this.buttonCancel.Click += new System.EventHandler(this.buttonCancel_Click);
            // 
            // buttonOK
            // 
            this.buttonOK.Location = new System.Drawing.Point(169, 3);
            this.buttonOK.Name = "buttonOK";
            this.buttonOK.Size = new System.Drawing.Size(100, 30);
            this.buttonOK.TabIndex = 1;
            this.buttonOK.Text = "确认";
            this.buttonOK.UseVisualStyleBackColor = true;
            this.buttonOK.Click += new System.EventHandler(this.buttonOK_Click);
            // 
            // DataTableModifyForm
            // 
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.None;
            this.ClientSize = new System.Drawing.Size(378, 494);
            this.Controls.Add(this.flowLayoutPanelGlobalButton);
            this.Controls.Add(this.splitContainerMain);
            this.Controls.Add(this.groupBoxTableName);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MinimumSize = new System.Drawing.Size(350, 500);
            this.Name = "DataTableModifyForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "修改数据表";
            this.Load += new System.EventHandler(this.DataTableModifyForm_Load);
            this.groupBoxTableName.ResumeLayout(false);
            this.groupBoxTableName.PerformLayout();
            this.tabControl1.ResumeLayout(false);
            this.tabPageWords.ResumeLayout(false);
            this.splitContainerWords.Panel1.ResumeLayout(false);
            this.splitContainerWords.Panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.splitContainerWords)).EndInit();
            this.splitContainerWords.ResumeLayout(false);
            this.flowLayoutPanelWordsButton.ResumeLayout(false);
            this.flowLayoutPanelWordsButton.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewWords)).EndInit();
            this.tabPageConstraint.ResumeLayout(false);
            this.splitContainerConstraint.Panel1.ResumeLayout(false);
            this.splitContainerConstraint.Panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.splitContainerConstraint)).EndInit();
            this.splitContainerConstraint.ResumeLayout(false);
            this.flowLayoutPanelConstraintButton.ResumeLayout(false);
            this.flowLayoutPanelConstraintButton.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewConstraint)).EndInit();
            this.splitContainerMain.Panel1.ResumeLayout(false);
            this.splitContainerMain.Panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.splitContainerMain)).EndInit();
            this.splitContainerMain.ResumeLayout(false);
            this.flowLayoutPanelGlobalButton.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBoxTableName;
        private System.Windows.Forms.TabControl tabControl1;
        private System.Windows.Forms.TabPage tabPageWords;
        private System.Windows.Forms.TabPage tabPageConstraint;
        private System.Windows.Forms.SplitContainer splitContainerMain;
        private System.Windows.Forms.RichTextBox richTextBoxCode;
        private System.Windows.Forms.FlowLayoutPanel flowLayoutPanelGlobalButton;
        private System.Windows.Forms.Button buttonCancel;
        private System.Windows.Forms.Button buttonOK;
        private System.Windows.Forms.TextBox textBoxTableName;
        private System.Windows.Forms.SplitContainer splitContainerWords;
        private System.Windows.Forms.FlowLayoutPanel flowLayoutPanelWordsButton;
        private System.Windows.Forms.Button buttonAddWord;
        private System.Windows.Forms.Button buttonDeleteWord;
        private System.Windows.Forms.DataGridView dataGridViewWords;
        private System.Windows.Forms.SplitContainer splitContainerConstraint;
        private System.Windows.Forms.FlowLayoutPanel flowLayoutPanelConstraintButton;
        private System.Windows.Forms.Button buttonAddFK;
        private System.Windows.Forms.Button buttonDeleteFK;
        private System.Windows.Forms.DataGridView dataGridViewConstraint;
    }
}