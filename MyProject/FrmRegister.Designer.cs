namespace MyProject
{
    partial class FrmRegister
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FrmRegister));
            this.label1 = new System.Windows.Forms.Label();
            this.txtRegisterName = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.txtRegisterPassword = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.txtRegisterNum = new System.Windows.Forms.TextBox();
            this.btnRegisterComfirm = new System.Windows.Forms.Button();
            this.promptRegisterName = new System.Windows.Forms.Label();
            this.promptRegisterPassword = new System.Windows.Forms.Label();
            this.promptRegisterNum = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.label1.Font = new System.Drawing.Font("宋体", 12F);
            this.label1.Location = new System.Drawing.Point(52, 56);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(109, 20);
            this.label1.TabIndex = 0;
            this.label1.Text = "用 户 名：";
            // 
            // txtRegisterName
            // 
            this.txtRegisterName.Location = new System.Drawing.Point(167, 56);
            this.txtRegisterName.Name = "txtRegisterName";
            this.txtRegisterName.Size = new System.Drawing.Size(154, 25);
            this.txtRegisterName.TabIndex = 1;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.label2.Font = new System.Drawing.Font("宋体", 12F);
            this.label2.Location = new System.Drawing.Point(51, 135);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(109, 20);
            this.label2.TabIndex = 2;
            this.label2.Text = "密    码：";
            // 
            // txtRegisterPassword
            // 
            this.txtRegisterPassword.Location = new System.Drawing.Point(167, 135);
            this.txtRegisterPassword.Name = "txtRegisterPassword";
            this.txtRegisterPassword.Size = new System.Drawing.Size(154, 25);
            this.txtRegisterPassword.TabIndex = 3;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.label3.Font = new System.Drawing.Font("宋体", 12F);
            this.label3.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.label3.Location = new System.Drawing.Point(52, 218);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(109, 20);
            this.label3.TabIndex = 4;
            this.label3.Text = "手 机 号：";
            // 
            // txtRegisterNum
            // 
            this.txtRegisterNum.Location = new System.Drawing.Point(167, 218);
            this.txtRegisterNum.Name = "txtRegisterNum";
            this.txtRegisterNum.Size = new System.Drawing.Size(154, 25);
            this.txtRegisterNum.TabIndex = 5;
            // 
            // btnRegisterComfirm
            // 
            this.btnRegisterComfirm.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.btnRegisterComfirm.Font = new System.Drawing.Font("宋体", 13F);
            this.btnRegisterComfirm.Location = new System.Drawing.Point(167, 288);
            this.btnRegisterComfirm.Name = "btnRegisterComfirm";
            this.btnRegisterComfirm.Size = new System.Drawing.Size(114, 42);
            this.btnRegisterComfirm.TabIndex = 6;
            this.btnRegisterComfirm.Text = "确认";
            this.btnRegisterComfirm.UseVisualStyleBackColor = false;
            this.btnRegisterComfirm.Click += new System.EventHandler(this.btnRegisterComfirm_Click);
            // 
            // promptRegisterName
            // 
            this.promptRegisterName.AutoSize = true;
            this.promptRegisterName.Location = new System.Drawing.Point(127, 88);
            this.promptRegisterName.Name = "promptRegisterName";
            this.promptRegisterName.Size = new System.Drawing.Size(0, 15);
            this.promptRegisterName.TabIndex = 7;
            // 
            // promptRegisterPassword
            // 
            this.promptRegisterPassword.AutoSize = true;
            this.promptRegisterPassword.Location = new System.Drawing.Point(127, 167);
            this.promptRegisterPassword.Name = "promptRegisterPassword";
            this.promptRegisterPassword.Size = new System.Drawing.Size(0, 15);
            this.promptRegisterPassword.TabIndex = 8;
            // 
            // promptRegisterNum
            // 
            this.promptRegisterNum.AutoSize = true;
            this.promptRegisterNum.Location = new System.Drawing.Point(130, 250);
            this.promptRegisterNum.Name = "promptRegisterNum";
            this.promptRegisterNum.Size = new System.Drawing.Size(0, 15);
            this.promptRegisterNum.TabIndex = 9;
            // 
            // FrmRegister
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.ClientSize = new System.Drawing.Size(477, 429);
            this.Controls.Add(this.promptRegisterNum);
            this.Controls.Add(this.promptRegisterPassword);
            this.Controls.Add(this.promptRegisterName);
            this.Controls.Add(this.btnRegisterComfirm);
            this.Controls.Add(this.txtRegisterNum);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.txtRegisterPassword);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.txtRegisterName);
            this.Controls.Add(this.label1);
            this.Name = "FrmRegister";
            this.Text = "注册";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txtRegisterName;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txtRegisterPassword;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox txtRegisterNum;
        private System.Windows.Forms.Button btnRegisterComfirm;
        private System.Windows.Forms.Label promptRegisterName;
        private System.Windows.Forms.Label promptRegisterPassword;
        private System.Windows.Forms.Label promptRegisterNum;
    }
}