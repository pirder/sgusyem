using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.OleDb;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Configuration;

namespace MyProject
{
    public partial class FrmAdd : Form
    {
        FrmSelect f1;
        public FrmAdd()
        {
            InitializeComponent();
            addbtn.Visible = true;
            updatebtn.Visible = false;
            bindCbox();
        }
        public FrmAdd(FrmSelect f1)
        {
            this.f1 = f1;
            InitializeComponent();
            
            addbtn.Visible = false;
            updatebtn.Visible = true;
            this.Text = "修改专利";
            bindCbox();
            patent_name.Text = UpdateClass.upatent_name;
            patent_type.Text = UpdateClass.upatent_type;
            first_designer.Text = UpdateClass.ufirst_designer;
            patent_num.Text = UpdateClass.upatent_num;
            if (UpdateClass.uconfirm_date != "")
                confirm_date.Value = Convert.ToDateTime(UpdateClass.uconfirm_date);
            else patentckb.Checked = true;

            if (UpdateClass.uapply_date != "")
                apply_date.Value = Convert.ToDateTime(UpdateClass.uapply_date);
            else appckb.Checked = true;

            if (UpdateClass.ugrant_date != "")
                grant_date.Value = Convert.ToDateTime(UpdateClass.ugrant_date);
            else grantackb.Checked = true;
            other_designer.Text = UpdateClass.uother_designer;
            agency.Text = UpdateClass.uagency;
            comboBox2.Text = UpdateClass.uisgrant;
            comboBox1.Text = UpdateClass.uinstitute_num;
            // id + 1,

            giFullname = UpdateClass.ugifullname;
            ciFullname = UpdateClass.ucifullname;
        }
        //受理通知书图片
        string grant_inform_image = "无";
        //证书图片
        string certificate_image = "无";
        private void label1_Click(object sender, EventArgs e)
        {

        }
        private static bool ExecuteSql(string sql)
        {
            bool ReturnResult = false;
            OleDbConnection conn = new OleDbConnection();
            //创建OleDb连接对象
            conn.ConnectionString = @"Provider=Microsoft.ACE.OLEDB.12.0;Data Source=patent.accdb;Persist Security Info=False";
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

        string giFullname = "无";//图片地址
        string ciFullname = "无";

        public static byte[] SavaImage(OpenFileDialog OpenF)//图片封装
        {
            string strImage = OpenF.FileName;
            FileStream fs = new FileStream(strImage, FileMode.Open, FileAccess.Read);
            BinaryReader br = new BinaryReader(fs);
            byte[] imageByte = br.ReadBytes((int)fs.Length);
            // string sql = "insert into patent(patent_name,patent_type,first_designer,institute,other_designer,patent_num,confirm_date,apply_date,grant_date,isgrant,agency,grant_inform_image,certificate_image) values('{0}','{1}','{2}','{3}','{4}','{5}','{6}','{7}','{8}','{9}','{10}','{11}','{12}')",
            return imageByte;
        }


      

        private void bindCbox()
        {
           // certificate_image.Visible = false;
          //  grant_inform_image.Visible = false;
            try
            {
                OleDbConnection con = new OleDbConnection(@"Provider=Microsoft.ACE.OLEDB.12.0;Data Source=patent.accdb;Persist Security Info=False");//创建数据库联接，这用利用的access数据库
                con.Open();
                OleDbCommand command = con.CreateCommand();
                OleDbCommand command1 = con.CreateCommand();
                command.CommandText = "select institute_name from institute";//创建查询语句
                command1.CommandText = "select institute_num from institute";
                OleDbDataReader reader = command.ExecuteReader();
                OleDbDataReader reader1 = command1.ExecuteReader();
                while (reader.Read())
                {
                    this.comboBox1.Items.AddRange(new object[] { reader["institute_name"] });//邦定数据        
                 }
                reader.Close();
                con.Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.ToString());
            }


        }
       
    private void button2_Click(object sender, EventArgs e)
        {
            if (comboBox1.SelectedIndex == -1)
            {
                MessageBox.Show("你未选择对应的学院");
                return;
            }
            string ad = "'" + apply_date.Value.Year.ToString() + "/" + apply_date.Value.Month.ToString() + "/" + apply_date.Value.Day.ToString() + "'";
            string gd = "'" + grant_date.Value.Year.ToString() + "/" + grant_date.Value.Month.ToString() + "/" + grant_date.Value.Day.ToString() + "'";
            string cd = "'" + confirm_date.Value.Year.ToString() + "/" + confirm_date.Value.Month.ToString() + "/" + confirm_date.Value.Day.ToString() + "'";
            int id = comboBox1.SelectedIndex;
            if (appckb.Checked == true)
                ad = "NULL";
            if (grantackb.Checked == true)
                gd = "NULL";
            if (patentckb.Checked == true)
                cd = "NULL";
            if (giFullname != "无")
            {
                File.Copy(giFullname, grant_inform_image,true);
            }
            else {
                grant_inform_image = "无";
            }
            if (ciFullname != "无")
            {
                File.Copy(ciFullname, certificate_image,true);
            }
            else {
                certificate_image = "无";
            }
            string sql = string.Format("insert into patent(patent_name,patent_type,first_designer,patent_num,confirm_date,apply_date,grant_date,other_designer,agency,institute_num,grant_inform_image,certificate_image,isgrant) values('{0}','{1}','{2}','{3}',{4},{5},{6},'{7}','{8}','{9}','{10}','{11}','{12}')", patent_name.Text,patent_type.Text,first_designer.Text,patent_num.Text, cd, ad, gd,other_designer.Text,agency.Text,id + 1,grant_inform_image,certificate_image,comboBox2.SelectedIndex.ToString());
            bool result = ExecuteSql(sql);
            if (result)
            {
                MessageBox.Show("插入成功");
            }
            else
            {
                MessageBox.Show("插入失败");
            }
         grant_inform_image = "无";
         certificate_image  = "无";
         giFullname = "无";//图片地址
         ciFullname = "无";
        }

