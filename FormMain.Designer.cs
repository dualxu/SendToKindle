namespace SendToKindle
{
    partial class FormMain
    {
        /// <summary>
        /// 必需的设计器变量。
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// 清理所有正在使用的资源。
        /// </summary>
        /// <param name="disposing">如果应释放托管资源，为 true；否则为 false。</param>
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
        /// 设计器支持所需的方法 - 不要修改
        /// 使用代码编辑器修改此方法的内容。
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FormMain));
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.chkBoxAdvancedSetting = new System.Windows.Forms.CheckBox();
            this.txtBoxPushMailPasswd = new System.Windows.Forms.TextBox();
            this.txtBoxPushMail = new System.Windows.Forms.TextBox();
            this.txtBoxBindMail = new System.Windows.Forms.TextBox();
            this.lstFile = new System.Windows.Forms.ListView();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.btnDelete = new System.Windows.Forms.Button();
            this.btnFileSelect = new System.Windows.Forms.Button();
            this.btnSend = new System.Windows.Forms.Button();
            this.prgBar = new System.Windows.Forms.ProgressBar();
            this.linkLabel1 = new System.Windows.Forms.LinkLabel();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("微软雅黑", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.label1.Location = new System.Drawing.Point(4, 32);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(92, 17);
            this.label1.TabIndex = 0;
            this.label1.Text = "Kindle绑定邮箱";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("微软雅黑", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.label2.Location = new System.Drawing.Point(4, 69);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(92, 17);
            this.label2.TabIndex = 2;
            this.label2.Text = "Kindle推送邮箱";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("微软雅黑", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.label3.Location = new System.Drawing.Point(3, 104);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(116, 17);
            this.label3.TabIndex = 4;
            this.label3.Text = "Kindle推送邮箱密码";
            // 
            // groupBox1
            // 
            this.groupBox1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.groupBox1.Controls.Add(this.chkBoxAdvancedSetting);
            this.groupBox1.Controls.Add(this.txtBoxPushMailPasswd);
            this.groupBox1.Controls.Add(this.txtBoxPushMail);
            this.groupBox1.Controls.Add(this.txtBoxBindMail);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Font = new System.Drawing.Font("微软雅黑", 10.5F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.groupBox1.ForeColor = System.Drawing.Color.White;
            this.groupBox1.Location = new System.Drawing.Point(2, 2);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(300, 162);
            this.groupBox1.TabIndex = 6;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "推送选项";
            // 
            // chkBoxAdvancedSetting
            // 
            this.chkBoxAdvancedSetting.AutoSize = true;
            this.chkBoxAdvancedSetting.Location = new System.Drawing.Point(116, 131);
            this.chkBoxAdvancedSetting.Name = "chkBoxAdvancedSetting";
            this.chkBoxAdvancedSetting.Size = new System.Drawing.Size(182, 23);
            this.chkBoxAdvancedSetting.TabIndex = 6;
            this.chkBoxAdvancedSetting.Text = "推送邮箱服务器高级设置";
            this.chkBoxAdvancedSetting.UseVisualStyleBackColor = true;
            this.chkBoxAdvancedSetting.CheckedChanged += new System.EventHandler(this.chkBoxAdvancedSetting_CheckedChanged);
            // 
            // txtBoxPushMailPasswd
            // 
            this.txtBoxPushMailPasswd.Font = new System.Drawing.Font("微软雅黑", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.txtBoxPushMailPasswd.Location = new System.Drawing.Point(116, 101);
            this.txtBoxPushMailPasswd.Name = "txtBoxPushMailPasswd";
            this.txtBoxPushMailPasswd.PasswordChar = '*';
            this.txtBoxPushMailPasswd.Size = new System.Drawing.Size(178, 23);
            this.txtBoxPushMailPasswd.TabIndex = 5;
            this.txtBoxPushMailPasswd.UseSystemPasswordChar = true;
            this.txtBoxPushMailPasswd.Leave += new System.EventHandler(this.txtBoxPushMailPasswd_Leave);
            // 
            // txtBoxPushMail
            // 
            this.txtBoxPushMail.Font = new System.Drawing.Font("微软雅黑", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.txtBoxPushMail.Location = new System.Drawing.Point(116, 66);
            this.txtBoxPushMail.Name = "txtBoxPushMail";
            this.txtBoxPushMail.Size = new System.Drawing.Size(178, 23);
            this.txtBoxPushMail.TabIndex = 3;
            this.txtBoxPushMail.Leave += new System.EventHandler(this.txtBoxPushMail_Leave);
            // 
            // txtBoxBindMail
            // 
            this.txtBoxBindMail.Font = new System.Drawing.Font("微软雅黑", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.txtBoxBindMail.Location = new System.Drawing.Point(116, 29);
            this.txtBoxBindMail.Name = "txtBoxBindMail";
            this.txtBoxBindMail.Size = new System.Drawing.Size(178, 23);
            this.txtBoxBindMail.TabIndex = 1;
            this.txtBoxBindMail.Leave += new System.EventHandler(this.txtBoxBindMail_Leave);
            // 
            // lstFile
            // 
            this.lstFile.HideSelection = false;
            this.lstFile.Location = new System.Drawing.Point(6, 50);
            this.lstFile.Name = "lstFile";
            this.lstFile.Size = new System.Drawing.Size(288, 199);
            this.lstFile.TabIndex = 9;
            this.lstFile.UseCompatibleStateImageBehavior = false;
            this.lstFile.View = System.Windows.Forms.View.Details;
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.btnDelete);
            this.groupBox2.Controls.Add(this.btnFileSelect);
            this.groupBox2.Controls.Add(this.lstFile);
            this.groupBox2.Font = new System.Drawing.Font("微软雅黑", 10.5F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.groupBox2.ForeColor = System.Drawing.Color.White;
            this.groupBox2.Location = new System.Drawing.Point(2, 166);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(300, 255);
            this.groupBox2.TabIndex = 7;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "推送文件列表";
            // 
            // btnDelete
            // 
            this.btnDelete.BackColor = System.Drawing.Color.Yellow;
            this.btnDelete.Font = new System.Drawing.Font("微软雅黑", 10.5F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.btnDelete.ForeColor = System.Drawing.Color.Black;
            this.btnDelete.Location = new System.Drawing.Point(219, 14);
            this.btnDelete.Name = "btnDelete";
            this.btnDelete.Size = new System.Drawing.Size(75, 32);
            this.btnDelete.TabIndex = 12;
            this.btnDelete.Text = "删除";
            this.btnDelete.UseVisualStyleBackColor = false;
            this.btnDelete.Click += new System.EventHandler(this.btnDelete_Click);
            // 
            // btnFileSelect
            // 
            this.btnFileSelect.BackColor = System.Drawing.Color.Yellow;
            this.btnFileSelect.Font = new System.Drawing.Font("微软雅黑", 10.5F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.btnFileSelect.ForeColor = System.Drawing.Color.Black;
            this.btnFileSelect.Location = new System.Drawing.Point(94, 15);
            this.btnFileSelect.Name = "btnFileSelect";
            this.btnFileSelect.Size = new System.Drawing.Size(120, 31);
            this.btnFileSelect.TabIndex = 8;
            this.btnFileSelect.Text = "选择或拖曳文件";
            this.btnFileSelect.UseVisualStyleBackColor = false;
            this.btnFileSelect.Click += new System.EventHandler(this.btnFileSelect_Click);
            // 
            // btnSend
            // 
            this.btnSend.BackColor = System.Drawing.Color.Yellow;
            this.btnSend.Font = new System.Drawing.Font("微软雅黑", 10.5F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.btnSend.ForeColor = System.Drawing.Color.Black;
            this.btnSend.Location = new System.Drawing.Point(118, 437);
            this.btnSend.Name = "btnSend";
            this.btnSend.Size = new System.Drawing.Size(75, 32);
            this.btnSend.TabIndex = 11;
            this.btnSend.Text = "推送";
            this.btnSend.UseVisualStyleBackColor = false;
            this.btnSend.Click += new System.EventHandler(this.btnSend_Click);
            // 
            // prgBar
            // 
            this.prgBar.Location = new System.Drawing.Point(2, 427);
            this.prgBar.Name = "prgBar";
            this.prgBar.Size = new System.Drawing.Size(300, 5);
            this.prgBar.Step = 5;
            this.prgBar.TabIndex = 10;
            // 
            // linkLabel1
            // 
            this.linkLabel1.AutoSize = true;
            this.linkLabel1.Font = new System.Drawing.Font("微软雅黑", 10.5F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.linkLabel1.LinkColor = System.Drawing.Color.Yellow;
            this.linkLabel1.Location = new System.Drawing.Point(284, 442);
            this.linkLabel1.Name = "linkLabel1";
            this.linkLabel1.Size = new System.Drawing.Size(16, 19);
            this.linkLabel1.TabIndex = 12;
            this.linkLabel1.TabStop = true;
            this.linkLabel1.Text = "?";
            this.linkLabel1.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.linkLabel1_LinkClicked);
            // 
            // FormMain
            // 
            this.AllowDrop = true;
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.ClientSize = new System.Drawing.Size(304, 473);
            this.Controls.Add(this.linkLabel1);
            this.Controls.Add(this.prgBar);
            this.Controls.Add(this.btnSend);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "FormMain";
            this.ShowIcon = false;
            this.Text = "Send To Kindle";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.FormMain_FormClosing);
            this.Load += new System.EventHandler(this.FormMain_Load);
            this.DragDrop += new System.Windows.Forms.DragEventHandler(this.FormMain_DragDrop);
            this.DragEnter += new System.Windows.Forms.DragEventHandler(this.FormMain_DragEnter);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.ListView lstFile;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.Button btnSend;
        private System.Windows.Forms.ProgressBar prgBar;
        private System.Windows.Forms.TextBox txtBoxBindMail;
        private System.Windows.Forms.TextBox txtBoxPushMailPasswd;
        private System.Windows.Forms.TextBox txtBoxPushMail;
        private System.Windows.Forms.Button btnFileSelect;
        private System.Windows.Forms.Button btnDelete;
        private System.Windows.Forms.CheckBox chkBoxAdvancedSetting;
        private System.Windows.Forms.LinkLabel linkLabel1;
    }
}

