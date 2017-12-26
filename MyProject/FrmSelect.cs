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
using System.Runtime.InteropServices;

namespace MyProject
{
    public partial class FrmSelect : Form
    {
        string gifullname = "无";
        string cifullname = "无";
        public FrmSelect()
        {
            InitializeComponent();
            
            string sqlinstitutecombo = "select institute_name from institute";
            DataTable dt = new DataTable();
            dt = Program.GetDataTable(sqlinstitutecombo);
            DataRow dr = dt.Rows[0];
            for (int i = 0; i < dt.Rows.Count; i++)
            {
                dr = dt.Rows[i];
                string instituteName = dr["institute_name"].ToString();
                comboInstitute.Items.Add(instituteName);
            }
            string sqlpatenttype = "select distinct patent_type from patent_institute";
            DataTable dt1 = new DataTable();
            dt1 = Program.GetDataTable(sqlpatenttype);
            DataRow dr1 = dt1.Rows[0];
            for (int i = 0; i < dt1.Rows.Count; i++)
            {
                dr1 = dt1.Rows[i];
                string patenttypeName = dr1["patent_type"].ToString();
                comboPatentType.Items.Add(patenttypeName);
            }
            string sqlagency = "select distinct agency from patent_institute";
            DataTable dt2 = new DataTable();
            dt2 = Program.GetDataTable(sqlagency);
            DataRow dr2 = dt2.Rows[0];
            for (int i = 0; i < dt2.Rows.Count; i++)
            {
                dr2 = dt2.Rows[i];
                string agencyName = dr2["agency"].ToString();
                comboAgency.Items.Add(agencyName);
            }
            for (int i = 1980; i < 3000; i++)
                comboApplyDateStartYear.Items.Add(i);
            for (int i = 1980; i < 3000; i++)
                comboApplyDateEndYear.Items.Add(i);
            for (int i = 1980; i < 3000; i++)
                comboComfirmDateStartYear.Items.Add(i);
            for (int i = 1980; i < 3000; i++)
                comboComfirmDateEndYear.Items.Add(i);
            for (int i = 1980; i < 3000; i++)
                comboGrantDateStartYear.Items.Add(i);
            for (int i = 1980; i < 3000; i++)
                comboGrantDateEndYear.Items.Add(i);
            System.Drawing.Drawing2D.GraphicsPath myGraphicsPath = new System.Drawing.Drawing2D.GraphicsPath();
            
        }

        public FrmSelect(string num)
        {
            InitializeComponent();
            string sql = "select users_name from users where users_num = '" + num + "'";
            DataTable dt = new DataTable();
            dt = Program.GetDataTable(sql);
            DataRow dr = dt.Rows[0];
            string userName = dr["users_name"].ToString();
            toolStripStatusLabel1.Text = "欢迎用户:" + userName + "进入韶关学院知识产权查询系统";
        }

        public FrmSelect(int a, string name)
        {
            InitializeComponent();
            statusStripUserName.Text = name;
        }

