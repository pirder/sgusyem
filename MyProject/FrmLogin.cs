using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Configuration;

namespace MyProject
{
    public partial class FrmLogin : Form
    {
        public FrmLogin()
        {
            InitializeComponent();
            txtNum.Text = ConfigurationManager.AppSettings["usernum"];
        }

        private bool login(string num, string password, int limit)
        {
            bool result = false;
            string sql = "";                  
            if (limit == 2)            
                sql = "select count(*) from users where users_num='" + num + "' and users_password='" + password + "' and users_limit = 2";            
            else
                sql = "select count(*) from users where users_num='" + num + "' and users_password='" + password + "' and users_limit = 1";
            result = Program.SearchSql(sql);
            return result;
        }
      
        private void btnLogin_Click(object sender, EventArgs e)
        {
            string userNum = txtNum.Text;          
            string userPassword = txtPassword.Text;
            txtPassword.Text = "123456";
            int limit = 1;
            bool resultnum = false;
            bool resultlimit = false;
            bool resultlogin = false;
            prompt1.Text = "";
            prompt2.Text = "";
            if (txtNum.Text == "")
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
            string checkname = "select count(*) from users where users_num = '" + userNum + "'";
            resultnum = Program.SearchSql(checkname);
            if (!resultnum)
            {
                prompt1.Text = "手机号不存在";
                prompt1.ForeColor = Color.Red;
                return;
            }          
            if (btnManager.Checked == true)
            {
                limit = 2;
                string checklimit = "select count(*) from users where users_num = '" + userNum + "' and users_limit = 2";
                resultlimit = Program.SearchSql(checklimit);
                if (!resultlimit)
                {
                    prompt3.Text = "该账号不是管理员账号";
                    prompt3.ForeColor = Color.Red;
                    return;
                }
                resultlogin = login(userNum, userPassword, limit);
                if (resultlogin)
                {
                    Configuration cfa = ConfigurationManager.OpenExeConfiguration(ConfigurationUserLevel.None);
                    cfa.AppSettings.Settings["usernum"].Value = userNum;
                    cfa.Save();
                    ConfigurationManager.RefreshSection("appSettings");
                    FrmMain f = new FrmMain(userNum,limit);
                    f.Show();
                    this.Hide();
                }
                else
                {
                    prompt2.Text = "密码错误";
                    prompt2.ForeColor = Color.Red;
                    return;
                }
            }
            if (btnUser.Checked == true)
            {
                limit = 1;
                string checklimit = "select count(*) from users where users_num = '" + userNum + "' and users_limit = 1";
                resultlimit = Program.SearchSql(checklimit);
                if (!resultlimit)
                {
                    prompt3.Text = "该账号不是用户账号";
                    prompt3.ForeColor = Color.Red;
                    return;
                }
                resultlogin = login(userNum, userPassword, limit);
                if (resultlogin)
                {
                    Configuration cfa = ConfigurationManager.OpenExeConfiguration(ConfigurationUserLevel.None);
                    cfa.AppSettings.Settings["usernum"].Value = userNum;
                    cfa.Save();
                    ConfigurationManager.RefreshSection("appSettings");
                    FrmSelect f = new FrmSelect(userNum,limit);
                    f.Show();
                    this.Hide();
                }
                else
                {
                    prompt2.Text = "密码错误";
                    prompt2.ForeColor = Color.Red;
                    return;
                }
            }            
        }

        private void btnRegister_Click(object sender, EventArgs e)
        {
            FrmRegister f = new FrmRegister();
            f.Show();           
        }
    }
}
