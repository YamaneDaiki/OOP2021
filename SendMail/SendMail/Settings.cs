using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Runtime.Serialization;
using System.Text;
using System.Threading.Tasks;
using System.Xml;

namespace SendMail
{
    public class settings
    {
        private static settings instance = null;


        public int Port { get; set; }   //ポート番号
        public string Host { get; set; }   //ホスト名
        public string MailAddr{ get; set; } //メールアドレス
        public string Pass { get; set; }    //パスワード
        public bool Ssl { get; set; }   //SSL

        //コンストラクタ
        private settings() {
    
        }



        //インスタンスの取得
        public static settings getInstance() {

            if(instance == null) {
                instance = new settings();

                //XMLファイル読み込み(逆シリアル化)
                if (File.Exists("settings.xml")) {
                    using (var reader = XmlReader.Create("settings.xml")) {
                        var serializer = new DataContractSerializer(typeof(settings));
                        var settig = serializer.ReadObject(reader) as settings;

                        instance.Host = settig.Host;
                        instance.Port = settig.Port;
                        instance.MailAddr = settig.MailAddr;
                        instance.Pass = settig.Pass;
                        instance.Ssl = settig.Ssl;

                    }
                    }else {
                        new ConfigForm().ShowDialog();
                    }
                }
                   
                return instance;
        }

        //送信データー登録
        public void setSendConfig(string host,int port,string mailAddr,string pass,bool ssl) {

            Host = host;
            Port = port;
            MailAddr = mailAddr;
            Pass = pass;
            Ssl = ssl;

            //ファイルへ書き出し(シリアル化)
            var setting = new XmlWriterSettings {
                Encoding = new System.Text.UTF8Encoding(false),
                Indent = true,
                IndentChars = " ",
            };

            using (var writer = XmlWriter.Create("settings.xml", setting)) {
                var serializr = new DataContractSerializer(instance.GetType());
                serializr.WriteObject(writer, instance);
            }
        }


        //初期値
        public string sHost()
        {
            return "smtp.gmail.com";  
        }
        
        public string sPort()
        {
            return 587.ToString();
        }

        public string sMailAddr()
        {
            return "ojsinfosys01@gmail.com";
        }


        public string sPass()
        {
            return "Infosys2021";
        }

        public bool bSsl() {
            return true;
        }
    }
}
