using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.ServiceProcess;
using System.Net.Mail;
using System.Net.Mime;
using System.Xml;
using System.IO;
using NLog;


namespace SendToKindle
{
    public partial class FormMain : Form
    {
        private static string kindlebindemail = "";
        private static string kindlepushemail = "";
        private static string kindlepushemailpassword = "";
        private static bool isUseSSL = true;

        private static List<string> pushFiles = new List<string>();
        private static List<string> pushFileDir = new List<string>();
        private static long pushFileSize = 0;

        private static string kindlepushsmtphost = "smtp.qq.com";
        private static int kindlepushsmtpport = 25;

        private static Logger logger = LogManager.GetLogger("Send2Kindle");

        public FormMain()
        {
            InitializeComponent();
        }

        private void btnSend_Click(object sender, EventArgs e)
        {
            getSmtpHostAndPortByPushMail();

            prgBar.Visible = true;
            prgBar.Value = 5;
            bool isSendError = false;

            for(int index=0;index<pushFiles.Count; index++)
            {
                string file = pushFileDir[index] + "\\" + pushFiles[index];

                if(!sendmail(file,isUseSSL))
                {
                    MessageBox.Show(this, "当前文件["+ pushFiles[index] + "[推送出现问题，请检查推送设置！", "提示");
                    isSendError = true;
                    break;
                }

                prgBar.Value = (index+1)*100 / pushFiles.Count;
            }

            if (isSendError)
            {

            }
            else
            {
                prgBar.Value = 100;
                MessageBox.Show(this, "文件推送到Kindle已完成，请稍候打开Kindle连接无线后同步！", "提示");
            }
        }        

        private void FormMain_Load(object sender, EventArgs e)
        {
            btnSend.Visible = false;
            prgBar.Visible = false;
            txtBoxBindMail.Text = Properties.Settings.Default.KindleBindMail;
            txtBoxPushMail.Text = Properties.Settings.Default.KindlePushMail;
            txtBoxPushMailPasswd.Text = Properties.Settings.Default.KindlePushMailPassword;
            //
            kindlebindemail = Properties.Settings.Default.KindleBindMail;
            kindlepushemail = Properties.Settings.Default.KindlePushMail;
            kindlepushemailpassword = Properties.Settings.Default.KindlePushMailPassword;
            //设置列标题
            ColumnHeader ch = new ColumnHeader();
            ch.Text = "推送文件";
            ch.Width = 280;
            ch.TextAlign = HorizontalAlignment.Left;
            this.lstFile.Columns.Add(ch);
            //
            updateListView();
        }

        private void updateListView()
        {
            //更新ListView
            this.lstFile.BeginUpdate();
            this.lstFile.Items.Clear();
            for (int i = 0; i < pushFiles.Count; i++)
            {
                ListViewItem lvi = new ListViewItem();

                lvi.Text = pushFiles[i];

                this.lstFile.Items.Add(lvi);
            }
            this.lstFile.EndUpdate();
        }

