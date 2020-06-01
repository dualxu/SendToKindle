namespace SendToKindle
{
    partial class FormServerSetting
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FormServerSetting));
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.chkBoxIsUseSSL = new System.Windows.Forms.CheckBox();
            this.txtBoxPushSmtpServerPort = new System.Windows.Forms.TextBox();
            this.txtBoxPushSmtpServer = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.btnSend = new System.Windows.Forms.Button();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.groupBox1.Controls.Add(this.chkBoxIsUseSSL);
            this.groupBox1.Controls.Add(this.txtBoxPushSmtpServerPort);
            this.groupBox1.Controls.Add(this.txtBoxPushSmtpServer);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Font = new System.Drawing.Font("微软雅黑", 10.5F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.groupBox1.ForeColor = System.Drawing.Color.White;
            this.groupBox1.Location = new System.Drawing.Point(2, 3);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(300, 128);
            this.groupBox1.TabIndex = 7;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "推送邮箱服务器设置";
            // 
            // chkBoxIsUseSSL
            // 
            this.chkBoxIsUseSSL.Location = new System.Drawing.Point(116, 101);
            this.chkBoxIsUseSSL.Name = "chkBoxIsUseSSL";
            this.chkBoxIsUseSSL.Size = new System.Drawing.Size(15, 14);
            this.chkBoxIsUseSSL.TabIndex = 13;
            this.chkBoxIsUseSSL.UseVisualStyleBackColor = true;
            this.chkBoxIsUseSSL.CheckedChanged += new System.EventHandler(this.chkBoxIsUseSSL_CheckedChanged);
            // 
            // txtBoxPushSmtpServerPort
            // 
            this.txtBoxPushSmtpServerPort.Font = new System.Drawing.Font("微软雅黑", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.txtBoxPushSmtpServerPort.Location = new System.Drawing.Point(116, 63);
            this.txtBoxPushSmtpServerPort.Name = "txtBoxPushSmtpServerPort";
            this.txtBoxPushSmtpServerPort.Size = new System.Drawing.Size(178, 23);
            this.txtBoxPushSmtpServerPort.TabIndex = 3;
            this.txtBoxPushSmtpServerPort.Leave += new System.EventHandler(this.txtBoxPushSmtpServerPort_Leave);
            // 
            // txtBoxPushSmtpServer
            // 
            this.txtBoxPushSmtpServer.Font = new System.Drawing.Font("微软雅黑", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.txtBoxPushSmtpServer.Location = new System.Drawing.Point(116, 29);
            this.txtBoxPushSmtpServer.Name = "txtBoxPushSmtpServer";
            this.txtBoxPushSmtpServer.Size = new System.Drawing.Size(178, 23);
            this.txtBoxPushSmtpServer.TabIndex = 1;
            this.txtBoxPushSmtpServer.Leave += new System.EventHandler(this.txtBoxPushSmtpServer_Leave);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("微软雅黑", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.label1.Location = new System.Drawing.Point(4, 32);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(92, 17);
            this.label1.TabIndex = 0;
            this.label1.Text = "推送邮箱服务器";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("微软雅黑", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.label3.Location = new System.Drawing.Point(3, 100);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(76, 17);
            this.label3.TabIndex = 4;
            this.label3.Text = "是否启用SSL";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("微软雅黑", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.label2.Location = new System.Drawing.Point(4, 66);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(116, 17);
            this.label2.TabIndex = 2;
            this.label2.Text = "推送邮箱服务器端口";
            // 
            // btnSend
            // 
            this.btnSend.BackColor = System.Drawing.Color.Yellow;
            this.btnSend.Font = new System.Drawing.Font("微软雅黑", 10.5F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.btnSend.ForeColor = System.Drawing.Color.Black;
            this.btnSend.Location = new System.Drawing.Point(112, 135);
            this.btnSend.Name = "btnSend";
            this.btnSend.Size = new System.Drawing.Size(75, 32);
            this.btnSend.TabIndex = 12;
            this.btnSend.Text = "确定";
            this.btnSend.UseVisualStyleBackColor = false;
            this.btnSend.Click += new System.EventHandler(this.btnSend_Click);
            // 
            // FormServerSetting
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.ClientSize = new System.Drawing.Size(304, 171);
            this.ControlBox = false;
            this.Controls.Add(this.btnSend);
            this.Controls.Add(this.groupBox1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "FormServerSetting";
            this.ShowIcon = false;
            this.Text = "Send To Kindle : Push Server  Setting";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.FormServerSetting_FormClosing);
            this.Load += new System.EventHandler(this.FormServerSetting_Load);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.TextBox txtBoxPushSmtpServerPort;
        private System.Windows.Forms.TextBox txtBoxPushSmtpServer;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button btnSend;
        private System.Windows.Forms.CheckBox chkBoxIsUseSSL;
    }
}