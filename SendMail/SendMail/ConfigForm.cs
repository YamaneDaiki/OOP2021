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
        private settings settings = settings.getInstance();

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


        //ファイルへ書き出し(シリアル化)
            var setting = new XmlWriterSettings {
                Encoding = new System.Text.UTF8Encoding(false),
                Indent = true,
                IndentChars = " ",
            };
            string filePath = "settings.xml";
            if (File.Exists(filePath)) {

            } else {
                using (var writer = XmlWriter.Create("settings.xml", setting)) {
                    var serializr = new DataContractSerializer(settings.GetType());
                    serializr.WriteObject(writer, settings);
                }
            }

        
            
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