        private void btnSearch_Click(object sender, EventArgs e)
        {
            StringBuilder sql = new StringBuilder();
            StringBuilder date = new StringBuilder();
            DataTable dt = new DataTable();          
            string patentnum = txtPatentNum.Text;
            string patenttype = comboPatentType.Text;
            string designer = txtDesiner.Text;
            string institute = comboInstitute.Text;
            string comfirmdatestartyear = comboComfirmDateStartYear.Text;
            string comfirmdatestartmonth = comboComfirmDateStartMonth.Text;
            string comfirmdatestartday = comboComfirmDateStartDay.Text;
            string comfirmdateendyear = comboComfirmDateEndYear.Text;
            string comfirmdateendmonth = comboComfirmDateEndMonth.Text;
            string comfirmdateendday = comboComfirmDateEndDay.Text;
            string applydatestartyear = comboApplyDateStartYear.Text;
            string applydatestartmonth = comboApplyDateStartMonth.Text;
            string applydatestartday = comboApplyDateStartDay.Text;
            string applydateendyear = comboApplyDateEndYear.Text;
            string applydateendmonth = comboApplyDateEndMonth.Text;
            string applydateendday = comboApplyDateEndDay.Text;
            string grantdatestartyear = comboGrantDateStartYear.Text;
            string grantdatestartmonth = comboGrantDateStartMonth.Text;
            string grantdatestartday = comboGrantDateStartDay.Text;
            string grantdateendyear = comboGrantDateEndYear.Text;
            string grantdateendmonth = comboGrantDateEndMonth.Text;
            string grantdateendday = comboGrantDateEndDay.Text;
            string agency = comboAgency.Text;
           

            sql.AppendLine("select patent_name,patent_type,first_designer,institute_name,other_designer,patent_num,confirm_date,apply_date,grant_date,isgrant,agency,patent_id,grant_inform_image,certificate_image from patent_institute where");
            if (patentnum != "")
                sql.AppendLine(" patent_num = '" + patentnum + "' and");
            if (patenttype != "")
                sql.AppendLine(" patent_type = '" + patenttype + "' and");
            if (designer != "")
                sql.AppendLine(" first_designer = '" + designer + "' and");
            if (institute != "")
                sql.AppendLine(" institute_name = '" + institute + "' and");
            if (agency != "")
                sql.AppendLine(" agency = '" + agency + "' and");
            if (comfirmdatestartyear != "")
            {
                if (comfirmdatestartmonth == "")
                {
                    date.AppendLine(comfirmdatestartyear + "/1/1");
                    sql.AppendLine(" apply_date >= #" + date.ToString() + "# and");
                    date.Clear();
                }
                if (comfirmdatestartmonth != "" && comfirmdatestartday == "")
                {
                    date.AppendLine(comfirmdatestartyear + "/" + comfirmdatestartmonth + "/1");
                    sql.AppendLine(" apply_date >= #" + date.ToString() + "# and");
                    date.Clear();
                }
                if (comfirmdatestartday != "")
                {
                    date.AppendLine(comfirmdatestartyear + "/" + comfirmdatestartmonth + "/" + comfirmdatestartday);
                    sql.AppendLine(" apply_date >= #" + date.ToString() + "# and");
                    date.Clear();
                }
            }
            if (comfirmdateendyear != "")
            {
                if (comfirmdateendmonth == "")
                {
                    date.AppendLine(comfirmdateendyear + "/12/31");
                    sql.AppendLine(" apply_date <= #" + date.ToString() + "# and");
                    date.Clear();
                }
                if (comfirmdateendmonth != "" && comfirmdateendday == "")
                {
                    date.AppendLine(comfirmdateendyear + "/");
                    int year = Convert.ToInt32(comfirmdateendyear);
                    if (comfirmdateendmonth == "2")
                    {
                        if (((year % 4 == 0) && (year % 100 != 0)) || (year % 400 == 0))
                            date.AppendLine(comfirmdateendmonth + "/29");
                        else
                            date.AppendLine(comfirmdateendmonth + "/28");
                    }
                    switch (comfirmdateendmonth)
                    {
                        case "1": date.AppendLine(comfirmdateendmonth + "/31"); break;
                        case "3": date.AppendLine(comfirmdateendmonth + "/31"); break;
                        case "4": date.AppendLine(comfirmdateendmonth + "/30"); break;
                        case "5": date.AppendLine(comfirmdateendmonth + "/31"); break;
                        case "6": date.AppendLine(comfirmdateendmonth + "/30"); break;
                        case "7": date.AppendLine(comfirmdateendmonth + "/31"); break;
                        case "8": date.AppendLine(comfirmdateendmonth + "/31"); break;
                        case "9": date.AppendLine(comfirmdateendmonth + "/30"); break;
                        case "10": date.AppendLine(comfirmdateendmonth + "/31"); break;
                        case "11": date.AppendLine(comfirmdateendmonth + "/30"); break;
                        case "12": date.AppendLine(comfirmdateendmonth + "/31"); break;

                    }
                    sql.AppendLine(" apply_date <= #" + date.ToString() + "# and");
                    date.Clear();
                }
                if (comfirmdateendday != "")
                {
                    date.AppendLine(comfirmdateendyear + "/" + comfirmdateendmonth + "/" + comfirmdateendday);
                    sql.AppendLine(" apply_date <= #" + date.ToString() + "# and");
                    date.Clear();
                }
            }
            if (applydatestartyear != "")
            {
                if (applydatestartmonth == "")
                {
                    date.AppendLine(applydatestartyear + "/1/1");
                    sql.AppendLine(" apply_date >= #" + date.ToString() + "# and");
                    date.Clear();
                }
                if (applydatestartmonth != "" && applydatestartday == "")
                {
                    date.AppendLine(applydatestartyear + "/" + applydatestartmonth + "/1");
                    sql.AppendLine(" apply_date >= #" + date.ToString() + "# and");
                    date.Clear();
                }
                if (applydatestartday != "")
                {
                    date.AppendLine(applydatestartyear + "/" + applydatestartmonth + "/" + applydatestartday);
                    sql.AppendLine(" apply_date >= #" + date.ToString() + "# and");
                    date.Clear();
                }
            }
            if (applydateendyear != "")
            {
                if (applydateendmonth == "")
                {
                    date.AppendLine(applydateendyear + "/12/31");
                    sql.AppendLine(" apply_date <= #" + date.ToString() + "# and");
                    date.Clear();
                }
                if (applydateendmonth != "" && applydateendday == "")
                {
                    date.AppendLine(applydateendyear + "/");
                    int year = Convert.ToInt32(applydateendyear);
                    if (applydateendmonth == "2")
                    {
                        if (((year % 4 == 0) && (year % 100 != 0)) || (year % 400 == 0))
                            date.AppendLine(applydateendmonth + "/29");
                        else
                            date.AppendLine(applydateendmonth + "/28");
                    }
                    switch (applydateendmonth)
                    {
                        case "1": date.AppendLine(applydateendmonth + "/31"); break;
                        case "3": date.AppendLine(applydateendmonth + "/31"); break;
                        case "4": date.AppendLine(applydateendmonth + "/30"); break;
                        case "5": date.AppendLine(applydateendmonth + "/31"); break;
                        case "6": date.AppendLine(applydateendmonth + "/30"); break;
                        case "7": date.AppendLine(applydateendmonth + "/31"); break;
                        case "8": date.AppendLine(applydateendmonth + "/31"); break;
                        case "9": date.AppendLine(applydateendmonth + "/30"); break;
                        case "10": date.AppendLine(applydateendmonth + "/31"); break;
                        case "11": date.AppendLine(applydateendmonth + "/30"); break;
                        case "12": date.AppendLine(applydateendmonth + "/31"); break;

                    }
                    sql.AppendLine(" apply_date <= #" + date.ToString() + "# and");
                    date.Clear();
                }
                if (applydateendday != "")
                {
                    date.AppendLine(applydateendyear + "/" + applydateendmonth + "/" + applydateendday);
                    sql.AppendLine(" apply_date <= #" + date.ToString() + "# and");
                    date.Clear();
                }
            }
            if (grantdatestartyear != "")
            {
                if (grantdatestartmonth == "")
                {
                    date.AppendLine(grantdatestartyear + "/1/1");
                    sql.AppendLine(" apply_date >= #" + date.ToString() + "# and");
                    date.Clear();
                }
                if (grantdatestartmonth != "" && grantdatestartday == "")
                {
                    date.AppendLine(grantdatestartyear + "/" + grantdatestartmonth + "/1");
                    sql.AppendLine(" apply_date >= #" + date.ToString() + "# and");
                    date.Clear();
                }
                if (grantdatestartday != "")
                {
                    date.AppendLine(grantdatestartyear + "/" + grantdatestartmonth + "/" + grantdatestartday);
                    sql.AppendLine(" apply_date >= #" + date.ToString() + "# and");
                    date.Clear();
                }
            }
            if (grantdateendyear != "")
            {
                if (grantdateendmonth == "")
                {
                    date.AppendLine(grantdateendyear + "/12/31");
                    sql.AppendLine(" apply_date <= #" + date.ToString() + "# and");
                    date.Clear();
                }
                if (grantdateendmonth != "" && grantdateendday == "")
                {
                    date.AppendLine(grantdateendyear + "/");
                    int year = Convert.ToInt32(grantdateendyear);
                    if (grantdateendmonth == "2")
                    {
                        if (((year % 4 == 0) && (year % 100 != 0)) || (year % 400 == 0))
                            date.AppendLine(grantdateendmonth + "/29");
                        else
                            date.AppendLine(grantdateendmonth + "/28");
                    }
                    switch (grantdateendmonth)
                    {
                        case "1": date.AppendLine(grantdateendmonth + "/31"); break;
                        case "3": date.AppendLine(grantdateendmonth + "/31"); break;
                        case "4": date.AppendLine(grantdateendmonth + "/30"); break;
                        case "5": date.AppendLine(grantdateendmonth + "/31"); break;
                        case "6": date.AppendLine(grantdateendmonth + "/30"); break;
                        case "7": date.AppendLine(grantdateendmonth + "/31"); break;
                        case "8": date.AppendLine(grantdateendmonth + "/31"); break;
                        case "9": date.AppendLine(grantdateendmonth + "/30"); break;
                        case "10": date.AppendLine(grantdateendmonth + "/31"); break;
                        case "11": date.AppendLine(grantdateendmonth + "/30"); break;
                        case "12": date.AppendLine(grantdateendmonth + "/31"); break;

                    }
                    sql.AppendLine(" apply_date <= #" + date.ToString() + "# and");
                    date.Clear();
                }
                if (grantdateendday != "")
                {
                    date.AppendLine(grantdateendyear + "/" + grantdateendmonth + "/" + grantdateendday);
                    sql.AppendLine(" apply_date <= #" + date.ToString() + "# and");
                    date.Clear();
                }
            }
            sql.Remove(sql.Length - 3, 1);
            sql.Remove(sql.Length - 3, 1);
            sql.Remove(sql.Length - 3, 1);
           // gifullname = this.dataGridView1.Rows[dataGridView1.CurrentRow.Index].Cells[dataGridView1.CurrentCell.ColumnIndex].Value.ToString();
          //  cifullname = this.dataGridView1.Rows[dataGridView1.CurrentRow.Index].Cells[dataGridView1.CurrentCell.ColumnIndex].Value.ToString();

            ColImageGrant.Text = "查看";//设置了TEXT的值，
            ColImageGrant.UseColumnTextForButtonValue = true;//设置了这个属性
            ColImageCertificate.Text = "查看";//设置了TEXT的值，
            ColImageCertificate.UseColumnTextForButtonValue = true;//设置了这个属性
            
            dt = Program.GetDataTable(sql.ToString());
           
            dataGridView1.DataSource = dt;
            
            DataRow dr = dt.Rows[0];
            DataRow dr1 = dt.Rows[dataGridView1.CurrentRow.Index];
            gifullname = dr1["grant_inform_image"].ToString();
            cifullname = dr1["certificate_image"].ToString();
            DataGridViewRow dgvr = new DataGridViewRow();
            for (int i = 0; i < dt.Rows.Count; i++)
            {
                dr = dt.Rows[i];
                dgvr = dataGridView1.Rows[i];
                if (dr["grant_inform_image"].ToString().Equals("无"))
                {
                    DataGridViewTextBoxCell dgvbc = new DataGridViewTextBoxCell();
                    dgvbc.Value = "无";
                    dgvr.Cells[12] = dgvbc;
                }
                if (dr["certificate_image"].ToString().Equals("无"))
                {
                    DataGridViewTextBoxCell dgvbc = new DataGridViewTextBoxCell();
                    dgvbc.Value = "无";
                    dgvr.Cells[13] = dgvbc;
                }
            }
            //  dataGridView1.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.AllCells;
            dataGridView1.ColumnHeadersDefaultCellStyle.BackColor = Color.FromArgb(81, 125, 191);
            if (dataGridView1.Rows.Count == 0)              
                MessageBox.Show("没有符合条件的数据");
        }
      
