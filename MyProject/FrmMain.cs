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
    public partial class FrmMain : Form
    {
        public FrmMain(string num)
        {
            InitializeComponent();
            string sql = "select users_name from users where users_num = '" + num + "'";
            DataTable dt = new DataTable();
            dt = Program.GetDataTable(sql);
            DataRow dr = dt.Rows[0];
            string userName = dr["users_name"].ToString();
            toolStripMain.Text = "欢迎用户:" + userName + "进入韶关学院知识产权管理员管理系统";
        }

        private void 数据查询ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            int i = 0;
            FrmSelect f = new FrmSelect(i,toolStripMain.Text);
            f.Show();

        }

        private void button5_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void FrmMain_FormClosed(object sender, FormClosedEventArgs e)
        {
            Application.Exit();
        }

        private void 系统管理ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            FrmUserManager f = new FrmUserManager();
            f.Show();
        }
        //尝试一下是否拉去成功
         
        private void button1_Click(object sender, EventArgs e)
        {
            FrmAdd f = new FrmAdd();
            f.Show();

        }

        private void button2_Click(object sender, EventArgs e)
        {
            int i = 0;
            FrmSelect f = new FrmSelect(i, toolStripMain.Text);
            f.Show();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            int i = 0;
            FrmSelect f = new FrmSelect(i, toolStripMain.Text);
            f.Show();
        }      
    }
}
