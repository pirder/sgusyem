namespace MyProject
{
    partial class FrmUserManager
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FrmUserManager));
            this.dataGridViewUser = new System.Windows.Forms.DataGridView();
            this.ColumnUserName = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ColumnUserNum = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ColumnUserPassword = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.label1 = new System.Windows.Forms.Label();
            this.txtnumsearch = new System.Windows.Forms.TextBox();
            this.searchallbtn = new System.Windows.Forms.Button();
            this.searchnumbtn = new System.Windows.Forms.Button();
            this.contextMenuStrip1 = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.删除用户ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.新增用户ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.修改用户ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewUser)).BeginInit();
            this.contextMenuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // dataGridViewUser
            // 
            this.dataGridViewUser.AllowUserToAddRows = false;
            this.dataGridViewUser.AllowUserToDeleteRows = false;
            this.dataGridViewUser.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.dataGridViewUser.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dataGridViewUser.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridViewUser.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.ColumnUserName,
            this.ColumnUserNum,
            this.ColumnUserPassword});
            this.dataGridViewUser.Location = new System.Drawing.Point(-1, 159);
            this.dataGridViewUser.Name = "dataGridViewUser";
            this.dataGridViewUser.ReadOnly = true;
            this.dataGridViewUser.RowTemplate.Height = 27;
            this.dataGridViewUser.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dataGridViewUser.Size = new System.Drawing.Size(605, 275);
            this.dataGridViewUser.TabIndex = 0;
            this.dataGridViewUser.CellMouseDown += new System.Windows.Forms.DataGridViewCellMouseEventHandler(this.dataGridViewUser_CellMouseDown);
            // 
            // ColumnUserName
            // 
            this.ColumnUserName.DataPropertyName = "users_name";
            this.ColumnUserName.HeaderText = "用户名";
            this.ColumnUserName.Name = "ColumnUserName";
            this.ColumnUserName.ReadOnly = true;
            // 
            // ColumnUserNum
            // 
            this.ColumnUserNum.DataPropertyName = "users_num";
            this.ColumnUserNum.HeaderText = "用户手机号";
            this.ColumnUserNum.Name = "ColumnUserNum";
            this.ColumnUserNum.ReadOnly = true;
            // 
            // ColumnUserPassword
            // 
            this.ColumnUserPassword.DataPropertyName = "users_password";
            this.ColumnUserPassword.HeaderText = "用户密码";
            this.ColumnUserPassword.Name = "ColumnUserPassword";
            this.ColumnUserPassword.ReadOnly = true;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(29, 48);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(127, 15);
            this.label1.TabIndex = 1;
            this.label1.Text = "单个手机号查找：";
            // 
            // txtnumsearch
            // 
            this.txtnumsearch.Location = new System.Drawing.Point(162, 45);
            this.txtnumsearch.Name = "txtnumsearch";
            this.txtnumsearch.Size = new System.Drawing.Size(170, 25);
            this.txtnumsearch.TabIndex = 2;
            // 
            // searchallbtn
            // 
            this.searchallbtn.Location = new System.Drawing.Point(12, 121);
            this.searchallbtn.Name = "searchallbtn";
            this.searchallbtn.Size = new System.Drawing.Size(143, 32);
            this.searchallbtn.TabIndex = 3;
            this.searchallbtn.Text = "查找所有用户";
            this.searchallbtn.UseVisualStyleBackColor = true;
            this.searchallbtn.Click += new System.EventHandler(this.searchallbtn_Click);
            // 
            // searchnumbtn
            // 
            this.searchnumbtn.Location = new System.Drawing.Point(338, 45);
            this.searchnumbtn.Name = "searchnumbtn";
            this.searchnumbtn.Size = new System.Drawing.Size(75, 25);
            this.searchnumbtn.TabIndex = 4;
            this.searchnumbtn.Text = "查找";
            this.searchnumbtn.UseVisualStyleBackColor = true;
            this.searchnumbtn.Click += new System.EventHandler(this.searchnumbtn_Click);
            // 
            // contextMenuStrip1
            // 
            this.contextMenuStrip1.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.contextMenuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.删除用户ToolStripMenuItem,
            this.修改用户ToolStripMenuItem,
            this.新增用户ToolStripMenuItem});
            this.contextMenuStrip1.Name = "contextMenuStrip1";
            this.contextMenuStrip1.Size = new System.Drawing.Size(145, 82);
            // 
            // 删除用户ToolStripMenuItem
            // 
            this.删除用户ToolStripMenuItem.Name = "删除用户ToolStripMenuItem";
            this.删除用户ToolStripMenuItem.Size = new System.Drawing.Size(144, 26);
            this.删除用户ToolStripMenuItem.Text = "删除用户";
            this.删除用户ToolStripMenuItem.Click += new System.EventHandler(this.删除用户ToolStripMenuItem_Click);
            // 
            // 新增用户ToolStripMenuItem
            // 
            this.新增用户ToolStripMenuItem.Name = "新增用户ToolStripMenuItem";
            this.新增用户ToolStripMenuItem.Size = new System.Drawing.Size(144, 26);
            this.新增用户ToolStripMenuItem.Text = "新增用户";
            this.新增用户ToolStripMenuItem.Click += new System.EventHandler(this.新增用户ToolStripMenuItem_Click);
            // 
            // 修改用户ToolStripMenuItem
            // 
            this.修改用户ToolStripMenuItem.Name = "修改用户ToolStripMenuItem";
            this.修改用户ToolStripMenuItem.Size = new System.Drawing.Size(144, 26);
            this.修改用户ToolStripMenuItem.Text = "修改用户";
            this.修改用户ToolStripMenuItem.Click += new System.EventHandler(this.修改用户ToolStripMenuItem_Click);
            // 
            // FrmUserManager
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(603, 434);
            this.Controls.Add(this.searchnumbtn);
            this.Controls.Add(this.searchallbtn);
            this.Controls.Add(this.txtnumsearch);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.dataGridViewUser);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "FrmUserManager";
            this.Text = "用户管理";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.FrmUserManager_FormClosing);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewUser)).EndInit();
            this.contextMenuStrip1.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView dataGridViewUser;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txtnumsearch;
        private System.Windows.Forms.Button searchallbtn;
        private System.Windows.Forms.Button searchnumbtn;
        private System.Windows.Forms.DataGridViewTextBoxColumn ColumnUserName;
        private System.Windows.Forms.DataGridViewTextBoxColumn ColumnUserNum;
        private System.Windows.Forms.DataGridViewTextBoxColumn ColumnUserPassword;
        private System.Windows.Forms.ContextMenuStrip contextMenuStrip1;
        private System.Windows.Forms.ToolStripMenuItem 删除用户ToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem 新增用户ToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem 修改用户ToolStripMenuItem;
    }
}