        private void comboBox2_SelectedIndexChanged(object sender, EventArgs e)
        {
            int year = 0;
            comboApplyDateStartDay.Text = "";
            if(comboApplyDateStartYear.Text!="")
                year = Convert.ToInt32(comboApplyDateStartYear.Text);
            if (comboApplyDateStartMonth.Text == "2")
            {
                if (((year % 4 == 0) && (year % 100 != 0)) || (year % 400 == 0))
                {
                    comboApplyDateStartDay.Items.Clear();
                    for (int i = 1; i <= 29; i++)
                        comboApplyDateStartDay.Items.Add(i);
                }
                else
                {
                    comboApplyDateStartDay.Items.Clear();
                    for (int i = 1; i <= 28; i++)
                        comboApplyDateStartDay.Items.Add(i);
                }
            }
            switch (comboApplyDateStartMonth.Text)
            {
                case "1":
                    comboApplyDateStartDay.Items.Clear();
                    for (int i = 1; i <= 31; i++)
                        comboApplyDateStartDay.Items.Add(i);
                    break;
                case "3":
                    comboApplyDateStartDay.Items.Clear();
                    for (int i = 1; i <= 31; i++)
                        comboApplyDateStartDay.Items.Add(i);
                    break;
                case "4":
                    comboApplyDateStartDay.Items.Clear();
                    for (int i = 1; i <= 30; i++)
                        comboApplyDateStartDay.Items.Add(i);
                    break;
                case "5":
                    comboApplyDateStartDay.Items.Clear();
                    for (int i = 1; i <= 31; i++)
                        comboApplyDateStartDay.Items.Add(i);
                    break;
                case "6":
                    comboApplyDateStartDay.Items.Clear();
                    for (int i = 1; i <= 30; i++)
                        comboApplyDateStartDay.Items.Add(i);
                    break;
                case "7":
                    comboApplyDateStartDay.Items.Clear();
                    for (int i = 1; i <= 31; i++)
                        comboApplyDateStartDay.Items.Add(i);
                    break;
                case "8":
                    comboApplyDateStartDay.Items.Clear();
                    for (int i = 1; i <= 31; i++)
                        comboApplyDateStartDay.Items.Add(i);
                    break;
                case "9":
                    comboApplyDateStartDay.Items.Clear();
                    for (int i = 1; i <= 30; i++)
                        comboApplyDateStartDay.Items.Add(i);
                    break;
                case "10":
                    comboApplyDateStartDay.Items.Clear();
                    for (int i = 1; i <= 31; i++)
                        comboApplyDateStartDay.Items.Add(i);
                    break;
                case "11":
                    comboApplyDateStartDay.Items.Clear();
                    for (int i = 1; i <= 30; i++)
                        comboApplyDateStartDay.Items.Add(i);
                    break;
                case "12":
                    comboApplyDateStartDay.Items.Clear();
                    for (int i = 1; i <= 31; i++)
                        comboApplyDateStartDay.Items.Add(i);
                    break;
            }
        }

