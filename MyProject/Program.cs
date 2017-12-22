using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.OleDb;
using System.Data;


namespace MyProject
{
    static class Program
    {
        /// <summary>
        /// 应用程序的主入口点。
        /// </summary>
        [STAThread]
        static void Main()
        {
            //界面汉化
            System.Threading.Thread.CurrentThread.CurrentUICulture = new System.Globalization.CultureInfo("zh-CN");

            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            // FrmSelect frmSelect = new FrmSelect();
            // Sunisoft.IrisSkin.SkinEngine skin = new Sunisoft.IrisSkin.SkinEngine((System.ComponentModel.Component)frmSelect);
            // skin.SkinFile = "***.ssk"; // 指定皮肤文件
            // skin.TitleFont = new System.Drawing.Font("微软雅黑", 10F);
            //  Application.Run(new FrmSelect());
            Application.Run(new FrmLogin());
        }


        public static bool SearchSql(string sql)
        {
            bool loginResult = false;
            try
            {              
                OleDbConnection conn = new OleDbConnection();
                //创建OleDb连接对象
                conn.ConnectionString = @"Provider=Microsoft.ACE.OLEDB.12.0;Data Source=patent.accdb;Persist Security Info=False";
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
            }
            catch
            {
                MessageBox.Show("数据库连接错误");
            }
            return loginResult;
        }

         public static bool ExecuteSql(string sql)
        {
            bool loginResult = false;
            try
            {

                OleDbConnection conn = new OleDbConnection();
                //创建OleDb连接对象
                conn.ConnectionString = @"Provider=Microsoft.ACE.OLEDB.12.0;Data Source=patent.accdb;Persist Security Info=False";
                //将生成的字符串传入
                conn.Open();
                //打开数据库
                OleDbCommand mycmd = new OleDbCommand(sql, conn);
                //创建sql命令对象
                int result = (int)mycmd.ExecuteNonQuery();
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
            }
            catch
            {
                MessageBox.Show("数据库连接错误");
            }
            return loginResult;           
        }

        public static DataTable GetDataTable(string sql)
        {
            DataSet ds = new DataSet();
            try
            {
                OleDbConnection conn = new OleDbConnection();
                //创建OleDb连接对象
                conn.ConnectionString = @"Provider=Microsoft.ACE.OLEDB.12.0;Data Source=patent.accdb;Persist Security Info=False";
                //将生成的字符串传入
                conn.Open();
                //打开数据库
                OleDbDataAdapter da = new OleDbDataAdapter(sql, conn);
                da.Fill(ds);
                conn.Close();
            }
            catch
            {
                MessageBox.Show("数据库连接错误");
            }
            return ds.Tables[0];
        }

    }
}
