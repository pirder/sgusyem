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
    public partial class FrmUserManager : Form
    {
        public FrmUserManager()
        {
            InitializeComponent();
        }

        private void searchnumbtn_Click(object sender, EventArgs e)
        {
            string usernum = txtnumsearch.Text;
            string sqlsearchnum = "select users_name,users_num,users_password from users where users_num = '"+ usernum +"'";                 
            dataGridViewUser.DataSource = Program.GetDataTable(sqlsearchnum.ToString());
          //  dataGridViewUser.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.AllCells;
            dataGridViewUser.ColumnHeadersDefaultCellStyle.BackColor = Color.FromArgb(81, 125, 191);
            if (dataGridViewUser.Rows.Count == 0)          
                MessageBox.Show("没有符合条件的数据");

        }

        private void searchallbtn_Click(object sender, EventArgs e)
        {
            string sqlsearchnum = "select users_name,users_num,users_password from users";         
            dataGridViewUser.DataSource = Program.GetDataTable(sqlsearchnum.ToString());
          //  dataGridViewUser.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.AllCells;
            dataGridViewUser.ColumnHeadersDefaultCellStyle.BackColor = Color.FromArgb(81, 125, 191);
            if (dataGridViewUser.Rows.Count == 0)          
                MessageBox.Show("没有符合条件的数据");
        }

        private void FrmUserManager_FormClosing(object sender, FormClosingEventArgs e)
        {
            Application.Exit(); 
        }
    }
}