        private void comboApplyDateStartYear_SelectedIndexChanged(object sender, EventArgs e)
        {
            comboApplyDateStartMonth.Text = "";
            comboApplyDateStartDay.Text = "";
        }

        private void comboApplyDateEndYear_SelectedIndexChanged(object sender, EventArgs e)
        {
            comboApplyDateEndMonth.Text = "";
            comboApplyDateEndDay.Text = "";
        }

        private void comboApplyDateEndMonth_SelectedIndexChanged(object sender, EventArgs e)
        {
            int year = 0;
            comboApplyDateStartDay.Text = "";
            if(comboApplyDateEndYear.Text!="")
               year = Convert.ToInt32(comboApplyDateEndYear.Text);
            if (comboApplyDateEndMonth.Text == "2")
            {
                if (((year % 4 == 0) && (year % 100 != 0)) || (year % 400 == 0))
                {
                    comboApplyDateEndDay.Items.Clear();
                    for (int i = 1; i <= 29; i++)
                        comboApplyDateEndDay.Items.Add(i);
                }
                else
                {
                    comboApplyDateEndDay.Items.Clear();
                    for (int i = 1; i <= 28; i++)
                        comboApplyDateEndDay.Items.Add(i);
                }
            }
            switch (comboApplyDateEndMonth.Text)
            {
                case "1":
                    comboApplyDateEndDay.Items.Clear();
                    for (int i = 1; i <= 31; i++)
                        comboApplyDateEndDay.Items.Add(i);
                    break;
                case "3":
                    comboApplyDateEndDay.Items.Clear();
                    for (int i = 1; i <= 31; i++)
                        comboApplyDateEndDay.Items.Add(i);
                    break;
                case "4":
                    comboApplyDateEndDay.Items.Clear();
                    for (int i = 1; i <= 30; i++)
                        comboApplyDateEndDay.Items.Add(i);
                    break;
                case "5":
                    comboApplyDateEndDay.Items.Clear();
                    for (int i = 1; i <= 31; i++)
                        comboApplyDateEndDay.Items.Add(i);
                    break;
                case "6":
                    comboApplyDateEndDay.Items.Clear();
                    for (int i = 1; i <= 30; i++)
                        comboApplyDateEndDay.Items.Add(i);
                    break;
                case "7":
                    comboApplyDateEndDay.Items.Clear();
                    for (int i = 1; i <= 31; i++)
                        comboApplyDateEndDay.Items.Add(i);
                    break;
                case "8":
                    comboApplyDateEndDay.Items.Clear();
                    for (int i = 1; i <= 31; i++)
                        comboApplyDateEndDay.Items.Add(i);
                    break;
                case "9":
                    comboApplyDateEndDay.Items.Clear();
                    for (int i = 1; i <= 30; i++)
                        comboApplyDateEndDay.Items.Add(i);
                    break;
                case "10":
                    comboApplyDateEndDay.Items.Clear();
                    for (int i = 1; i <= 31; i++)
                        comboApplyDateEndDay.Items.Add(i);
                    break;
                case "11":
                    comboApplyDateEndDay.Items.Clear();
                    for (int i = 1; i <= 30; i++)
                        comboApplyDateEndDay.Items.Add(i);
                    break;
                case "12":
                    comboApplyDateEndDay.Items.Clear();
                    for (int i = 1; i <= 31; i++)
                        comboApplyDateEndDay.Items.Add(i);
                    break;
            }
        }

