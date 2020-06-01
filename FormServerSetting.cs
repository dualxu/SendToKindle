using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace SendToKindle
{
    public partial class FormServerSetting : Form
    {
        public FormServerSetting()
        {
            InitializeComponent();
        }

        private void btnSend_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void txtBoxPushSmtpServer_Leave(object sender, EventArgs e)
        {
            Properties.Settings.Default.KindlePushSmtpServer = txtBoxPushSmtpServer.Text.Trim();
        }

        private void txtBoxPushSmtpServerPort_Leave(object sender, EventArgs e)
        {
            Properties.Settings.Default.KindlePushSmtpServerPort = txtBoxPushSmtpServerPort.Text.Trim();
        }

        private void chkBoxIsUseSSL_CheckedChanged(object sender, EventArgs e)
        {
            Properties.Settings.Default.KindlePushIsUseSSL = chkBoxIsUseSSL.Checked;
        }

        private void FormServerSetting_FormClosing(object sender, FormClosingEventArgs e)
        {
            Properties.Settings.Default.KindlePushSmtpServer = txtBoxPushSmtpServer.Text.Trim();
            Properties.Settings.Default.KindlePushSmtpServerPort = txtBoxPushSmtpServerPort.Text.Trim();
            Properties.Settings.Default.KindlePushIsUseSSL = chkBoxIsUseSSL.Checked;
            Properties.Settings.Default.Save();
        }

        private void FormServerSetting_Load(object sender, EventArgs e)
        {
            txtBoxPushSmtpServer.Text = Properties.Settings.Default.KindlePushSmtpServer;

            txtBoxPushSmtpServerPort.Text = Properties.Settings.Default.KindlePushSmtpServerPort;

            chkBoxIsUseSSL.Checked = Properties.Settings.Default.KindlePushIsUseSSL;
        }
    }
}
