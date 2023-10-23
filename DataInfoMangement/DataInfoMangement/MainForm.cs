using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Windows.Forms;

namespace DataInfoMangement
{
    public partial class MainForm : Form
    {
        private string mServer = "localhost";
        private string mUser = "root";
        private string mPassword = "123456";
        private string mDataBase = "test";
        private string mConnectionStr = "server = localhost; uid = root; pwd = 123456; database = test";
        private string mTableName = "";
        private int mTableRowid;
        private MySqlConnection mConnection;
        private MySqlCommand mCommand;
        private MySqlTransaction mTransaction;
        private bool mState = false;  // false为关闭状态，true为打开状态

        public MainForm()
        {
            InitializeComponent();
        }

        private void BuildConnectStr(string server, string user, string password, string database)
        {
            this.mServer = server;
            this.mUser = user;
            this.mPassword = password;
            this.mDataBase = database;
            this.mConnectionStr = "server = " + this.mServer + "; " +
                                    "uid = " + this.mUser + "; " +
                                    "pwd = " + this.mPassword + "; " +
                                    "database = " + this.mDataBase + ";";
        }

        private bool OpenDBFile()
        {
            ConnectDBForm connectDBForm = new ConnectDBForm();
            connectDBForm.ShowDialog();
            if (connectDBForm.DialogResult == DialogResult.OK)
            {
                this.BuildConnectStr(connectDBForm.mServer, connectDBForm.mUser, connectDBForm.mPassword, connectDBForm.mDataBase);
                this.mConnection = new MySqlConnection(this.mConnectionStr);
                this.mState = true;
                return true;
            }
            else
            {
                this.mState = false;
                return false;
            }
        }

        private void CloseDBFile()
        {
            this.dataGridViewDBStruct.DataSource = null;
            this.dataGridViewDTStruct.DataSource = null;
            this.tabControlMain.SelectedTab = this.tabPageDBStruct;
            this.mState = false;
            if (this.CloseConnection())
            {
                MessageBox.Show("数据库: '" + this.mDataBase + "' 已关闭！");
            }
            else
            {
                MessageBox.Show("不存在已打开的数据库！");
            }
        }

        private bool OpenConnection()
        {
            if (!this.mState) return false;
            if(this.mConnection == null)
            {
                return false;
            }
            if(this.mConnection.State == ConnectionState.Open)
            {
                return true;
            } 
            else
            {
                bool openSucess = true;
                try
                {
                    this.mConnection.Open();
                }
                catch (Exception exception)
                {
                    MessageBox.Show("数据库连接失败: \n" + exception.ToString());
                    openSucess = false;
                }
                return openSucess;

            }
        }

        private bool CloseConnection()
        {
            if (this.mConnection == null)
            {
                return false;
            }
            if (this.mConnection.State != ConnectionState.Closed)
            {
                this.mConnection.Close();
            }
            return true;
        }

        private bool GetDBInfo()
        {
            if (!this.OpenConnection()) return false;
            // 设置查询数据库Schema相关约束条件；这里定义为三个约束字段（数据库，所有者，表名称）
            String[] restrictions = new String[3];
            // 查找TableName表内的属性名，因此前两个约束字段设置为空
            //restrictions[2] = "NewTest";
            // SqlClientMetaDataCollectionNames.Columns为数据库内所有【表集合】的【列名称集合】
            //DataTable dt = this.mConnection.GetSchema(SqlClientMetaDataCollectionNames.Columns, restrictions);
            Console.WriteLine(SqlClientMetaDataCollectionNames.Databases);

            DataTable dt = this.mConnection.GetSchema(SqlClientMetaDataCollectionNames.Tables);
            this.dataGridViewDBStruct.DataSource = dt;

            //string columnTitle = "";
            //for(int i = 0; i < dt2.Columns.Count; i++)
            //{
            //    columnTitle += dt2.Columns[i].ColumnName + " ";
            //}
            //Console.WriteLine(columnTitle);

            for (int i = 0; i < dt.Rows.Count; i++)
            {
                string outString = "";
                for (int j = 0; j < dt.Columns.Count; j++)
                {
                    outString += dt.Columns[j].ColumnName + ": " + dt.Rows[i][j].GetType() + ", " + dt.Rows[i][j] + "\n";
                }
                Console.WriteLine(outString + "\n");
            }
            this.CloseConnection();
            return true;
        }