        private void comboComfirmDateStartYear_SelectedIndexChanged(object sender, EventArgs e)
        {
            comboComfirmDateStartMonth.Text = "";
            comboComfirmDateStartDay.Text = "";
        }

        private void comboComfirmDateEndYear_SelectedIndexChanged(object sender, EventArgs e)
        {
            comboComfirmDateEndMonth.Text = "";
            comboComfirmDateEndDay.Text = "";
        }

        private void comboComfirmDateStartMonth_SelectedIndexChanged(object sender, EventArgs e)
        {
            int year = 0;
            comboComfirmDateStartDay.Text = "";
            if(comboComfirmDateStartYear.Text!="")
               year = Convert.ToInt32(comboComfirmDateStartYear.Text);
            if (comboComfirmDateStartMonth.Text == "2")
            {
                if (((year % 4 == 0) && (year % 100 != 0)) || (year % 400 == 0))
                {
                    comboComfirmDateStartDay.Items.Clear();
                    for (int i = 1; i <= 29; i++)
                        comboComfirmDateStartDay.Items.Add(i);
                }
                else
                {
                    comboComfirmDateStartDay.Items.Clear();
                    for (int i = 1; i <= 28; i++)
                        comboComfirmDateStartDay.Items.Add(i);
                }
            }
            switch (comboComfirmDateStartMonth.Text)
            {
                case "1":
                    comboComfirmDateStartDay.Items.Clear();
                    for (int i = 1; i <= 31; i++)
                        comboComfirmDateStartDay.Items.Add(i);
                    break;
                case "3":
                    comboComfirmDateStartDay.Items.Clear();
                    for (int i = 1; i <= 31; i++)
                        comboComfirmDateStartDay.Items.Add(i);
                    break;
                case "4":
                    comboComfirmDateStartDay.Items.Clear();
                    for (int i = 1; i <= 30; i++)
                        comboComfirmDateStartDay.Items.Add(i);
                    break;
                case "5":
                    comboComfirmDateStartDay.Items.Clear();
                    for (int i = 1; i <= 31; i++)
                        comboComfirmDateStartDay.Items.Add(i);
                    break;
                case "6":
                    comboComfirmDateStartDay.Items.Clear();
                    for (int i = 1; i <= 30; i++)
                        comboComfirmDateStartDay.Items.Add(i);
                    break;
                case "7":
                    comboComfirmDateStartDay.Items.Clear();
                    for (int i = 1; i <= 31; i++)
                        comboComfirmDateStartDay.Items.Add(i);
                    break;
                case "8":
                    comboComfirmDateStartDay.Items.Clear();
                    for (int i = 1; i <= 31; i++)
                        comboComfirmDateStartDay.Items.Add(i);
                    break;
                case "9":
                    comboComfirmDateStartDay.Items.Clear();
                    for (int i = 1; i <= 30; i++)
                        comboComfirmDateStartDay.Items.Add(i);
                    break;
                case "10":
                    comboComfirmDateStartDay.Items.Clear();
                    for (int i = 1; i <= 31; i++)
                        comboComfirmDateStartDay.Items.Add(i);
                    break;
                case "11":
                    comboComfirmDateStartDay.Items.Clear();
                    for (int i = 1; i <= 30; i++)
                        comboComfirmDateStartDay.Items.Add(i);
                    break;
                case "12":
                    comboComfirmDateStartDay.Items.Clear();
                    for (int i = 1; i <= 31; i++)
                        comboComfirmDateStartDay.Items.Add(i);
                    break;
            }
        }
        
