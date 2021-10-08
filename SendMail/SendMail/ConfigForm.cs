using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Xml;
using System.Xml.Linq;
using System.Runtime.Serialization;
using System.IO;

namespace SendMail {
    public partial class ConfigForm : Form {
        settings settings = settings.getInstance();

        public ConfigForm() {
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
            btApply_Click(sender, e); //適用ボタン処理を呼び出し
            this.Close();



        }


        //キャンセルボタン
        private void btCancel_Click(object sender, EventArgs e) {
            this.Close();
        }

        //適用ボタン
        private void btApply_Click(object sender, EventArgs e) {
            settings.setSendConfig(tbHost.Text, int.Parse(tbPort.Text), tbUserName.Text, tbPass.Text, cbSsl.Checked);
            
        }

        
        //設定をロード
        private void ConfigForm_Load(object sender, EventArgs e) {
            tbHost.Text = settings.Host;
            tbPort.Text = settings.Port.ToString();
            tbUserName.Text = settings.MailAddr;
            tbPass.Text = settings.Pass;
            cbSsl.Checked = settings.Ssl;
            tbSender.Text = settings.Host;
        }
    }
}
