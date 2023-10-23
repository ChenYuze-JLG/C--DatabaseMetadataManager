using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.Data;
using System.Windows.Forms;

namespace DataInfoMangement
{
    public partial class DataTableModifyForm : Form
    {
        private string mDataBase = "";
        private string mTableName = "";
        private DataTable mDTCStandard;
        private DataTable mDTFKStandard;
        private DataTable mDTCModfied;
        private DataTable mDTFKModfied;
        private MySqlConnection mConnection;
        private MySqlCommand mCommand;

        public DataTableModifyForm(string server, string user, string password, string database, string tableName)
        {
            this.mDataBase = "test";
            this.mTableName = tableName;
            this.mConnection = new MySqlConnection("server = " + server + "; " +
                                                    "user = " + user + "; " +
                                                    "password = " + password + "; "
                                                    + "database = " + database + ";");
            InitializeComponent();
        }

        private void DataTableModifyForm_Load(object sender, EventArgs e)
        {
            this.textBoxTableName.Text = this.mTableName;
            this.GetTableWordInfo();
        }

        private bool OpenConnection()
        {
            if (this.mConnection == null)
            {
                return false;
            }
            if (this.mConnection.State == ConnectionState.Open)
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

        private bool GetTableWordInfo()
        {
            if (!this.OpenConnection()) return false;

            // 读取建表代码
            DataTable dtCode;
            this.mCommand = this.mConnection.CreateCommand();
            this.mCommand.CommandText = "SHOW CREATE TABLE " + this.mTableName + ";";
            using (MySqlDataAdapter adapter = new MySqlDataAdapter(this.mCommand))
            {
                dtCode = new DataTable();
                adapter.Fill(dtCode);
            }
            this.richTextBoxCode.Text = dtCode.Rows[0][1].ToString();

            // 读取表字段信息
            DataTable dtColumns;
            this.mCommand = this.mConnection.CreateCommand();
            this.mCommand.CommandText = "DESC " + this.mTableName + ";";
            using (MySqlDataAdapter adapter = new MySqlDataAdapter(this.mCommand))
            {
                dtColumns = new DataTable();
                adapter.Fill(dtColumns);
            }
            DataTable dtC = dtColumns.Copy();
            List<string> columnNameListC = new List<string>();
            columnNameListC.Add("Field");
            columnNameListC.Add("Type");
            columnNameListC.Add("Null");
            columnNameListC.Add("Key");
            columnNameListC.Add("Extra");
            for (int i = 0; i < dtC.Columns.Count; i++)
            {
                bool isExsist = columnNameListC.Contains(dtC.Columns[i].ColumnName);
                if (!isExsist)
                {
                    dtC.Columns.Remove(dtC.Columns[i]);
                    i--;
                }
            }

            // 读取表外键信息
            // 设置查询数据库Schema相关约束条件；这里定义为三个约束字段（数据库，所有者，表名称）
            String[] restrictions = new String[3];
            // 查找TableName表内的属性名，因此前两个约束字段设置为空
            restrictions[2] = this.mTableName;
            DataTable dtForeignKeys = this.mConnection.GetSchema("Foreign Key Columns", restrictions);
            DataTable dtFK = dtForeignKeys.Copy();
            List<string> columnNameListFK = new List<string>();
            columnNameListFK.Add("CONSTRAINT_NAME");
            columnNameListFK.Add("TABLE_NAME");
            columnNameListFK.Add("COLUMN_NAME");
            columnNameListFK.Add("REFERENCED_TABLE_NAME");
            columnNameListFK.Add("REFERENCED_COLUMN_NAME");
            for (int i = 0; i < dtFK.Columns.Count; i++)
            {
                bool isExsist = columnNameListFK.Contains(dtFK.Columns[i].ColumnName);
                if (!isExsist)
                {
                    dtFK.Columns.Remove(dtFK.Columns[i]);
                    i--;
                }
            }
            this.mDTCStandard = dtC.Copy();
            this.mDTCModfied = dtC.Copy();
            this.mDTFKStandard = dtFK.Copy();
            this.mDTFKModfied = dtFK.Copy();
            this.dataGridViewWords.DataSource = this.mDTCModfied;
            this.dataGridViewConstraint.DataSource = this.mDTFKModfied;
            this.CloseConnection();
            return true;
        }

        private void buttonAddWord_Click(object sender, EventArgs e)
        {
            this.mDTCModfied.Rows.Add();
        }

        private void buttonDeleteWord_Click(object sender, EventArgs e)
        {
            if (this.dataGridViewWords.SelectedRows.Count > 0)
            {
                for (int i = 0; i < this.dataGridViewWords.SelectedRows.Count; i++)
                {
                    this.dataGridViewWords.Rows.Remove(this.dataGridViewWords.SelectedRows[i]);
                }
            }
            else if (this.dataGridViewWords.CurrentRow != null)
            {
                this.dataGridViewWords.Rows.Remove(this.dataGridViewWords.CurrentRow);
            }
            else
            {
                MessageBox.Show("当前未选中字段！");
                return;
            }
        }

        private void buttonCancel_Click(object sender, EventArgs e)
        {
            this.DialogResult = DialogResult.Cancel;
            this.Close();
        }

        private void buttonOK_Click(object sender, EventArgs e)
        {   
            DialogResult dialogResult = MessageBox.Show("确定要保存当前设置吗？", "提示", MessageBoxButtons.OKCancel);
            if (dialogResult == DialogResult.Cancel) return;
            else
            {
                // 比对表修改、执行语句
                if(this.checkTableName() && this.textBoxTableName.Text != "")
                {
                    this.renewTableName();
                }
                List<int> createCID = new List<int>();
                List<int> deleteCID = new List<int>();
                List<int> modifiedCID = new List<int>();
                List<int> createFKID = new List<int>();
                List<int> deleteFKID = new List<int>();
                List<int> modifiedFKID = new List<int>();
                bool resCheckDTC = this.checkDTC(ref createCID, ref deleteCID, ref modifiedCID);
                bool resCheckDTFK = this.checkDTFK(ref createFKID, ref deleteFKID, ref modifiedFKID);
                foreach (int i in createCID)
                {
                    string columnName = this.mDTCModfied.Rows[i][0].ToString();
                    string dataType = this.mDTCModfied.Rows[i][1].ToString();
                    this.AddColumn(columnName, dataType);
                    modifiedCID.Add(i);
                }
                foreach (int i in deleteCID)
                {
                    string columnName = this.mDTCStandard.Rows[i][0].ToString();
                    this.DeleteColumn(columnName);
                }

                // 更改字段名称和数据类型，删除自增与非空约束
                for (int i = 0; i < this.mDTCModfied.Rows.Count; i++)
                {
                    if (this.mDTCModfied.Rows[i].RowState == DataRowState.Deleted) continue;
                    string newField = this.mDTCModfied.Rows[i][0].ToString();
                    string newType = this.mDTCModfied.Rows[i][1].ToString();
                    if(i < this.mDTCStandard.Rows.Count)
                    {
                        string oldColumnName = this.mDTCStandard.Rows[i][0].ToString();
                        Console.WriteLine(oldColumnName + " " + newField + " " + newType);
                        this.AlterColumnNameDataType(oldColumnName, newField, newType);
                    }
                    this.DeleteAutoincrementEmptyDefaultConstraint(newField, newType); 
                }

                // 删除外键约束
                for (int i = 0; i < this.mDTFKModfied.Rows.Count && i < this.mDTFKStandard.Rows.Count; i++)
                {
                    this.DeleteForeignKey(this.mDTFKStandard.Rows[i][0].ToString());
                }

                // 删除主键约束、唯一约束
                this.DeleteKeyConstraint();
                this.DeletePrimaryKey();

                // 添加主键约束
                string primaryColumName = "";
                for(int i = 0; i < this.mDTCModfied.Rows.Count; i++)
                {
                    if (this.mDTCModfied.Rows[i].RowState == DataRowState.Deleted) continue;
                    bool newPrimary = this.mDTCModfied.Rows[i][3].ToString().Equals("PRI");
                    string newType = this.mDTCModfied.Rows[i][1].ToString();
                    if (newPrimary) primaryColumName += this.mDTCModfied.Rows[i][0].ToString() + ",";
                }
                if(primaryColumName != "")
                {
                    primaryColumName = primaryColumName.Substring(0, primaryColumName.Length - 1);
                    this.AddPrimaryKey(primaryColumName);
                }

                // 添加外键约束
                for (int i = 0; i < this.mDTFKModfied.Rows.Count; i++)
                {
                    if (this.mDTFKModfied.Rows[i].RowState == DataRowState.Deleted) continue;
                    this.AddForeignKey(this.mDTFKModfied.Rows[i][2].ToString(), 
                    this.mDTFKModfied.Rows[i][3].ToString(), 
                    this.mDTFKModfied.Rows[i][4].ToString());
                }

                // 添加其他约束
                for (int i = 0; i < this.mDTCModfied.Rows.Count; i++)
                {
                    if (this.mDTCModfied.Rows[i].RowState == DataRowState.Deleted) continue;
                    string columnName = this.mDTCModfied.Rows[i][0].ToString();
                    string dataType = this.mDTCModfied.Rows[i][1].ToString();
                    bool NULL = this.mDTCModfied.Rows[i][2].ToString().Equals("NO");
                    bool Key = this.mDTCModfied.Rows[i][3].ToString().Equals("UNI");
                    bool Extra = this.mDTCModfied.Rows[i][4].ToString().Equals("auto_increment");
                    this.SwitchConstraint(columnName, dataType, NULL, Extra, Key);
                }

                //Console.WriteLine(resCheckDTC);
                this.GetTableWordInfo();
            }
        }

        private void buttonAddFK_Click(object sender, EventArgs e)
        {
            this.mDTFKModfied.Rows.Add();
        }

        private void buttonDeleteFK_Click(object sender, EventArgs e)
        {
            if (this.dataGridViewConstraint.SelectedRows.Count > 0)
            {
                for (int i = 0; i < this.dataGridViewConstraint.SelectedRows.Count; i++)
                {
                    this.dataGridViewConstraint.Rows.Remove(this.dataGridViewConstraint.SelectedRows[i]);
                }
            }
            else if (this.dataGridViewConstraint.CurrentRow != null)
            {
                this.dataGridViewConstraint.Rows.Remove(this.dataGridViewConstraint.CurrentRow);
            }
            else
            {
                MessageBox.Show("当前未选中字段！");
                return;
            }
        }

        /// <summary>
        /// 检查表名是否更改、更改是否合法
        /// </summary>
        /// <returns>已更改则返回true</returns>
        private bool checkTableName()
        {
            string newTableName = this.textBoxTableName.Text;
            if (this.mTableName == newTableName) return false;
            else if(newTableName == "")
            {
                MessageBox.Show("数据表名不能为空！");
            }
            return true;
        }

        /// <summary>
        /// 更新表名
        /// </summary>
        private void renewTableName()
        {
            string newTableName = this.textBoxTableName.Text;
            if(!this.AlterTableName(this.mTableName, newTableName))
            {
                MessageBox.Show("数据表重命名失败！");
                return;
            }
            this.mTableName = newTableName;
        }

        /// <summary> 
        /// 检查mDTCStandard与mDTCModfied是否更改
        /// </summary>
        /// <returns>已更改为true，否则为false</returns>
        private bool checkDTC(ref List<int> createID, ref List<int> deleteID, ref List<int> modifiedID)
        {
            bool isChanged = false;
            createID.Clear();
            deleteID.Clear();
            modifiedID.Clear();
            for(int i = 0; i < this.mDTCModfied.Rows.Count; i++)
            {
                if(this.mDTCModfied.Rows[i].RowState == DataRowState.Added)
                {
                    createID.Add(i);
                    isChanged = true;
                }
                else if(this.mDTCModfied.Rows[i].RowState == DataRowState.Deleted)
                {
                    deleteID.Add(i);
                    isChanged = true;
                }
                else if(this.mDTCModfied.Rows[i].RowState == DataRowState.Modified)
                {
                    modifiedID.Add(i);
                    isChanged = true;
                }
            }
            return isChanged;
        }
        
        /// <summary>
        /// 检查mDTFKStandard与mDTFKModfied是否更改
        /// </summary>
        /// <param name="createID"></param>
        /// <param name="deleteID"></param>
        /// <param name="modifiedID"></param>
        /// <returns></returns>
        private bool checkDTFK(ref List<int> createID, ref List<int> deleteID, ref List<int> modifiedID)
        {
            bool isChanged = false;
            createID.Clear();
            deleteID.Clear();
            modifiedID.Clear();
            for(int i = 0; i < this.mDTFKModfied.Rows.Count; i++)
            {
                if(this.mDTFKModfied.Rows[i].RowState == DataRowState.Added)
                {
                    createID.Add(i);
                    isChanged = true;
                }
                else if(this.mDTFKModfied.Rows[i].RowState == DataRowState.Deleted)
                {
                    deleteID.Add(i);
                    isChanged = true;
                }
                else if(this.mDTFKModfied.Rows[i].RowState == DataRowState.Modified)
                {
                    modifiedID.Add(i);
                    isChanged = true;
                }
            }
            return isChanged;
        }

        private bool AlterTableName(string oldTableName, string newTableName)
        {
            if (!this.OpenConnection()) return false;
            bool exeSuccess = true;
            this.mCommand = this.mConnection.CreateCommand();
            try
            {
                this.mCommand.CommandText = "ALTER  TABLE " + oldTableName + " RENAME TO " + newTableName + ";";
                this.mCommand.ExecuteNonQuery();
            }
            catch (Exception exception)
            {
                Console.WriteLine(exception.ToString());
                exeSuccess = false;
            }
            return exeSuccess;
        }

        private void SwitchConstraint(string columnName, string dataType, bool empty, bool autoincrement, bool unique)
        {
            if (empty && autoincrement && unique) this.AddEmptyUniqueAutoincrementConstraint(columnName, dataType);
            else if (empty && autoincrement) this.AddEmptyAutoincrementConstraint(columnName, dataType);
            else if (empty && unique) this.AddEmptyUniqueConstraint(columnName, dataType);
            else if (autoincrement && unique) this.AddUniqueAutoincrementConstraint(columnName, dataType);
            else if (empty) this.AddEmptyConstraint(columnName, dataType);
            else if (autoincrement) this.AddAutoincrementConstraint(columnName, dataType);
            else if (unique) this.AddUniqueConstraint(columnName, dataType);
            else return;
        }

        private bool AddColumn(string columnName, string dataType)
        {
            if (!this.OpenConnection()) return false;
            bool exeSuccess = true;
            this.mCommand = this.mConnection.CreateCommand();
            try
            {
                this.mCommand.CommandText = "ALTER TABLE " + this.mTableName + " ADD " + columnName + " " + dataType + ";";
                this.mCommand.ExecuteNonQuery();
            }
            catch (Exception exception)
            {
                Console.WriteLine(exception.ToString());
                exeSuccess = false;
            }
            return exeSuccess;
        }
        
        private bool DeleteColumn(string columnName)
        {
            if (!this.OpenConnection()) return false;
            bool exeSuccess = true;
            this.mCommand = this.mConnection.CreateCommand();
            try
            {
                this.mCommand.CommandText = "ALTER TABLE " + this.mTableName + " DROP COLUMN " + columnName + ";";
                this.mCommand.ExecuteNonQuery();
            }
            catch (Exception exception)
            {
                Console.WriteLine(exception.ToString());
                MessageBox.Show("删除失败！");
                exeSuccess = false;
            }
            return exeSuccess;
        }

        private bool AlterColumnNameDataType(string oldColumnName, string newColumnName, string dataType)
        {
            if (!this.OpenConnection()) return false;
            bool exeSuccess = true;
            this.mCommand = this.mConnection.CreateCommand();
            try
            {
                this.mCommand.CommandText = "ALTER TABLE " + this.mTableName + " CHANGE " + oldColumnName + " " + newColumnName + " " + dataType + ";";
                this.mCommand.ExecuteNonQuery();
            }
            catch (Exception exception)
            {
                Console.WriteLine(exception.ToString());
                exeSuccess = false;
            }
            return exeSuccess;
        }

        private bool AddEmptyConstraint(string columnName, string dataType)
        {
            if (!this.OpenConnection()) return false;
            bool exeSuccess = true;
            this.mCommand = this.mConnection.CreateCommand();
            try
            {
                this.mCommand.CommandText = "ALTER TABLE " + this.mTableName + " MODIFY COLUMN " + columnName + " " + dataType + " NOT NULL;";
                this.mCommand.ExecuteNonQuery();
            }
            catch (Exception exception)
            {
                Console.WriteLine(exception.ToString());
                exeSuccess = false;
            }
            return exeSuccess;
        }

        private bool DeleteKeyConstraint()
        {
            if (!this.OpenConnection()) return false;
            DataTable dtKeys;
            this.mCommand = this.mConnection.CreateCommand();
            this.mCommand.CommandText = "SELECT DISTINCT TABLE_NAME, INDEX_NAME " +
                                            "FROM INFORMATION_SCHEMA.STATISTICS " +
                                            "WHERE TABLE_SCHEMA = '" + this.mDataBase + "' and " +
                                            "TABLE_NAME = '" + this.mTableName + "';";
            using (MySqlDataAdapter adapter = new MySqlDataAdapter(this.mCommand))
            {
                dtKeys = new DataTable();
                adapter.Fill(dtKeys);
            }
            bool exeSuccess = true;
            this.mCommand = this.mConnection.CreateCommand();
            try
            {
                for(int i = 0; i < dtKeys.Rows.Count; i++)
                {
                    string keyName = dtKeys.Rows[i][1].ToString();
                    Console.WriteLine("delete key name: ", keyName);
                    this.mCommand.CommandText = "ALTER TABLE " + this.mTableName + " DROP INDEX " + keyName + ";";
                    this.mCommand.ExecuteNonQuery();
                }
            }
            catch (Exception exception)
            {
                Console.WriteLine(exception.ToString());
                exeSuccess = false;
            }
            return exeSuccess;
        }

        private bool AddUniqueConstraint(string columnName, string dataType)
        {
            if (!this.OpenConnection()) return false;
            bool exeSuccess = true;
            this.mCommand = this.mConnection.CreateCommand();
            try
            {
                this.mCommand.CommandText = "ALTER TABLE " + this.mTableName + " MODIFY " + columnName + " " + dataType + " UNIQUE;";
                this.mCommand.ExecuteNonQuery();
            }
            catch (Exception exception)
            {
                Console.WriteLine(exception.ToString());
                exeSuccess = false;
            }
            return exeSuccess;
        }

        private bool AddEmptyUniqueConstraint(string columnName, string dataType)
        {
            if (!this.OpenConnection()) return false;
            bool exeSuccess = true;
            this.mCommand = this.mConnection.CreateCommand();
            try
            {
                this.mCommand.CommandText = "ALTER TABLE " + this.mTableName + " MODIFY " + columnName + " " + dataType + " NOT NULL UNIQUE;";
                this.mCommand.ExecuteNonQuery();
            }
            catch (Exception exception)
            {
                Console.WriteLine(exception.ToString());
                exeSuccess = false;
            }
            return exeSuccess;
        }

        private bool DeletePrimaryKey()
        {
            if (!this.OpenConnection()) return false;
            bool exeSuccess = true;
            this.mCommand = this.mConnection.CreateCommand();
            try
            {
                this.mCommand.CommandText = "ALTER TABLE " + this.mTableName + " DROP PRIMARY KEY;";
                this.mCommand.ExecuteNonQuery();
            }
            catch (Exception exception)
            {
                Console.WriteLine(exception.ToString());
                exeSuccess = false;
            }
            return exeSuccess;
        }

        private bool AddPrimaryKey(string columnName)
        {
            if (!this.OpenConnection()) return false;
            bool exeSuccess = true;
            this.mCommand = this.mConnection.CreateCommand();
            try
            {
                this.mCommand.CommandText = "ALTER TABLE " + this.mTableName + " ADD PRIMARY KEY(" + columnName + ");";
                this.mCommand.ExecuteNonQuery();
            }
            catch (Exception exception)
            {
                Console.WriteLine(exception.ToString());
                exeSuccess = false;
            }
            return exeSuccess;
        }

        private bool DeleteAutoincrementEmptyDefaultConstraint(string columnName, string dataType)
        {
            if (!this.OpenConnection()) return false;
            bool exeSuccess = true;
            this.mCommand = this.mConnection.CreateCommand();
            try
            {
                this.mCommand.CommandText = "ALTER TABLE " + this.mTableName + " MODIFY " + columnName + " " + dataType + ";";
                this.mCommand.ExecuteNonQuery();
            }
            catch (Exception exception)
            {
                Console.WriteLine(exception.ToString());
                exeSuccess = false;
            }
            return exeSuccess;
        }

        private bool AddAutoincrementConstraint(string columnName, string dataType)
        {
            if (!this.OpenConnection()) return false;
            bool exeSuccess = true;
            this.mCommand = this.mConnection.CreateCommand();
            try
            {
                this.mCommand.CommandText = "ALTER TABLE " + this.mTableName + " MODIFY " + columnName + " " + dataType + " AUTO_INCREMENT;";
                this.mCommand.ExecuteNonQuery();
            }
            catch (Exception exception)
            {
                Console.WriteLine(exception.ToString());
                exeSuccess = false;
            }
            return exeSuccess;
        }

        private bool AddEmptyAutoincrementConstraint(string columnName, string dataType)
        {
            if (!this.OpenConnection()) return false;
            bool exeSuccess = true;
            this.mCommand = this.mConnection.CreateCommand();
            try
            {
                this.mCommand.CommandText = "ALTER TABLE " + this.mTableName + " MODIFY " + columnName + " " + dataType + " NOT NULL AUTO_INCREMENT;";
                this.mCommand.ExecuteNonQuery();
            }
            catch (Exception exception)
            {
                Console.WriteLine(exception.ToString());
                exeSuccess = false;
            }
            return exeSuccess;
        }

        private bool AddUniqueAutoincrementConstraint(string columnName, string dataType)
        {
            if (!this.OpenConnection()) return false;
            bool exeSuccess = true;
            this.mCommand = this.mConnection.CreateCommand();
            try
            {
                this.mCommand.CommandText = "ALTER TABLE " + this.mTableName + " MODIFY " + columnName + " " + dataType + " UNIQUE AUTO_INCREMENT;";
                this.mCommand.ExecuteNonQuery();
            }
            catch (Exception exception)
            {
                Console.WriteLine(exception.ToString());
                exeSuccess = false;
            }
            return exeSuccess;
        }

        private bool AddEmptyUniqueAutoincrementConstraint(string columnName, string dataType)
        {
            if (!this.OpenConnection()) return false;
            bool exeSuccess = true;
            this.mCommand = this.mConnection.CreateCommand();
            try
            {
                this.mCommand.CommandText = "ALTER TABLE " + this.mTableName + " MODIFY " + columnName + " " + dataType + " NOT NULL UNIQUE AUTO_INCREMENT;";
                this.mCommand.ExecuteNonQuery();
            }
            catch (Exception exception)
            {
                Console.WriteLine(exception.ToString());
                exeSuccess = false;
            }
            return exeSuccess;
        }

        private bool AddForeignKey(string columnName, string refTableName, string refPrimaryName)
        {
            if (!this.OpenConnection()) return false;
            bool exeSuccess = true;
            this.mCommand = this.mConnection.CreateCommand();
            try
            {
                this.mCommand.CommandText = "alter table " + this.mTableName + " add foreign key(" + columnName + ") references " + refTableName + "(" + refPrimaryName + ")";
                this.mCommand.ExecuteNonQuery();
            }
            catch (Exception exception)
            {
                Console.WriteLine(exception.ToString());
                exeSuccess = false;
            }
            return exeSuccess;
        }
    
        private bool DeleteForeignKey(string foreignKeyName)
        {
            if (!this.OpenConnection()) return false;
            bool exeSuccess = true;
            this.mCommand = this.mConnection.CreateCommand();
            try
            {
                this.mCommand.CommandText = "alter table " + this.mTableName + " drop foreign key " + foreignKeyName + ";";
                this.mCommand.ExecuteNonQuery();
            }
            catch (Exception exception)
            {
                Console.WriteLine(exception.ToString());
                exeSuccess = false;
            }
            return exeSuccess;
        }
    }
}