        private void comboComfirmDateEndMonth_SelectedIndexChanged(object sender, EventArgs e)
        {
            int year = 0;
            comboComfirmDateEndDay.Text = "";
            if(comboComfirmDateEndYear.Text!="")
                year = Convert.ToInt32(comboComfirmDateEndYear.Text);
            if (comboComfirmDateEndMonth.Text == "2")
            {
                if (((year % 4 == 0) && (year % 100 != 0)) || (year % 400 == 0))
                {
                    comboComfirmDateEndDay.Items.Clear();
                    for (int i = 1; i <= 29; i++)
                        comboComfirmDateEndDay.Items.Add(i);
                }
                else
                {
                    comboComfirmDateEndDay.Items.Clear();
                    for (int i = 1; i <= 28; i++)
                        comboComfirmDateEndDay.Items.Add(i);
                }
            }
            switch (comboComfirmDateEndMonth.Text)
            {
                case "1":
                    comboComfirmDateEndDay.Items.Clear();
                    for (int i = 1; i <= 31; i++)
                        comboComfirmDateEndDay.Items.Add(i);
                    break;
                case "3":
                    comboComfirmDateEndDay.Items.Clear();
                    for (int i = 1; i <= 31; i++)
                        comboComfirmDateEndDay.Items.Add(i);
                    break;
                case "4":
                    comboComfirmDateEndDay.Items.Clear();
                    for (int i = 1; i <= 30; i++)
                        comboComfirmDateEndDay.Items.Add(i);
                    break;
                case "5":
                    comboComfirmDateEndDay.Items.Clear();
                    for (int i = 1; i <= 31; i++)
                        comboComfirmDateEndDay.Items.Add(i);
                    break;
                case "6":
                    comboComfirmDateEndDay.Items.Clear();
                    for (int i = 1; i <= 30; i++)
                        comboComfirmDateEndDay.Items.Add(i);
                    break;
                case "7":
                    comboComfirmDateEndDay.Items.Clear();
                    for (int i = 1; i <= 31; i++)
                        comboComfirmDateEndDay.Items.Add(i);
                    break;
                case "8":
                    comboComfirmDateEndDay.Items.Clear();
                    for (int i = 1; i <= 31; i++)
                        comboComfirmDateEndDay.Items.Add(i);
                    break;
                case "9":
                    comboComfirmDateEndDay.Items.Clear();
                    for (int i = 1; i <= 30; i++)
                        comboComfirmDateEndDay.Items.Add(i);
                    break;
                case "10":
                    comboComfirmDateEndDay.Items.Clear();
                    for (int i = 1; i <= 31; i++)
                        comboComfirmDateEndDay.Items.Add(i);
                    break;
                case "11":
                    comboComfirmDateEndDay.Items.Clear();
                    for (int i = 1; i <= 30; i++)
                        comboComfirmDateEndDay.Items.Add(i);
                    break;
                case "12":
                    comboComfirmDateEndDay.Items.Clear();
                    for (int i = 1; i <= 31; i++)
                        comboComfirmDateEndDay.Items.Add(i);
                    break;
            }
        }

        private void comboGrantDateStartYear_SelectedIndexChanged(object sender, EventArgs e)
        {
            comboGrantDateStartMonth.Text = "";
            comboGrantDateStartDay.Text = "";
        }

        private void comboGrantDateEndYear_SelectedIndexChanged(object sender, EventArgs e)
        {
            comboGrantDateEndMonth.Text = "";
            comboGrantDateEndDay.Text = "";
        }

        private void comboGrantDateStartMonth_SelectedIndexChanged(object sender, EventArgs e)
        {
            int year = 0;
            comboGrantDateStartDay.Text = "";
            if(comboGrantDateStartYear.Text!="")
                year = Convert.ToInt32(comboGrantDateStartYear.Text);
            if (comboGrantDateStartMonth.Text == "2")
            {
                if (((year % 4 == 0) && (year % 100 != 0)) || (year % 400 == 0))
                {
                    comboGrantDateStartDay.Items.Clear();
                    for (int i = 1; i <= 29; i++)
                        comboGrantDateStartDay.Items.Add(i);
                }
                else
                {
                    comboGrantDateStartDay.Items.Clear();
                    for (int i = 1; i <= 28; i++)
                        comboGrantDateStartDay.Items.Add(i);
                }
            }
            switch (comboGrantDateStartMonth.Text)
            {
                case "1":
                    comboGrantDateStartDay.Items.Clear();
                    for (int i = 1; i <= 31; i++)
                        comboGrantDateStartDay.Items.Add(i);
                    break;
                case "3":
                    comboGrantDateStartDay.Items.Clear();
                    for (int i = 1; i <= 31; i++)
                        comboGrantDateStartDay.Items.Add(i);
                    break;
                case "4":
                    comboGrantDateStartDay.Items.Clear();
                    for (int i = 1; i <= 30; i++)
                        comboGrantDateStartDay.Items.Add(i);
                    break;
                case "5":
                    comboGrantDateStartDay.Items.Clear();
                    for (int i = 1; i <= 31; i++)
                        comboGrantDateStartDay.Items.Add(i);
                    break;
                case "6":
                    comboGrantDateStartDay.Items.Clear();
                    for (int i = 1; i <= 30; i++)
                        comboGrantDateStartDay.Items.Add(i);
                    break;
                case "7":
                    comboGrantDateStartDay.Items.Clear();
                    for (int i = 1; i <= 31; i++)
                        comboGrantDateStartDay.Items.Add(i);
                    break;
                case "8":
                    comboGrantDateStartDay.Items.Clear();
                    for (int i = 1; i <= 31; i++)
                        comboGrantDateStartDay.Items.Add(i);
                    break;
                case "9":
                    comboGrantDateStartDay.Items.Clear();
                    for (int i = 1; i <= 30; i++)
                        comboGrantDateStartDay.Items.Add(i);
                    break;
                case "10":
                    comboGrantDateStartDay.Items.Clear();
                    for (int i = 1; i <= 31; i++)
                        comboGrantDateStartDay.Items.Add(i);
                    break;
                case "11":
                    comboGrantDateStartDay.Items.Clear();
                    for (int i = 1; i <= 30; i++)
                        comboGrantDateStartDay.Items.Add(i);
                    break;
                case "12":
                    comboGrantDateStartDay.Items.Clear();
                    for (int i = 1; i <= 31; i++)
                        comboGrantDateStartDay.Items.Add(i);
                    break;
            }
        }

