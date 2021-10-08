using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Net;
using System.Net.Mail;
using System.Runtime.Serialization;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Xml;

namespace SendMail
{
    public partial class Form1 : Form
    {
        settings settings = settings.getInstance();

        public Form1()
        {
            InitializeComponent();
        }


        private void btSend_Click(object sender, EventArgs e)
        {
            try {
                //メール送信のためのインスタンスを生成
                MailMessage mailMessage = new MailMessage();
                //差出人アドレス
                mailMessage.From = new MailAddress(settings.MailAddr);
                //宛先（To）
                mailMessage.To.Add(tbTo.Text);
                if (tbCc.Text != "") {
                    mailMessage.CC.Add(tbCc.Text);
                }
                if (tbBcc.Text != "") {
                    mailMessage.Bcc.Add(tbBcc.Text);
                }
                

                //件名（タイトル）
                mailMessage.Subject = tbTitle.Text;
                //本文
                mailMessage.Body = tbMessage.Text;
                if(tbMessage.Text.Trim() == "") {
                    MessageBox.Show("本文が未入力");
                    return;
                }

                //SMTPを使ってメールを送信する
                SmtpClient smtpClient = new SmtpClient();
                //メール送信のための認証情報を設定（ユーザー名、パスワード）
                smtpClient.Credentials
                    = new NetworkCredential(settings.MailAddr, settings.Pass);
                smtpClient.Host = settings.Host;
                smtpClient.Port = settings.Port;
                smtpClient.EnableSsl = settings.Ssl;
                smtpClient.SendMailAsync(mailMessage);
                btSend.Enabled = false;
                smtpClient.SendCompleted += SmtpClient_SendCompleted;
            
            } catch (Exception ex) {
                MessageBox.Show(ex.Message);
                
            }
        }

        private void SmtpClient_SendCompleted(object sender, AsyncCompletedEventArgs e) {
            if(e.Error != null) {
                MessageBox.Show(e.Error.Message);
            } else {
                MessageBox.Show("送信完了");
                tbTo.Clear();
                tbCc.Clear();
                tbBcc.Clear();
                tbTitle.Clear();
                tbMessage.Clear();
            }
            btSend.Enabled = true;
            
        }

        private void btConfig_Click(object sender, EventArgs e)
        {
            new ConfigForm().ShowDialog();
        }

        private void Form1_Load(object sender, EventArgs e) {

        }

        private void 終了XToolStripMenuItem1_Click(object sender, EventArgs e) {
            Application.Exit();
        }

        private void 新規作成NToolStripMenuItem1_Click(object sender, EventArgs e) {

            tbTo.Clear();
            tbCc.Clear();
            tbBcc.Clear();
            tbTitle.Clear();
            tbMessage.Clear();
        
        }
    }
}