        private void getSmtpHostAndPortByPushMail()
        {
            if (kindlepushemail == "") return;

            if (chkBoxAdvancedSetting.Checked) return;

            if (kindlepushemail.EndsWith("@outlook.com"))   //OK
            {
                kindlepushsmtphost = "smtp.office365.com";
                kindlepushsmtpport = 587;
                isUseSSL = true;
            }
            else if (kindlepushemail.EndsWith("@qq.com"))   //OK
            {
                kindlepushsmtphost = "smtp.qq.com";
                kindlepushsmtpport = 25;
                isUseSSL = false;
            }
            else if (kindlepushemail.EndsWith("@sina.com"))   
            {
                kindlepushsmtphost = "smtp.sina.com.cn";
                kindlepushsmtpport = 25;
                isUseSSL = false;
            }
            else if (kindlepushemail.EndsWith("@vip.sina.com"))   
            {
                kindlepushsmtphost = "smtp.vip.sina.com";
                kindlepushsmtpport = 25;
                isUseSSL = false;
            }
            else if (kindlepushemail.EndsWith("@sohu.com"))
            {
                kindlepushsmtphost = "smtp.sohu.com";
                kindlepushsmtpport = 25;
                isUseSSL = false;
            }
            else if (kindlepushemail.EndsWith("@126.com"))
            {
                kindlepushsmtphost = "smtp.126.com";
                kindlepushsmtpport = 25;
                isUseSSL = false;
            }
            else if (kindlepushemail.EndsWith("@139.com"))
            {
                kindlepushsmtphost = "smtp.139.com";
                kindlepushsmtpport = 25;
                isUseSSL = false;
            }
            else if (kindlepushemail.EndsWith("@163.com"))
            {
                kindlepushsmtphost = "smtp.163.com";
                kindlepushsmtpport = 25;
                isUseSSL = false;
            }
            else if (kindlepushemail.EndsWith("@yahoo.com"))
            {
                kindlepushsmtphost = "smtp.mail.yahoo.com";
                kindlepushsmtpport = 25;
                isUseSSL = false;
            }
            else if (kindlepushemail.EndsWith("@yahoo.com.cn"))
            {
                kindlepushsmtphost = "smtp.mail.yahoo.com.cn";
                kindlepushsmtpport = 587;
                isUseSSL = true;
            }
            else if (kindlepushemail.EndsWith("@hotmail.com"))
            {
                kindlepushsmtphost = "smtp.live.com";
                kindlepushsmtpport = 587;
                isUseSSL = true;
            }
            else if (kindlepushemail.EndsWith("@gmail.com"))
            {
                kindlepushsmtphost = "smtp.gmail.com";
                kindlepushsmtpport = 587;
                isUseSSL = true;
            }
            else if (kindlepushemail.EndsWith("@263.net"))
            {
                kindlepushsmtphost = "smtp.263.net";
                kindlepushsmtpport = 25;
                isUseSSL = false;
            }
            else if (kindlepushemail.EndsWith("@263.net.cn"))
            {
                kindlepushsmtphost = "smtp.263.net.cn";
                kindlepushsmtpport = 25;
                isUseSSL = false;
            }
            else if (kindlepushemail.EndsWith("@x263.net"))
            {
                kindlepushsmtphost = "smtp.x263.net";
                kindlepushsmtpport = 25;
                isUseSSL = false;
            }
            else if (kindlepushemail.EndsWith("@21cn.com"))
            {
                kindlepushsmtphost = "smtp.21cn.com";
                kindlepushsmtpport = 25;
                isUseSSL = false;
            }
            else if (kindlepushemail.EndsWith("@foxmail.com"))
            {
                kindlepushsmtphost = "smtp.foxmail.com";
                kindlepushsmtpport = 25;
                isUseSSL = false;
            }
            else if (kindlepushemail.EndsWith("@china.com"))
            {
                kindlepushsmtphost = "smtp.china.com";
                kindlepushsmtpport = 25;
                isUseSSL = false;
            }
            else if (kindlepushemail.EndsWith("@tom.com"))
            {
                kindlepushsmtphost = "smtp.tom.com";
                kindlepushsmtpport = 25;
                isUseSSL = false;
            }
            else if (kindlepushemail.EndsWith("@etang.com"))
            {
                kindlepushsmtphost = "smtp.etang.com";
                kindlepushsmtpport = 25;
                isUseSSL = false;
            }
            else if (kindlepushemail.EndsWith("@mail.aliyun.com"))
            {
                kindlepushsmtphost = "smtp.aliyun.com";
                kindlepushsmtpport = 25;
                isUseSSL = false;
            }
            else if (kindlepushemail.EndsWith("@elong.com"))
            {
                kindlepushsmtphost = "smtp.elong.com";
                kindlepushsmtpport = 25;
                isUseSSL = false;
            }
            else
            {
                FormServerSetting fss = new FormServerSetting();
                fss.ShowDialog();

                //kindlepushsmtphost = "smtp.exmail.qq.com"; //OK for @sh-rfid.com
                //kindlepushsmtpport = 587;
                //isUseSSL = true;

                kindlepushsmtphost = Properties.Settings.Default.KindlePushSmtpServer;
                int port = 25;
                int.TryParse(Properties.Settings.Default.KindlePushSmtpServerPort,out port);
                kindlepushsmtpport = port;
                isUseSSL = Properties.Settings.Default.KindlePushIsUseSSL;
            }
        }

