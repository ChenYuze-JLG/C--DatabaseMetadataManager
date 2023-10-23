using MySql.Data.MySqlClient;
using System;
using System.Data;
using System.Windows.Forms;

namespace DataInfoMangement
{
    public partial class ConnectDBForm : Form
    {
        public string mServer = "";
        public string mUser = "";
        public string mPassword = "";
        public string mDataBase = "";
        private string mConnectionStr = "";
        public ConnectDBForm()
        {
            InitializeComponent();
        }

        private void buttonConnect_Click(object sender, EventArgs e)
        {
            this.mServer = this.textBoxServer.Text;
            this.mUser = this.textBoxUserName.Text;
            this.mPassword = this.textBoxPassword.Text;
            this.mDataBase = this.textBoxDatabase.Text;
            if (this.mServer == "" || this.mUser == "" || this.mPassword == "" || this.mDataBase == "")
            {
                MessageBox.Show("不能填写空值！");
                return;
            }
            else
            {
                this.BuildConnectStr(this.mServer, this.mUser, this.mPassword, this.mDataBase);
                MySqlConnection mySqlConnection = new MySqlConnection(this.mConnectionStr);
                mySqlConnection.Open();
                if (mySqlConnection.State != ConnectionState.Open)
                {
                    MessageBox.Show("连接失败！");
                    return;
                }
            }
            this.DialogResult = DialogResult.OK;
            this.Close();
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

        private void buttonCancel_Click(object sender, EventArgs e)
        {
            this.DialogResult = DialogResult.Cancel;
            this.Close();
        }
    }
}
