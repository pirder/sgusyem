using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace MyProject
{
    public partial class frmusersupdate : Form
    {
        
        public frmusersupdate()
        {
            
            InitializeComponent();
            txtUpdateName.Text = UpdateClass.uusername;
            txtUpdatePassword.Text = UpdateClass.uuserpassword;
            txtUpdateNum.Text = UpdateClass.uusernum;
           
        }

        private void btnRegisterComfirm_Click(object sender, EventArgs e)
        {
            
            string userName = txtUpdateName.Text;
            string userPassword = txtUpdatePassword.Text;
            string userNum = txtUpdateNum.Text;
            bool result = false;
            string sqlUpdate = string.Format("update users set  users_name='{0}',users_num='{1}',users_password='{2}' where users_name='{3}';",userName,userNum,userPassword, userName);
            result = Program.ExecuteSql(sqlUpdate);
            if (result)
            {
                MessageBox.Show("修改成功");
            }
            else
            {
                MessageBox.Show("修改失败");
            }
        }

        private void frmusersupdate_Load(object sender, EventArgs e)
        {

        }
    }
}