        private bool sendmail(string mailfile, bool isUseSsl)
        {
            logger.Info("Send2Kindle-->sendmail");

            string smtphost = kindlepushsmtphost;               // 邮件服务器smtp.qq.com表示腾讯邮箱服务器    
            string userName = kindlepushemail;                  // 发送端账号   
            string password = kindlepushemailpassword;          // 发送端密码(这个客户端重置后的密码)      

            try
            {
                SmtpClient client = new SmtpClient();
                client.DeliveryMethod = SmtpDeliveryMethod.Network; //指定电子邮件发送方式    
                client.Host = smtphost;                             //邮件服务器
                client.Port = kindlepushsmtpport;                   //465(ssl), 25(default)
                client.UseDefaultCredentials = true;
                client.Credentials = new System.Net.NetworkCredential(userName, password);         //用户名、密码
                if (isUseSSL) client.EnableSsl = true;
                else client.EnableSsl = false;

                string strfrom = userName;
                string strto = kindlebindemail;             //Kindle绑定的邮箱账号
                //string strcc = "";                        //抄送

                string subject = mailfile.Substring(mailfile.LastIndexOf('\\')+1);                //邮件的主题
                string body = "";                           //发送的邮件正文  

                Attachment mailattached = new Attachment(mailfile, MediaTypeNames.Application.Octet);

                System.Net.Mail.MailMessage msg = new System.Net.Mail.MailMessage();
                msg.From = new MailAddress(strfrom, strfrom.Split('@')[0]);
                msg.To.Add(strto);
                //msg.CC.Add(strcc);
                msg.Attachments.Add(mailattached);
                msg.Subject = subject;                          //邮件标题   
                msg.Body = body;                                //邮件内容   
                msg.BodyEncoding = System.Text.Encoding.UTF8;   //邮件内容编码   
                msg.IsBodyHtml = false;                         //是否是HTML邮件   
                msg.Priority = MailPriority.High;               //邮件优先级

                client.Send(msg);
                logger.Info("Send2Kindle-->sendmail send ok");
            }
            catch (Exception ex)
            {
                logger.Info("Send2Kindle-->sendmail send fail, error: " + ex.Message + "\n" + ex.StackTrace);
                MessageBox.Show(this, "邮件发送错误:"+ ex.Message, "提示");
                return false;
            }
            return true;
        }

        private void btnFileSelect_Click(object sender, EventArgs e)
        {
            OpenFileDialog dialog = new OpenFileDialog();
            dialog.Multiselect = true;
            dialog.Title = "请选择待推送文件......";
            dialog.Filter = "所有文件(*.*)|*.*";
            dialog.RestoreDirectory = true;
            if (dialog.ShowDialog() == System.Windows.Forms.DialogResult.OK)
            {
                foreach(var f in dialog.FileNames)
                {
                    FileInfo file = new FileInfo(f);
                    string ext = file.Extension;
                    if ((ext != ".mobi") && (ext != ".azw") && (ext != ".doc") && (ext != ".docx")
                        && (ext != ".html") && (ext != ".htm") && (ext != ".rtf") && (ext != ".txt")
                        && (ext != ".jpeg") && (ext != ".jpg") && (ext != ".gif") && (ext != ".png")
                        && (ext != ".bmp") && (ext != ".pdf") && (ext != ".zip"))
                        continue;
                    if (((pushFiles.Count + 1) > 25) || ((pushFileSize + file.Length) > 50 * 1024 * 1024))
                    {
                        MessageBox.Show(this, "亚马逊个人文档服务推送限制：附件个数不能超过 25 个，总大小不能超过 50MB!", "提示");
                        break;
                    }
                    pushFileSize += file.Length;
                    pushFiles.Add(file.Name);
                    pushFileDir.Add(file.DirectoryName);
                }
                //
                updateListView();
                //
                if((pushFiles.Count()>0)&&(txtBoxBindMail.Text != "")&&(txtBoxPushMail.Text != "")&&(txtBoxPushMailPasswd.Text != ""))
                {
                    btnSend.Visible = true;
                }
                else
                {
                    btnSend.Visible = false;
                }
            }
        }

        private void FormMain_FormClosing(object sender, FormClosingEventArgs e)
        {
            
            Properties.Settings.Default.KindleBindMail = txtBoxBindMail.Text.Trim();
            Properties.Settings.Default.KindlePushMail = txtBoxPushMail.Text.Trim();
            Properties.Settings.Default.KindlePushMailPassword = txtBoxPushMailPasswd.Text.Trim();
            Properties.Settings.Default.Save();
        }

        private void txtBoxBindMail_Leave(object sender, EventArgs e)
        {
            kindlebindemail = txtBoxBindMail.Text.Trim();
            //
            if ((pushFiles.Count() > 0) && (txtBoxBindMail.Text != "") && (txtBoxPushMail.Text != "") && (txtBoxPushMailPasswd.Text != ""))
            {
                btnSend.Visible = true;
            }
            else
            {
                btnSend.Visible = false;
            }
        }