        private void apply_date_ValueChanged(object sender, EventArgs e)
        {

        }
        private void DoWork()
        {
            String dir = "D:\\ABC";
            //创建备份文件夹，按时间命名  
            String bakDir = dir + "\\bak\\" + DateTime.Now.ToString("yyyy-MM-dd");

            if (Directory.Exists(bakDir) == false)
            {
                Directory.CreateDirectory(bakDir);
            }
            string[] files = Directory.GetFiles(dir);
            if (files.Length != 0)
            {
                foreach (string file in files)
                {
                    FileInfo fileinfo = new FileInfo(file);
                    try
                    {
                        string fileName = file.Replace(dir, "");
                        //备份文件
                        File.Copy(file, Path.Combine(bakDir, fileName));
                        // File.Delete(file);
                    }
                    catch
                    {

                    }
                }
            }
        }
        
        private string addpic(string picturetype)
        {
            string path2;
            openFileDialog1.ShowDialog();
            string FullName = openFileDialog1.FileName;//获取word物理地址
            FileInfo fi = new FileInfo(FullName);
            string name = fi.Name;//获取word名称
            string type = fi.Extension;//获取word类型
            if (type == ".doc" || type == ".docx")
            {
                
                string str = Application.StartupPath;
                path2 = str.Substring(0, str.Length - 10) + "\\"+picturetype+"\\"+""+patent_name.Text+""+picturetype+".doc";
                //   File.Copy(FullName, path2, true);
                if (picturetype == "grant_inform_image")
                    giFullname = FullName;
                if (picturetype == "certificate_image")
                    ciFullname = FullName;
            }
            else {
                MessageBox.Show("请选择正确的文件类型");
                path2 = "无";
            }
            return path2;
        }

            private void button3_Click(object sender, EventArgs e)
            {
            string str = "grant_inform_image";
                 grant_inform_image = addpic(str);
            }

        private void button3_Click_1(object sender, EventArgs e)
        {
            string str = "certificate_image";
            certificate_image = addpic(str);
        }

        private void button1_Click_1(object sender, EventArgs e)
        {
            try { System.Diagnostics.Process.Start(giFullname); }
            catch { MessageBox.Show("没有成功插入相关的图片"); }
            
        }

        private void button4_Click(object sender, EventArgs e)
        {
            try { System.Diagnostics.Process.Start(ciFullname); }
            catch { MessageBox.Show("没有成功插入相关的图片"); }
        }

        private void updatebtn_Click(object sender, EventArgs e)
        {
            if (comboBox1.SelectedIndex == -1)
            {
                MessageBox.Show("你未选择对应的学院");
                return;
            }
            string ad = "'"+apply_date.Value.Year.ToString() + "/" + apply_date.Value.Month.ToString() + "/" + apply_date.Value.Day.ToString()+"'";
            string gd = "'"+grant_date.Value.Year.ToString() + "/" + grant_date.Value.Month.ToString() + "/" + grant_date.Value.Day.ToString()+"'";
            string cd = "'"+confirm_date.Value.Year.ToString() + "/" + confirm_date.Value.Month.ToString() + "/" + confirm_date.Value.Day.ToString()+"'";
            int id = comboBox1.SelectedIndex;
            if (appckb.Checked == true)
                ad = "NULL";
            if (grantackb.Checked == true)
                gd = "NULL";
            if (patentckb.Checked == true)
                cd = "NULL";

            if (giFullname != "无" && grant_inform_image!= "无")
            {
                File.Copy(giFullname, grant_inform_image, true);
            }
            else
            {
                grant_inform_image = "无";
            }
            if (ciFullname != "无" && certificate_image!= "无")
            {
                File.Copy(ciFullname, certificate_image, true);
            }
            else
            {
                certificate_image = "无";
            }
            string sql = string.Format("update patent set patent_name='{0}',patent_type='{1}',first_designer='{2}',patent_num='{3}',confirm_date={4},apply_date={5},grant_date={6},other_designer='{7}',agency='{8}',institute_num='{9}',grant_inform_image='{10}',certificate_image='{11}',isgrant='{12}' where patent_name='" + patent_name.Text + "';", patent_name.Text, patent_type.Text, first_designer.Text, patent_num.Text, cd, ad, gd, other_designer.Text, agency.Text, id + 1, grant_inform_image, certificate_image, comboBox2.Text.ToString());
            //注意合并后两者数据库设计命名不符
            bool result = ExecuteSql(sql);
            if (result)
            {
                MessageBox.Show("修改成功");
            }
            else
            {
                MessageBox.Show("修改失败");
            }
            grant_inform_image = "无";
            certificate_image = "无";
            giFullname = "无";//图片地址
            ciFullname = "无";

            this.Close();

        }

        private void appckb_CheckedChanged(object sender, EventArgs e)
        {
            if (appckb.Checked == true) apply_date.Visible = false;
            else  apply_date.Visible = true;
        }

        private void grantackb_CheckedChanged(object sender, EventArgs e)
        {
            if (grantackb.Checked == true) grant_date.Visible = false;
           else grant_date.Visible = true;
        }

        private void patentckb_CheckedChanged(object sender, EventArgs e)
        {
            if (patentckb.Checked == true) confirm_date.Visible = false;
            else confirm_date.Visible = true;
        }
    }
    }
        


