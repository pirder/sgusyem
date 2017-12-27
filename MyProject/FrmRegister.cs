using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.OleDb;

namespace MyProject
{
    public partial class FrmRegister : Form
    {
        public FrmRegister()
        {
            InitializeComponent();
        }

        private void btnRegisterComfirm_Click(object sender, EventArgs e)
        {
            promptRegisterName.Text = "";
            promptRegisterPassword.Text = "";
            promptRegisterNum.Text = "";
            string userName = txtRegisterName.Text;
            string userPassword = txtRegisterPassword.Text;
            string userNum = txtRegisterNum.Text;
            int limit = 1;
            bool result = false;
            string checksql = "select count(*) from users where users_num = '" + userNum + "'";
            result = Program.SearchSql(checksql);
            if (result)
            {
                promptRegisterNum.Text = "该手机号已被注册，请更改为另一个手机号！";
                return;
            }
            string sql = string.Format("insert into users(users_name,users_password,users_limit,users_num) values('{0}','{1}',{2},'{3}')", userName, userPassword, limit, userNum);
            if (txtRegisterName.Text == "")
            {
                promptRegisterName.Text = "账号不能为空";
                promptRegisterName.ForeColor = Color.Red;
                return;
            }
            if (txtRegisterPassword.Text == "")
            {
                promptRegisterPassword.Text = "密码不能为空";
                promptRegisterPassword.ForeColor = Color.Red;
                return;
            }
            if (txtRegisterNum.Text == "")
            {
                promptRegisterNum.Text = "密码不能为空";
                promptRegisterNum.ForeColor = Color.Red;
                return;
            }
            result = Program.ExecuteSql(sql);
            if (result)
            {
                MessageBox.Show("注册成功！");
                this.Close();
            }
            else
            {
                MessageBox.Show("注册失败,请联系创想工作室");
            }
        }       
    }
}