        private void txtBoxPushMail_Leave(object sender, EventArgs e)
        {
            kindlepushemail = txtBoxPushMail.Text.Trim();
            //
            if ((pushFiles.Count() > 0) && (txtBoxBindMail.Text != "") && (txtBoxPushMail.Text != "") && (txtBoxPushMailPasswd.Text != ""))
            {
                btnSend.Visible = true;
            }
            else
            {
                btnSend.Visible = false;
            }
        }

        private void txtBoxPushMailPasswd_Leave(object sender, EventArgs e)
        {
            kindlepushemailpassword = txtBoxPushMailPasswd.Text.Trim();
            //
            if ((pushFiles.Count() > 0) && (txtBoxBindMail.Text != "") && (txtBoxPushMail.Text != "") && (txtBoxPushMailPasswd.Text != ""))
            {
                btnSend.Visible = true;
            }
            else
            {
                btnSend.Visible = false;
            }
        }

        private void FormMain_DragEnter(object sender, DragEventArgs e)
        {
            if (e.Data.GetDataPresent(DataFormats.FileDrop))
                e.Effect = DragDropEffects.All;
            else
                e.Effect = DragDropEffects.None;
        }

        private void FormMain_DragDrop(object sender, DragEventArgs e)
        {
            string[] filePath = (string[])e.Data.GetData(DataFormats.FileDrop);
            foreach (string file in filePath)
            {
                FileInfo f = new FileInfo(file);
                string ext = f.Extension;
                if ((ext != ".mobi") && (ext != ".azw") && (ext != ".doc") && (ext != ".docx")
                    && (ext != ".html") && (ext != ".htm") && (ext != ".rtf") && (ext != ".txt")
                    && (ext != ".jpeg") && (ext != ".jpg") && (ext != ".gif") && (ext != ".png")
                    && (ext != ".bmp") && (ext != ".pdf") && (ext != ".zip"))
                    continue;
                if (((pushFiles.Count+1) > 25) || ((pushFileSize + f.Length) > 50*1024*1024))
                {
                    MessageBox.Show(this, "亚马逊个人文档服务推送限制：附件个数不能超过 25 个，总大小不能超过 50MB!", "提示");
                    break;
                }
                pushFileSize += f.Length;
                pushFiles.Add(f.Name);
                pushFileDir.Add(f.DirectoryName);                
            }
            //
            updateListView();
            //
            if ((pushFiles.Count() > 0) && (txtBoxBindMail.Text != "") && (txtBoxPushMail.Text != "") && (txtBoxPushMailPasswd.Text != ""))
            {
                btnSend.Visible = true;
            }
            else
            {
                btnSend.Visible = false;
            }
        }

        private void btnDelete_Click(object sender, EventArgs e)
        {
            foreach (ListViewItem var in lstFile.Items)
            {
                if (var.Selected)
                {
                    int index = var.Index;
                    FileInfo file = new FileInfo(pushFileDir[index] + "\\" + pushFiles[index]);
                    pushFileSize -= file.Length;
                    pushFiles.RemoveAt(index);
                    pushFileDir.RemoveAt(index);
                    var.Remove();                    
                }
            }
            //
            updateListView();
            //
            if ((pushFiles.Count() > 0) && (txtBoxBindMail.Text != "") && (txtBoxPushMail.Text != "") && (txtBoxPushMailPasswd.Text != ""))
            {
                btnSend.Visible = true;
            }
            else
            {
                btnSend.Visible = false;
            }
        }

        private void chkBoxAdvancedSetting_CheckedChanged(object sender, EventArgs e)
        {
            if(chkBoxAdvancedSetting.Checked)
            {
                FormServerSetting fss = new FormServerSetting();
                fss.ShowDialog();
                //
                kindlepushsmtphost = Properties.Settings.Default.KindlePushSmtpServer;
                int port = 25;
                int.TryParse(Properties.Settings.Default.KindlePushSmtpServerPort, out port);
                kindlepushsmtpport = port;
                isUseSSL = Properties.Settings.Default.KindlePushIsUseSSL;
            }
        }

        private void linkLabel1_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            System.Diagnostics.Process.Start("https://www.amazon.cn/gp/help/customer/display.html/ref=hp_left_v4_sib?ie=UTF8&nodeId=201974220");  
            linkLabel1.LinkVisited = true; 
        }
    }
}