        private bool GetDTInfo(string tableName)
        {
            if (!this.OpenConnection()) return false;
            // 设置查询数据库Schema相关约束条件；这里定义为三个约束字段（数据库，所有者，表名称）
            String[] restrictions = new String[3];
            // 查找TableName表内的属性名，因此前两个约束字段设置为空
            restrictions[2] = tableName;
            DataTable dt = this.mConnection.GetSchema(SqlClientMetaDataCollectionNames.Columns, restrictions);

            this.dataGridViewDTStruct.DataSource = dt;

            for (int i = 0; i < dt.Rows.Count; i++)
            {
                string outString = "";
                for (int j = 0; j < dt.Columns.Count; j++)
                {
                    outString += dt.Columns[j].ColumnName + ": " + dt.Rows[i][j].GetType() + ", " + dt.Rows[i][j] + "\n";
                }
                Console.WriteLine(outString + "\n");
            }
            this.CloseConnection();
            return true;
        }

        private bool ExecuteCmdTxt(string CmdTxt, bool RequireMsg = true, string CmdType = "执行")
        {
            if (!this.OpenConnection()) return false;
            bool exeSuccess = false;
            this.mCommand = this.mConnection.CreateCommand();
            // 将transaction绑定到command上，测试中不影响，此处设置为保险起见
            this.mCommand.CommandText = CmdTxt;
            this.mTransaction = this.mConnection.BeginTransaction();
            this.mCommand.Transaction = this.mTransaction;
            try
            {
                if (this.mCommand.ExecuteNonQuery() != -1)
                {
                    if (RequireMsg) MessageBox.Show("           " + CmdType + "成功!");
                    exeSuccess = true;
                }
                this.mTransaction.Commit();
            }
            catch (Exception exception)
            {
                this.mTransaction.Rollback();
                if (RequireMsg) MessageBox.Show("           " + CmdType + "失败: \n\"" + CmdTxt + "\" :\n" + exception.ToString());
            }
            finally
            {
                this.mTransaction.Dispose();
                this.mCommand.Dispose();
            }
            return exeSuccess;
        }

        private bool DropTableList(List<string> tableList)
        {
            if (!this.OpenConnection()) return false;
            bool exeSuccess = true;
            this.mCommand = this.mConnection.CreateCommand();
            this.mTransaction = this.mConnection.BeginTransaction();
            this.mCommand.Transaction = this.mTransaction;
            try
            {
                foreach(string s in tableList)
                {
                    this.mCommand.CommandText = "DROP TABLE " + s + ";";
                    this.mCommand.ExecuteNonQuery();
                }
                this.mTransaction.Commit();
            }
            catch (Exception exception)
            {
                this.mTransaction.Rollback();
                Console.WriteLine(exception.ToString());
                exeSuccess = false;
            }
            finally
            {
                this.mTransaction.Dispose();
                this.mCommand.Dispose();
            }
            return exeSuccess;
        }


        private void 打开数据库ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (this.OpenDBFile())
            {
                this.GetDBInfo();
                this.tabControlMain.SelectedTab = this.tabPageDBStruct;
                this.dataGridViewDTStruct.DataSource = null;
            }
        }