        private void comboGrantDateEndMonth_SelectedIndexChanged(object sender, EventArgs e)
        {
            int year = 0;
            comboGrantDateEndDay.Text = "";
            if(comboGrantDateEndYear.Text!="")
                year = Convert.ToInt32(comboGrantDateEndYear.Text);
            if (comboGrantDateEndMonth.Text == "2")
            {
                if (((year % 4 == 0) && (year % 100 != 0)) || (year % 400 == 0))
                {
                    comboGrantDateEndDay.Items.Clear();
                    for (int i = 1; i <= 29; i++)
                        comboGrantDateEndDay.Items.Add(i);
                }
                else
                {
                    comboGrantDateEndDay.Items.Clear();
                    for (int i = 1; i <= 28; i++)
                        comboGrantDateEndDay.Items.Add(i);
                }
            }
            switch (comboGrantDateEndMonth.Text)
            {
                case "1":
                    comboGrantDateEndDay.Items.Clear();
                    for (int i = 1; i <= 31; i++)
                        comboGrantDateEndDay.Items.Add(i);
                    break;
                case "3":
                    comboGrantDateEndDay.Items.Clear();
                    for (int i = 1; i <= 31; i++)
                        comboGrantDateEndDay.Items.Add(i);
                    break;
                case "4":
                    comboGrantDateEndDay.Items.Clear();
                    for (int i = 1; i <= 30; i++)
                        comboGrantDateEndDay.Items.Add(i);
                    break;
                case "5":
                    comboGrantDateEndDay.Items.Clear();
                    for (int i = 1; i <= 31; i++)
                        comboGrantDateEndDay.Items.Add(i);
                    break;
                case "6":
                    comboGrantDateEndDay.Items.Clear();
                    for (int i = 1; i <= 30; i++)
                        comboGrantDateEndDay.Items.Add(i);
                    break;
                case "7":
                    comboGrantDateEndDay.Items.Clear();
                    for (int i = 1; i <= 31; i++)
                        comboGrantDateEndDay.Items.Add(i);
                    break;
                case "8":
                    comboGrantDateEndDay.Items.Clear();
                    for (int i = 1; i <= 31; i++)
                        comboGrantDateEndDay.Items.Add(i);
                    break;
                case "9":
                    comboGrantDateEndDay.Items.Clear();
                    for (int i = 1; i <= 30; i++)
                        comboGrantDateEndDay.Items.Add(i);
                    break;
                case "10":
                    comboGrantDateEndDay.Items.Clear();
                    for (int i = 1; i <= 31; i++)
                        comboGrantDateEndDay.Items.Add(i);
                    break;
                case "11":
                    comboGrantDateEndDay.Items.Clear();
                    for (int i = 1; i <= 30; i++)
                        comboGrantDateEndDay.Items.Add(i);
                    break;
                case "12":
                    comboGrantDateEndDay.Items.Clear();
                    for (int i = 1; i <= 31; i++)
                        comboGrantDateEndDay.Items.Add(i);
                    break;
            }
        }

        private const int CS_DropSHADOW = 0x20000;
        private const int GCL_STYLE = (-26);
        [DllImport("user32.dll", CharSet = CharSet.Auto)]
        public static extern int SetClassLong(IntPtr hwnd, int nIndex, int dwNewLong);
        [DllImport("user32.dll", CharSet = CharSet.Auto)]
        public static extern int GetClassLong(IntPtr hwnd, int nIndex);

        private void FrmSelect_Load(object sender, EventArgs e)
        {
            this.FormBorderStyle = FormBorderStyle.FixedSingle;
            SetClassLong(this.Handle, GCL_STYLE, GetClassLong(this.Handle, GCL_STYLE) | CS_DropSHADOW);
        }
           
        private Point offset;

        private void panel2_MouseMove(object sender, MouseEventArgs e)
        {
            
            if (MouseButtons.Left != e.Button) return;
            Point cur = MousePosition;
            this.Location = new Point(cur.X - offset.X, cur.Y - offset.Y);
        }

        private void panel2_MouseDown(object sender, MouseEventArgs e)
        {
            if (MouseButtons.Left != e.Button) return;
            Point cur = this.PointToScreen(e.Location);
            offset = new Point(cur.X - this.Left, cur.Y - this.Top);
        }

        private void pictureBox2_Click(object sender, EventArgs e)
        {
            this.WindowState = FormWindowState.Minimized;
        }

        private void pictureBox4_Click(object sender, EventArgs e)
        {
            this.Close();
            this.Dispose();
           // Application.Exit();
             
        }

        private void pictureBox3_Click(object sender, EventArgs e)
        {
            this.WindowState = FormWindowState.Maximized;
            pictureBox3.Visible = false;
            pictureBox5.Visible = true;
        }

        private void pictureBox5_Click(object sender, EventArgs e)
        {
            this.WindowState = FormWindowState.Normal;
            pictureBox3.Visible =true;
            pictureBox5.Visible = false;
        }

        #region 窗口边框
        // 重绘窗口边框
        // 加载窗口时必须使用以下语句才能生效
        // this.FormBorderStyle = FormBorderStyle.FixedSingle;
        protected override CreateParams CreateParams
        {
            get
            {
                const int WS_CAPTION = 0xC00000;
                const int WS_BORDER = 0x800000;
                CreateParams CP = base.CreateParams;
                CP.Style &= ~WS_CAPTION | WS_BORDER;
                return CP;
            }
        }


        #endregion

