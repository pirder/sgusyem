namespace MyProject
{
    partial class frmusersupdate
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
            this.promptRegisterNum = new System.Windows.Forms.Label();
            this.promptRegisterPassword = new System.Windows.Forms.Label();
            this.promptRegisterName = new System.Windows.Forms.Label();
            this.btnUpdateComfirm = new System.Windows.Forms.Button();
            this.txtUpdateNum = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.txtUpdatePassword = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.txtUpdateName = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // promptRegisterNum
            // 
            this.promptRegisterNum.AutoSize = true;
            this.promptRegisterNum.Location = new System.Drawing.Point(107, 237);
            this.promptRegisterNum.Name = "promptRegisterNum";
            this.promptRegisterNum.Size = new System.Drawing.Size(0, 15);
            this.promptRegisterNum.TabIndex = 19;
            // 
            // promptRegisterPassword
            // 
            this.promptRegisterPassword.AutoSize = true;
            this.promptRegisterPassword.Location = new System.Drawing.Point(104, 154);
            this.promptRegisterPassword.Name = "promptRegisterPassword";
            this.promptRegisterPassword.Size = new System.Drawing.Size(0, 15);
            this.promptRegisterPassword.TabIndex = 18;
            // 
            // promptRegisterName
            // 
            this.promptRegisterName.AutoSize = true;
            this.promptRegisterName.Location = new System.Drawing.Point(104, 75);
            this.promptRegisterName.Name = "promptRegisterName";
            this.promptRegisterName.Size = new System.Drawing.Size(0, 15);
            this.promptRegisterName.TabIndex = 17;
            // 
            // btnUpdateComfirm
            // 
            this.btnUpdateComfirm.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.btnUpdateComfirm.Font = new System.Drawing.Font("宋体", 13F);
            this.btnUpdateComfirm.Location = new System.Drawing.Point(110, 298);
            this.btnUpdateComfirm.Name = "btnUpdateComfirm";
            this.btnUpdateComfirm.Size = new System.Drawing.Size(114, 42);
            this.btnUpdateComfirm.TabIndex = 16;
            this.btnUpdateComfirm.Text = "确认";
            this.btnUpdateComfirm.UseVisualStyleBackColor = false;
            this.btnUpdateComfirm.Click += new System.EventHandler(this.btnRegisterComfirm_Click);
            // 
            // txtUpdateNum
            // 
            this.txtUpdateNum.Location = new System.Drawing.Point(144, 205);
            this.txtUpdateNum.Name = "txtUpdateNum";
            this.txtUpdateNum.Size = new System.Drawing.Size(154, 25);
            this.txtUpdateNum.TabIndex = 15;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.BackColor = System.Drawing.SystemColors.Control;
            this.label4.Font = new System.Drawing.Font("宋体", 12F);
            this.label4.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.label4.Location = new System.Drawing.Point(29, 205);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(109, 20);
            this.label4.TabIndex = 14;
            this.label4.Text = "手 机 号：";
            // 
            // txtUpdatePassword
            // 
            this.txtUpdatePassword.Location = new System.Drawing.Point(144, 122);
            this.txtUpdatePassword.Name = "txtUpdatePassword";
            this.txtUpdatePassword.Size = new System.Drawing.Size(154, 25);
            this.txtUpdatePassword.TabIndex = 13;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.BackColor = System.Drawing.SystemColors.Control;
            this.label5.Font = new System.Drawing.Font("宋体", 12F);
            this.label5.Location = new System.Drawing.Point(28, 122);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(109, 20);
            this.label5.TabIndex = 12;
            this.label5.Text = "密    码：";
            // 
            // txtUpdateName
            // 
            this.txtUpdateName.Location = new System.Drawing.Point(144, 43);
            this.txtUpdateName.Name = "txtUpdateName";
            this.txtUpdateName.Size = new System.Drawing.Size(154, 25);
            this.txtUpdateName.TabIndex = 11;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.BackColor = System.Drawing.SystemColors.Control;
            this.label6.Font = new System.Drawing.Font("宋体", 12F);
            this.label6.Location = new System.Drawing.Point(29, 43);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(109, 20);
            this.label6.TabIndex = 10;
            this.label6.Text = "用 户 名：";
            // 
            // frmusersupdate
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(348, 392);
            this.Controls.Add(this.promptRegisterNum);
            this.Controls.Add(this.promptRegisterPassword);
            this.Controls.Add(this.promptRegisterName);
            this.Controls.Add(this.btnUpdateComfirm);
            this.Controls.Add(this.txtUpdateNum);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.txtUpdatePassword);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.txtUpdateName);
            this.Controls.Add(this.label6);
            this.Name = "frmusersupdate";
            this.Text = "修改用户";
            this.Load += new System.EventHandler(this.frmusersupdate_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label promptRegisterNum;
        private System.Windows.Forms.Label promptRegisterPassword;
        private System.Windows.Forms.Label promptRegisterName;
        private System.Windows.Forms.Button btnUpdateComfirm;
        private System.Windows.Forms.TextBox txtUpdateNum;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox txtUpdatePassword;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox txtUpdateName;
        private System.Windows.Forms.Label label6;
    }
}