        private void 关闭数据库ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.CloseDBFile();
        }

        private void 退出ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void buttonDeleteTable_Click(object sender, EventArgs e)
        {
            if (!this.mState)
            {
                MessageBox.Show("当前未连接数据库！");
                return;
            }
            List<string> tableNameList = new List<string>();
            if(this.dataGridViewDBStruct.SelectedRows.Count > 0)
            {
                for(int i = 0; i < this.dataGridViewDBStruct.SelectedRows.Count; i++)
                {
                    if(this.dataGridViewDBStruct.SelectedRows[i].Cells[2].Value != null)
                    {
                        tableNameList.Add(this.dataGridViewDBStruct.SelectedRows[i].Cells[2].Value.ToString());
                    }
                }
            }
            else if(this.dataGridViewDBStruct.CurrentRow != null)
            {
                tableNameList.Add(this.dataGridViewDBStruct.CurrentRow.Cells[2].Value.ToString());
            }
            else
            {
                MessageBox.Show("当前未选中数据表！");
                return;
            }
            string tableNameString = "";
            foreach (string s in tableNameList)
            {
                tableNameString += s + ", ";
            }
            tableNameString = tableNameString.Substring(0, tableNameString.Length - 2);
            DialogResult dialogResult = MessageBox.Show("确认删除以下数据表：\n\n" + tableNameString, "删除确认", MessageBoxButtons.OKCancel);
            if(dialogResult == DialogResult.OK)
            {
                if (this.DropTableList(tableNameList))
                {
                    MessageBox.Show("删除成功！");
                    this.GetDBInfo();
                }
                else
                {
                    MessageBox.Show("删除失败！");
                }
            }
        }

        private void 查看表ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (this.dataGridViewDBStruct.SelectedRows.Count > 0)
            {
                MessageBox.Show("请选择一张数据表！");
                return;
            }
            else if (this.dataGridViewDBStruct.CurrentRow != null)
            {
                this.mTableName = this.dataGridViewDBStruct.CurrentRow.Cells[2].Value.ToString();
                this.mTableRowid = this.dataGridViewDBStruct.CurrentCell.RowIndex;
            }
            else
            {
                MessageBox.Show("当前未选中数据表！");
                return;
            }
            if(this.mTableName != null)
            {
                this.tabControlMain.SelectedTab = this.tabPageDTStruct;
                this.GetDTInfo(this.mTableName);
            }
            return;
        }

        private void buttonAddTable_Click(object sender, EventArgs e)
        {
            if (!this.mState)
            {
                MessageBox.Show("当前未连接数据库！");
                return;
            }
            DataTableAddForm dataTableAddForm = new DataTableAddForm(this.mServer, this.mUser, this.mPassword, this.mDataBase);
            dataTableAddForm.ShowDialog();
            this.GetDBInfo();
            if (this.dataGridViewDBStruct.Rows[this.dataGridViewDBStruct.Rows.Count - 1].Cells[2].Value != null)
            {
                this.mTableName = this.dataGridViewDBStruct.Rows[this.dataGridViewDBStruct.Rows.Count - 1].Cells[2].Value.ToString();
                this.GetDTInfo(this.mTableName);
            }
            return;
        }

        private void buttonEditTable_Click(object sender, EventArgs e)
        {
            if (!this.mState)
            {
                MessageBox.Show("当前未连接数据库！");
                return;
            }
            if (this.mTableName != "")
            {
                DataTableModifyForm dataTableModifyForm = new DataTableModifyForm(this.mServer, this.mUser, this.mPassword, this.mDataBase, this.mTableName);
                dataTableModifyForm.ShowDialog();
                while (true)
                {
                    if (dataTableModifyForm.DialogResult == DialogResult.Cancel)
                    {
                        this.GetDBInfo();
                        if(this.dataGridViewDBStruct.Rows[this.mTableRowid].Cells[2].Value != null)
                        {
                            this.mTableName = this.dataGridViewDBStruct.Rows[this.mTableRowid].Cells[2].Value.ToString();
                            this.GetDTInfo(this.mTableName);
                        }
                        break;
                    }
                    else if(dataTableModifyForm.DialogResult != DialogResult.OK)
                    {
                        break;
                    }
                }
            }
            else
            {
                MessageBox.Show("当前未打开数据表！");
            }
            return;
        }

        private void buttonFlush_Click(object sender, EventArgs e)
        {
            if (!this.mState)
            {
                MessageBox.Show("当前未连接数据库！");
                return;
            }
            this.GetDBInfo();
        }

        private void toolStripButtonCloseDB_Click(object sender, EventArgs e)
        {
            this.CloseDBFile();
        }

        private void toolStripButtonHelp_Click(object sender, EventArgs e)
        {
            HelpForm helpForm = new HelpForm();
            helpForm.ShowDialog();
        }

        private void toolStripButtonAutoConnect_Click(object sender, EventArgs e)
        {
            this.BuildConnectStr("localhost", "root", "123456", "test");
            this.mConnection = new MySqlConnection(this.mConnectionStr);
            this.mState = true;
            this.GetDBInfo();
            this.tabControlMain.SelectedTab = this.tabPageDBStruct;
            this.dataGridViewDTStruct.DataSource = null;
        }

        private void toolStripButtonConnectSetting_Click(object sender, EventArgs e)
        {
            if (this.OpenDBFile())
            {
                this.GetDBInfo();
                this.tabControlMain.SelectedTab = this.tabPageDBStruct;
                this.dataGridViewDTStruct.DataSource = null;
            }
        }

        private void 帮助ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            HelpForm helpForm = new HelpForm();
            helpForm.ShowDialog();
        }
    }
}
