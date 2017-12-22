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
           
        }

        private void dataGridViewUser_CellMouseDown(object sender, DataGridViewCellMouseEventArgs e)
        {
            if (e.Button == MouseButtons.Right)
            {
                if (e.RowIndex >= 0)
                {
                    //若行已是选中状态就不再进行设置
                    if (dataGridViewUser.Rows[e.RowIndex].Selected == false)
                    {
                        dataGridViewUser.ClearSelection();
                        dataGridViewUser.Rows[e.RowIndex].Selected = true;
                    }
                    //只选中一行时设置活动单元格
                    if (dataGridViewUser.SelectedRows.Count == 1)
                    {
                        dataGridViewUser.CurrentCell = dataGridViewUser.Rows[e.RowIndex].Cells[e.ColumnIndex];
                    }
                    //弹出操作菜单
                    contextMenuStrip1.Show(MousePosition.X, MousePosition.Y);
                }
            }
        }

        private void 删除用户ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            string sqluser = "delete from users where users_num = '" + dataGridViewUser.Rows[dataGridViewUser.CurrentCell.RowIndex].Cells[1].Value.ToString() + "' or users_name='"+ dataGridViewUser.Rows[dataGridViewUser.CurrentCell.RowIndex].Cells[0].Value.ToString() + "'";
            bool delresult = Program.ExecuteSql(sqluser);
            if (delresult)
            {
                MessageBox.Show("已删除《" + dataGridViewUser.Rows[dataGridViewUser.CurrentCell.RowIndex].Cells[0].Value.ToString() + "》该项用户");
                searchallbtn_Click(null, null);
            }
            else
            {
                MessageBox.Show("删除失败");
            }
        }

        private void 新增用户ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            FrmRegister f = new FrmRegister();
            f.Show();
        }

        private void 修改用户ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            UpdateClass.uusername = dataGridViewUser.Rows[dataGridViewUser.CurrentCell.RowIndex].Cells[0].Value.ToString();
            UpdateClass.uusernum = dataGridViewUser.Rows[dataGridViewUser.CurrentCell.RowIndex].Cells[1].Value.ToString();
            UpdateClass.uuserpassword = dataGridViewUser.Rows[dataGridViewUser.CurrentCell.RowIndex].Cells[2].Value.ToString();
        }
    }
}