        private void panel2_DoubleClick(object sender, EventArgs e)
        {
            if (pictureBox3.Visible == true)
            {
                this.WindowState = FormWindowState.Maximized;
                pictureBox3.Visible = false;
                pictureBox5.Visible = true;
            }
            else
            {
                this.WindowState = FormWindowState.Normal;
                pictureBox3.Visible = true;
                pictureBox5.Visible = false;
            }
        }

        private void pictureBox2_MouseEnter(object sender, EventArgs e)
        {
            pictureBox2.BackColor = Color.FromArgb(81, 125, 191);
        }

        private void pictureBox2_MouseLeave(object sender, EventArgs e)
        {
            pictureBox2.BackColor = Color.FromArgb(113, 159, 215);
        }
         
        private void label15_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void label15_MouseEnter(object sender, EventArgs e)
        {
            label15.BackColor = Color.FromArgb(241, 248, 255);
        }

        private void label15_MouseLeave(object sender, EventArgs e)
        {
            label15.BackColor = Color.FromArgb(255, 255,255);
        }

        private void label14_MouseEnter(object sender, EventArgs e)
        {
            label14.BackColor = Color.FromArgb(241, 248, 255);
        }

        private void label14_MouseLeave(object sender, EventArgs e)
        {
            label14.BackColor = Color.FromArgb(255, 255, 255);
        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }
        //首先生成DataGridView的CellMouseDown事件  
        //右键获得单元格的选定
        private void dataGridView1_CellMouseDown(object sender, DataGridViewCellMouseEventArgs e)
        {
            if (e.Button == MouseButtons.Right)
            {
                if (e.RowIndex >= 0)
                {
                    //若行已是选中状态就不再进行设置
                    if (dataGridView1.Rows[e.RowIndex].Selected == false)
                    {
                        dataGridView1.ClearSelection();
                        dataGridView1.Rows[e.RowIndex].Selected = true;
                    }
                    //只选中一行时设置活动单元格
                    if (dataGridView1.SelectedRows.Count == 1)
                    {
                        dataGridView1.CurrentCell = dataGridView1.Rows[e.RowIndex].Cells[e.ColumnIndex];
                    }
                    //弹出操作菜单
                    contextMenuStrip1.Show(MousePosition.X, MousePosition.Y);
                }
            }
        }

        private void 删除ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            string delstr = dataGridView1.Rows[dataGridView1.CurrentRow.Index].Cells[5].Value.ToString();
            string delstrshow = dataGridView1.Rows[dataGridView1.CurrentRow.Index].Cells[0].Value.ToString();
            string sql = string.Format("delete from patent where patent_num = '{0}' or patent_name = '{1}'", delstr, delstrshow);
            bool delresult = Program.ExecuteSql(sql);
            if (delresult)
            {
                btnSearch_Click(null, null);
                MessageBox.Show("已删除《" + delstrshow + "》该项专利申请");
            }
            else
            {
                MessageBox.Show("删除失败");
            }
        }

        private void 修改ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            UpdateClass.upatent_name = dataGridView1.Rows[dataGridView1.CurrentRow.Index].Cells[0].Value.ToString();
            UpdateClass.upatent_type = dataGridView1.Rows[dataGridView1.CurrentRow.Index].Cells[1].Value.ToString();
            UpdateClass.ufirst_designer = dataGridView1.Rows[dataGridView1.CurrentRow.Index].Cells[2].Value.ToString();
            UpdateClass.uinstitute_num = dataGridView1.Rows[dataGridView1.CurrentRow.Index].Cells[3].Value.ToString();
            UpdateClass.uother_designer = dataGridView1.Rows[dataGridView1.CurrentRow.Index].Cells[4].Value.ToString();
            UpdateClass.upatent_num = dataGridView1.Rows[dataGridView1.CurrentRow.Index].Cells[5].Value.ToString();
            UpdateClass.uconfirm_date = dataGridView1.Rows[dataGridView1.CurrentRow.Index].Cells[6].Value.ToString();
            UpdateClass.uapply_date = dataGridView1.Rows[dataGridView1.CurrentRow.Index].Cells[7].Value.ToString();
            UpdateClass.ugrant_date = dataGridView1.Rows[dataGridView1.CurrentRow.Index].Cells[8].Value.ToString();
            UpdateClass.uisgrant = dataGridView1.Rows[dataGridView1.CurrentRow.Index].Cells[9].Value.ToString();
            UpdateClass.uagency = dataGridView1.Rows[dataGridView1.CurrentRow.Index].Cells[10].Value.ToString();
            UpdateClass.ugifullname = gifullname;
            UpdateClass.ucifullname = cifullname;
            FrmAdd updatefrm = new FrmAdd(this);
            updatefrm.Show();
           

        }

        private void 新增ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            FrmAdd f = new FrmAdd();
            f.Show();
        }

        private void label14_Click(object sender, EventArgs e)
        {

        }
       

        private void dataGridView1_CellContentClick_1(object sender, DataGridViewCellEventArgs e)
        {
            // DataGridViewRow dgvr = new DataGridViewRow();
            // dgvr = e.RowIndex.ToString();
            if (e.ColumnIndex == dataGridView1.Columns[12].Index || e.ColumnIndex == dataGridView1.Columns[13].Index)
                
                if (!this.dataGridView1.Rows[dataGridView1.CurrentRow.Index].Cells[dataGridView1.CurrentCell.ColumnIndex].Value.ToString().Equals("无"))
                    try { System.Diagnostics.Process.Start(gifullname); }
                    catch { MessageBox.Show("没有成功插入相关的图片"); }

        }
    }
}
    
    

