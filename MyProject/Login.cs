using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using System.Data.OleDb;


namespace keyanchu
{  
    public partial class Login : Form
    {       
        public Login()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }
        

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void label4_Click(object sender, EventArgs e)
        {

        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            ;

        }


        private void label5_Click(object sender, EventArgs e)
        {

        }

        private void textBoxUserName_TextChanged(object sender, EventArgs e)
        {

        }

        private void checkBox1_CheckedChanged(object sender, EventArgs e)
        {

        }

        private static bool SearchSql(string sql)
        {
            bool loginResult = false;
            OleDbConnection conn = new OleDbConnection();
            //创建OleDb连接对象
            conn.ConnectionString = @"Provider=Microsoft.ACE.OLEDB.12.0;Data Source=E:\VSWorkPlace\MyProject\Database1.accdb;Persist Security Info=False";
            //将生成的字符串传入
            conn.Open();
            //打开数据库
            OleDbCommand mycmd = new OleDbCommand(sql, conn);
            //创建sql命令对象
            int result = (int)mycmd.ExecuteScalar();
            conn.Close();
            //最后不要忘了关数据库
            if (result > 0)
            {
                loginResult = true;
            }
            else
            {
                loginResult = false;
            }
            mycmd.Dispose();
            return loginResult;
        }

        private bool login(string name, string password,int limit)
        {
            bool result = false;
            string sql = "";
            if(limit==2)
              sql = "select count(*) from users where users_name='" + name + "' and users_password='" + password + "' and users_limit = 2";
            else
              sql = "select count(*) from users where users_name='" + name + "' and users_password='" + password + "' and users_limit = 1";
            result = SearchSql(sql);
            return result;
        }

            private void button1_Click_1(object sender, EventArgs e)
        {
            string userName = txtName.Text;
            string userPassword = txtPassword.Text;
            int limit = 1;
            bool result = false;
            prompt1.Text = "";
            prompt2.Text = "";
            if (txtName.Text == "")
            {
                prompt1.Text = "账号不能为空";
                prompt1.ForeColor = Color.Red;
                return;
            }
           
            if (txtPassword.Text == "")
            {
                prompt2.Text = "密码不能为空";
                prompt2.ForeColor = Color.Red;
                return;
            }
            
            if (btnManager.Checked == true)
            {
                limit = 2;
                result = login(userName, userPassword, limit);
            }
            if (btnUser.Checked == true)
            {
                limit = 1;
                result = login(userName, userPassword, limit);
            }
            if (result)
            {
                MessageBox.Show("登录成功");
              //  FrmMain f = new FrmMain();
              //  f.Show();
              //this.Hide();
            }
            else
            {
                MessageBox.Show("登录失败");
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            prompt1.Text = "";
            prompt2.Text = "";
            string userName = txtName.Text;
            string userPassword = txtPassword.Text;
            int limit = 1;
            bool result = false;
            string checksql = "select count(*) from users where users_name = '" + userName + "'";
            result = SearchSql(checksql);
            if (result)
            {
                prompt1.Text = "该用户名已存在，请更改为另一个用户名！";          
                return;
            }
            string sql = string.Format("insert into users(users_name,users_password,users_limit) values('{0}','{1}',{2})", userName, userPassword, limit);
            if (txtName.Text == "")
            {
                prompt1.Text = "账号不能为空";
                prompt1.ForeColor = Color.Red;
            }
            if (txtPassword.Text == "")
            {
                prompt2.Text = "密码不能为空";
                prompt2.ForeColor = Color.Red;
            }
            if (btnManager.Checked == true)
            {
                MessageBox.Show("不能注册超级管理员");
                return;
            }
            result = ExecuteSql(sql);
            if (result)
            {            
                MessageBox.Show("注册成功！");
            }
            else
            {
                MessageBox.Show("注册失败");
            }
        }

        private static bool ExecuteSql(string sql)
        {
            bool ReturnResult = false;
            OleDbConnection conn = new OleDbConnection();
            //创建OleDb连接对象
            conn.ConnectionString = @"Provider=Microsoft.ACE.OLEDB.12.0;Data Source=E:\VSWorkPlace\MyProject\Database1.accdb;Persist Security Info=False";
            //将生成的字符串传入
            conn.Open();
            //打开数据库
            OleDbCommand cmd = new OleDbCommand(sql, conn);
            int result = cmd.ExecuteNonQuery();
            conn.Close();
            //最后不要忘了关数据库
            if (result > 0)
            {
                ReturnResult = true;
            }
            else
            {
                ReturnResult = false;
            }
            cmd.Dispose();
            return ReturnResult;
        }


        private void radioButton1_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void txtPassword_TextChanged(object sender, EventArgs e)
        {
        }
    }
}
