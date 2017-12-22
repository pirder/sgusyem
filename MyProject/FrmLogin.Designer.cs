namespace MyProject
{
    partial class FrmLogin
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

        #region Windows 窗体设计器生成的代码

        /// <summary>
        /// 设计器支持所需的方法 - 不要
        /// 使用代码编辑器修改此方法的内容。
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FrmLogin));
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.txtNum = new System.Windows.Forms.TextBox();
            this.txtPassword = new System.Windows.Forms.TextBox();
            this.prompt1 = new System.Windows.Forms.Label();
            this.prompt2 = new System.Windows.Forms.Label();
            this.btnManager = new System.Windows.Forms.RadioButton();
            this.btnUser = new System.Windows.Forms.RadioButton();
            this.btnLogin = new System.Windows.Forms.Button();
            this.btnRegister = new System.Windows.Forms.Button();
            this.prompt3 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(0)))));
            this.label1.Location = new System.Drawing.Point(20, 34);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(413, 29);
            this.label1.TabIndex = 0;
            this.label1.Text = "欢迎使用韶关学院知识产权管理系统";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.ForeColor = System.Drawing.SystemColors.Desktop;
            this.label2.Location = new System.Drawing.Point(88, 100);
            this.label2.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(83, 15);
            this.label2.TabIndex = 1;
            this.label2.Text = "手 机 号：";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.ForeColor = System.Drawing.SystemColors.Desktop;
            this.label3.Location = new System.Drawing.Point(88, 161);
            this.label3.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(84, 15);
            this.label3.TabIndex = 2;
            this.label3.Text = "密    码：";
            // 
            // txtNum
            // 
            this.txtNum.Location = new System.Drawing.Point(195, 96);
            this.txtNum.Margin = new System.Windows.Forms.Padding(4);
            this.txtNum.Name = "txtNum";
            this.txtNum.Size = new System.Drawing.Size(205, 25);
            this.txtNum.TabIndex = 6;
            // 
            // txtPassword
            // 
            this.txtPassword.Location = new System.Drawing.Point(195, 158);
            this.txtPassword.Margin = new System.Windows.Forms.Padding(4);
            this.txtPassword.Name = "txtPassword";
            this.txtPassword.Size = new System.Drawing.Size(205, 25);
            this.txtPassword.TabIndex = 7;
            // 
            // prompt1
            // 
            this.prompt1.AutoSize = true;
            this.prompt1.ForeColor = System.Drawing.Color.Black;
            this.prompt1.Location = new System.Drawing.Point(275, 126);
            this.prompt1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.prompt1.Name = "prompt1";
            this.prompt1.Size = new System.Drawing.Size(0, 15);
            this.prompt1.TabIndex = 9;
            // 
            // prompt2
            // 
            this.prompt2.AutoSize = true;
            this.prompt2.ForeColor = System.Drawing.Color.Black;
            this.prompt2.Location = new System.Drawing.Point(275, 188);
            this.prompt2.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.prompt2.Name = "prompt2";
            this.prompt2.Size = new System.Drawing.Size(0, 15);
            this.prompt2.TabIndex = 10;
            // 
            // btnManager
            // 
            this.btnManager.AutoSize = true;
            this.btnManager.Checked = true;
            this.btnManager.Location = new System.Drawing.Point(109, 244);
            this.btnManager.Margin = new System.Windows.Forms.Padding(4);
            this.btnManager.Name = "btnManager";
            this.btnManager.Size = new System.Drawing.Size(103, 19);
            this.btnManager.TabIndex = 13;
            this.btnManager.TabStop = true;
            this.btnManager.Text = "超级管理员";
            this.btnManager.UseVisualStyleBackColor = true;
            // 
            // btnUser
            // 
            this.btnUser.AutoSize = true;
            this.btnUser.Location = new System.Drawing.Point(277, 244);
            this.btnUser.Margin = new System.Windows.Forms.Padding(4);
            this.btnUser.Name = "btnUser";
            this.btnUser.Size = new System.Drawing.Size(88, 19);
            this.btnUser.TabIndex = 14;
            this.btnUser.Text = "一般用户";
            this.btnUser.UseVisualStyleBackColor = true;
            // 
            // btnLogin
            // 
            this.btnLogin.Location = new System.Drawing.Point(109, 332);
            this.btnLogin.Margin = new System.Windows.Forms.Padding(4);
            this.btnLogin.Name = "btnLogin";
            this.btnLogin.Size = new System.Drawing.Size(100, 35);
            this.btnLogin.TabIndex = 15;
            this.btnLogin.Text = "登录";
            this.btnLogin.UseVisualStyleBackColor = true;
            this.btnLogin.Click += new System.EventHandler(this.btnLogin_Click);
            // 
            // btnRegister
            // 
            this.btnRegister.Location = new System.Drawing.Point(277, 332);
            this.btnRegister.Margin = new System.Windows.Forms.Padding(4);
            this.btnRegister.Name = "btnRegister";
            this.btnRegister.Size = new System.Drawing.Size(100, 35);
            this.btnRegister.TabIndex = 16;
            this.btnRegister.Text = "注册";
            this.btnRegister.UseVisualStyleBackColor = true;
            this.btnRegister.Click += new System.EventHandler(this.btnRegister_Click);
            // 
            // prompt3
            // 
            this.prompt3.AutoSize = true;
            this.prompt3.Location = new System.Drawing.Point(109, 280);
            this.prompt3.Name = "prompt3";
            this.prompt3.Size = new System.Drawing.Size(0, 15);
            this.prompt3.TabIndex = 17;
            // 
            // FrmLogin
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(513, 398);
            this.Controls.Add(this.prompt3);
            this.Controls.Add(this.btnRegister);
            this.Controls.Add(this.btnLogin);
            this.Controls.Add(this.btnUser);
            this.Controls.Add(this.btnManager);
            this.Controls.Add(this.prompt2);
            this.Controls.Add(this.prompt1);
            this.Controls.Add(this.txtPassword);
            this.Controls.Add(this.txtNum);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "FrmLogin";
            this.Text = "韶关学院知识产权管理系统";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox txtNum;
        private System.Windows.Forms.TextBox txtPassword;
        private System.Windows.Forms.Label prompt1;
        private System.Windows.Forms.Label prompt2;
        private System.Windows.Forms.RadioButton btnManager;
        private System.Windows.Forms.RadioButton btnUser;
        private System.Windows.Forms.Button btnLogin;
        private System.Windows.Forms.Button btnRegister;
        private System.Windows.Forms.Label prompt3;
    }


}