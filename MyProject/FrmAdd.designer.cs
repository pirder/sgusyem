using System;

namespace MyProject
{
    partial class FrmAdd
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FrmAdd));
            this.label1 = new System.Windows.Forms.Label();
            this.patent_name = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.first_designer = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.patent_num = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.openFileDialog1 = new System.Windows.Forms.OpenFileDialog();
            this.comboBox1 = new System.Windows.Forms.ComboBox();
            this.database1DataSet = new MyProject.Database1DataSet();
            this.instituteBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.instituteTableAdapter = new MyProject.Database1DataSetTableAdapters.instituteTableAdapter();
            this.instituteBindingSource1 = new System.Windows.Forms.BindingSource(this.components);
            this.label10 = new System.Windows.Forms.Label();
            this.other_designer = new System.Windows.Forms.TextBox();
            this.label11 = new System.Windows.Forms.Label();
            this.label12 = new System.Windows.Forms.Label();
            this.comboBox2 = new System.Windows.Forms.ComboBox();
            this.addbtn = new System.Windows.Forms.Button();
            this.apply_date = new System.Windows.Forms.DateTimePicker();
            this.grant_date = new System.Windows.Forms.DateTimePicker();
            this.confirm_date = new System.Windows.Forms.DateTimePicker();
            this.label13 = new System.Windows.Forms.Label();
            this.picture1 = new System.Windows.Forms.Button();
            this.button3 = new System.Windows.Forms.Button();
            this.button1 = new System.Windows.Forms.Button();
            this.button4 = new System.Windows.Forms.Button();
            this.updatebtn = new System.Windows.Forms.Button();
            this.appckb = new System.Windows.Forms.CheckBox();
            this.grantackb = new System.Windows.Forms.CheckBox();
            this.patentckb = new System.Windows.Forms.CheckBox();
            this.patent_type = new System.Windows.Forms.ComboBox();
            this.agency = new System.Windows.Forms.ComboBox();
            ((System.ComponentModel.ISupportInitialize)(this.database1DataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.instituteBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.instituteBindingSource1)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(23, 23);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(82, 15);
            this.label1.TabIndex = 0;
            this.label1.Text = "专利名称：";
            this.label1.Click += new System.EventHandler(this.label1_Click);
            // 
            // patent_name
            // 
            this.patent_name.Location = new System.Drawing.Point(99, 19);
            this.patent_name.Name = "patent_name";
            this.patent_name.Size = new System.Drawing.Size(159, 25);
            this.patent_name.TabIndex = 1;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(23, 65);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(83, 15);
            this.label2.TabIndex = 0;
            this.label2.Text = "类　  别：";
            this.label2.Click += new System.EventHandler(this.label1_Click);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(35, 114);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(67, 15);
            this.label3.TabIndex = 0;
            this.label3.Text = "设计人：";
            this.label3.Click += new System.EventHandler(this.label1_Click);
            // 
            // first_designer
            // 
            this.first_designer.Location = new System.Drawing.Point(99, 111);
            this.first_designer.Name = "first_designer";
            this.first_designer.Size = new System.Drawing.Size(159, 25);
            this.first_designer.TabIndex = 1;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(32, 200);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(67, 15);
            this.label4.TabIndex = 0;
            this.label4.Text = "专利号：";
            this.label4.Click += new System.EventHandler(this.label1_Click);
            // 
            // patent_num
            // 
            this.patent_num.Location = new System.Drawing.Point(98, 197);
            this.patent_num.Name = "patent_num";
            this.patent_num.Size = new System.Drawing.Size(159, 25);
            this.patent_num.TabIndex = 1;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(18, 250);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(82, 15);
            this.label5.TabIndex = 0;
            this.label5.Text = "申请日期：";
            this.label5.Click += new System.EventHandler(this.label1_Click);
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(18, 302);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(82, 15);
            this.label6.TabIndex = 0;
            this.label6.Text = "授权日期：";
            this.label6.Click += new System.EventHandler(this.label1_Click);
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(406, 22);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(82, 15);
            this.label7.TabIndex = 0;
            this.label7.Text = "代办机构：";
            this.label7.Click += new System.EventHandler(this.label1_Click);
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(409, 65);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(76, 15);
            this.label8.TabIndex = 0;
            this.label8.Text = "学   院：";
            this.label8.Click += new System.EventHandler(this.label1_Click);
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(361, 194);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(127, 15);
            this.label9.TabIndex = 0;
            this.label9.Text = "受理通知书图片：";
            this.label9.Click += new System.EventHandler(this.label1_Click);
            // 
            // openFileDialog1
            // 
            this.openFileDialog1.FileName = "openFileDialog1";
            // 
            // comboBox1
            // 
            this.comboBox1.FormattingEnabled = true;
            this.comboBox1.Location = new System.Drawing.Point(491, 65);
            this.comboBox1.Name = "comboBox1";
            this.comboBox1.Size = new System.Drawing.Size(159, 23);
            this.comboBox1.TabIndex = 4;
            this.comboBox1.Text = "请选择学院";
            // 
            // database1DataSet
            // 
            this.database1DataSet.DataSetName = "Database1DataSet";
            this.database1DataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // instituteBindingSource
            // 
            this.instituteBindingSource.DataMember = "institute";
            this.instituteBindingSource.DataSource = this.database1DataSet;
            // 
            // instituteTableAdapter
            // 
            this.instituteTableAdapter.ClearBeforeFill = true;
            // 
            // instituteBindingSource1
            // 
            this.instituteBindingSource1.DataMember = "institute";
            this.instituteBindingSource1.DataSource = this.database1DataSet;
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Location = new System.Drawing.Point(4, 158);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(97, 15);
            this.label10.TabIndex = 0;
            this.label10.Text = "其他设计人：";
            this.label10.Click += new System.EventHandler(this.label1_Click);
            // 
            // other_designer
            // 
            this.other_designer.Location = new System.Drawing.Point(99, 155);
            this.other_designer.Name = "other_designer";
            this.other_designer.Size = new System.Drawing.Size(159, 25);
            this.other_designer.TabIndex = 1;
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Location = new System.Drawing.Point(17, 350);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(82, 15);
            this.label11.TabIndex = 0;
            this.label11.Text = "备案日期：";
            this.label11.Click += new System.EventHandler(this.label1_Click);
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.Location = new System.Drawing.Point(405, 116);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(82, 15);
            this.label12.TabIndex = 0;
            this.label12.Text = "是否授权：";
            this.label12.Click += new System.EventHandler(this.label1_Click);
            // 
            // comboBox2
            // 
            this.comboBox2.FormattingEnabled = true;
            this.comboBox2.Items.AddRange(new object[] {
            "是",
            "否"});
            this.comboBox2.Location = new System.Drawing.Point(491, 108);
            this.comboBox2.Name = "comboBox2";
            this.comboBox2.Size = new System.Drawing.Size(159, 23);
            this.comboBox2.TabIndex = 4;
            // 
            // addbtn
            // 
            this.addbtn.Location = new System.Drawing.Point(323, 326);
            this.addbtn.Name = "addbtn";
            this.addbtn.Size = new System.Drawing.Size(198, 47);
            this.addbtn.TabIndex = 5;
            this.addbtn.Text = "上传";
            this.addbtn.UseVisualStyleBackColor = true;
            this.addbtn.Click += new System.EventHandler(this.button2_Click);
            // 
            // apply_date
            // 
            this.apply_date.Location = new System.Drawing.Point(99, 243);
            this.apply_date.Name = "apply_date";
            this.apply_date.Size = new System.Drawing.Size(160, 25);
            this.apply_date.TabIndex = 6;
            this.apply_date.ValueChanged += new System.EventHandler(this.apply_date_ValueChanged);
            // 
            // grant_date
            // 
            this.grant_date.Location = new System.Drawing.Point(97, 295);
            this.grant_date.Name = "grant_date";
            this.grant_date.Size = new System.Drawing.Size(160, 25);
            this.grant_date.TabIndex = 6;
            // 
            // confirm_date
            // 
            this.confirm_date.Location = new System.Drawing.Point(97, 348);
            this.confirm_date.Name = "confirm_date";
            this.confirm_date.Size = new System.Drawing.Size(160, 25);
            this.confirm_date.TabIndex = 6;
            // 
            // label13
            // 
            this.label13.AutoSize = true;
            this.label13.Location = new System.Drawing.Point(379, 245);
            this.label13.Name = "label13";
            this.label13.Size = new System.Drawing.Size(106, 15);
            this.label13.TabIndex = 0;
            this.label13.Text = "证 书 图 片：";
            this.label13.Click += new System.EventHandler(this.label1_Click);
            // 
            // picture1
            // 
            this.picture1.Location = new System.Drawing.Point(491, 185);
            this.picture1.Name = "picture1";
            this.picture1.Size = new System.Drawing.Size(75, 32);
            this.picture1.TabIndex = 7;
            this.picture1.Text = "添加";
            this.picture1.UseVisualStyleBackColor = true;
            this.picture1.Click += new System.EventHandler(this.button3_Click);
            // 
            // button3
            // 
            this.button3.Location = new System.Drawing.Point(491, 238);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(75, 30);
            this.button3.TabIndex = 8;
            this.button3.Text = "添加";
            this.button3.UseVisualStyleBackColor = true;
            this.button3.Click += new System.EventHandler(this.button3_Click_1);
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(590, 185);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(86, 32);
            this.button1.TabIndex = 9;
            this.button1.Text = "查询图片";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click_1);
            // 
            // button4
            // 
            this.button4.Location = new System.Drawing.Point(590, 239);
            this.button4.Name = "button4";
            this.button4.Size = new System.Drawing.Size(86, 29);
            this.button4.TabIndex = 10;
            this.button4.Text = "查询图片";
            this.button4.UseVisualStyleBackColor = true;
            this.button4.Click += new System.EventHandler(this.button4_Click);
            // 
            // updatebtn
            // 
            this.updatebtn.Location = new System.Drawing.Point(527, 327);
            this.updatebtn.Name = "updatebtn";
            this.updatebtn.Size = new System.Drawing.Size(194, 46);
            this.updatebtn.TabIndex = 11;
            this.updatebtn.Text = "提交修改";
            this.updatebtn.UseVisualStyleBackColor = true;
            this.updatebtn.Click += new System.EventHandler(this.updatebtn_Click);
            // 
            // appckb
            // 
            this.appckb.AutoSize = true;
            this.appckb.Location = new System.Drawing.Point(265, 249);
            this.appckb.Name = "appckb";
            this.appckb.Size = new System.Drawing.Size(44, 19);
            this.appckb.TabIndex = 12;
            this.appckb.Text = "无";
            this.appckb.UseVisualStyleBackColor = true;
            this.appckb.CheckedChanged += new System.EventHandler(this.appckb_CheckedChanged);
            // 
            // grantackb
            // 
            this.grantackb.AutoSize = true;
            this.grantackb.Location = new System.Drawing.Point(265, 298);
            this.grantackb.Name = "grantackb";
            this.grantackb.Size = new System.Drawing.Size(44, 19);
            this.grantackb.TabIndex = 12;
            this.grantackb.Text = "无";
            this.grantackb.UseVisualStyleBackColor = true;
            this.grantackb.CheckedChanged += new System.EventHandler(this.grantackb_CheckedChanged);
            // 
            // patentckb
            // 
            this.patentckb.AutoSize = true;
            this.patentckb.Location = new System.Drawing.Point(265, 349);
            this.patentckb.Name = "patentckb";
            this.patentckb.Size = new System.Drawing.Size(44, 19);
            this.patentckb.TabIndex = 12;
            this.patentckb.Text = "无";
            this.patentckb.UseVisualStyleBackColor = true;
            this.patentckb.CheckedChanged += new System.EventHandler(this.patentckb_CheckedChanged);
            // 
            // patent_type
            // 
            this.patent_type.FormattingEnabled = true;
            this.patent_type.Items.AddRange(new object[] {
            "著作权",
            "发明专利",
            "实用新型",
            "发明",
            "外观专利",
            "软件著作"});
            this.patent_type.Location = new System.Drawing.Point(99, 64);
            this.patent_type.Name = "patent_type";
            this.patent_type.Size = new System.Drawing.Size(160, 23);
            this.patent_type.TabIndex = 13;
            // 
            // agency
            // 
            this.agency.FormattingEnabled = true;
            this.agency.Items.AddRange(new object[] {
            "国家知识产权局",
            "韶关市雷门专利事务所",
            "广州新诺专利事务所"});
            this.agency.Location = new System.Drawing.Point(491, 20);
            this.agency.Name = "agency";
            this.agency.Size = new System.Drawing.Size(159, 23);
            this.agency.TabIndex = 14;
            // 
            // FrmAdd
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(757, 410);
            this.Controls.Add(this.agency);
            this.Controls.Add(this.patent_type);
            this.Controls.Add(this.patentckb);
            this.Controls.Add(this.grantackb);
            this.Controls.Add(this.appckb);
            this.Controls.Add(this.updatebtn);
            this.Controls.Add(this.button4);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.button3);
            this.Controls.Add(this.picture1);
            this.Controls.Add(this.confirm_date);
            this.Controls.Add(this.grant_date);
            this.Controls.Add(this.apply_date);
            this.Controls.Add(this.addbtn);
            this.Controls.Add(this.comboBox2);
            this.Controls.Add(this.comboBox1);
            this.Controls.Add(this.label11);
            this.Controls.Add(this.patent_num);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.other_designer);
            this.Controls.Add(this.first_designer);
            this.Controls.Add(this.label10);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label13);
            this.Controls.Add(this.label9);
            this.Controls.Add(this.label12);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.patent_name);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.label1);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "FrmAdd";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "新增专利";
            ((System.ComponentModel.ISupportInitialize)(this.database1DataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.instituteBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.instituteBindingSource1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        private void button1_Click(object sender, EventArgs e)
        {
            throw new NotImplementedException();
        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            throw new NotImplementedException();
        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox patent_name;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox first_designer;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox patent_num;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.OpenFileDialog openFileDialog1;
        private System.Windows.Forms.ComboBox comboBox1;
        private Database1DataSet database1DataSet;
        private System.Windows.Forms.BindingSource instituteBindingSource;
        private Database1DataSetTableAdapters.instituteTableAdapter instituteTableAdapter;
        private System.Windows.Forms.BindingSource instituteBindingSource1;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.TextBox other_designer;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.ComboBox comboBox2;
        private System.Windows.Forms.Button addbtn;
        private System.Windows.Forms.DateTimePicker apply_date;
        private System.Windows.Forms.DateTimePicker grant_date;
        private System.Windows.Forms.DateTimePicker confirm_date;
        private System.Windows.Forms.Label label13;
        private System.Windows.Forms.Button picture1;
        private System.Windows.Forms.Button button3;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button button4;
        private System.Windows.Forms.Button updatebtn;
        private System.Windows.Forms.CheckBox appckb;
        private System.Windows.Forms.CheckBox grantackb;
        private System.Windows.Forms.CheckBox patentckb;
        private System.Windows.Forms.ComboBox patent_type;
        private System.Windows.Forms.ComboBox agency;

        public EventHandler FrmAdd_Load { get; private set; }
    }
}