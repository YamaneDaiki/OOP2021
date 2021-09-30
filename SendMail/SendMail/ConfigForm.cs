﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace SendMail
{
    public partial class ConfigForm : Form
    {
        private Settings settings = Settings.getInstance();

        public ConfigForm()
        {
            InitializeComponent();
        }

        private void btDefault_Click(object sender, EventArgs e) {
            
            tbHost.Text = settings.sHost();
            tbPort.Text = settings.sPort();
            tbUserName.Text = settings.sMailAddr();
            tbPass.Text = settings.sPass();
            cbSsl.Checked = settings.bSsl();
            tbSender.Text = settings.sMailAddr();
        }

        //OKボタン
        private void btOk_Click(object sender, EventArgs e) {
            settingsRegist();
            this.Close();
        }

        //キャンセルボタン
        private void btCancel_Click(object sender, EventArgs e) {
            this.Close();
        }

        //適用ボタン
        private void btApply_Click(object sender, EventArgs e) {

            settingsRegist();//送信データ登録
        }

        //送信データ登録
        private void settingsRegist() {
            settings.Host = tbHost.Text;
            settings.Port = int.Parse(tbPort.Text);
            settings.MailAddr = tbUserName.Text;
            settings.Pass = tbPass.Text;
            settings.Ssl = cbSsl.Checked;
        }
    }
}
