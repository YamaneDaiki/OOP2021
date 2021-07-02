using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Exercise3 {
    public partial class Form1 : Form {
        public Form1() {
            InitializeComponent();
        }
        //フォームがロードされるタイミングで1回だけ実行される
        private void Form1_Load(object sender, EventArgs e) {
            inputStrText.Text = "Jackdaws love my big sphinx of quartz";
            Text54.Text = "Novelist=谷崎潤一郎;BestWork=春琴抄;Born=1886";
        }

        private void kucount_Click(object sender, EventArgs e) {
            TextBoxSpaceCount.Text = inputStrText.Text.Count( c=> c == ' ').ToString();

        }

        private void big_Click(object sender, EventArgs e) {
             textBox2.Text = inputStrText.Text.Replace("big","small");

        }

        private void cu_Click(object sender, EventArgs e) {
            TgText.Text = inputStrText.Text.Split(' ').Length.ToString();
        }

        private void button4_Click(object sender, EventArgs e) {
            var words = inputStrText.Text.Split(' ').Where(s => s.Length <= 4);
            foreach (var word in words) {
                Tb4.Text += word + ' ';
            }
        }

        private void Bt5_Click(object sender, EventArgs e) {
            var str = inputStrText.Text.Split(' ');
            var sb = new StringBuilder();
            foreach (var item in str) {
                sb.Append(item　+ " ");
            }
            Tb5.Text = sb.ToString();
        }

        private void Bt54_Click(object sender, EventArgs e) {
            foreach (var pair in Text54.Text.Split(';')) {
                var array = pair.Split('=');
                Tb54.Text += ToJapanese(array[0]) + ":" + array[1] + Environment.NewLine;
            }
        }
        private string ToJapanese(string key) {
            switch (key) {
                case "Novelist":
                    return "作家　";

                case "BestWork":
                    return "代表作　";

                case "Born":
                    return "誕生年　";
            }
            throw new ArgumentException("引数が正しくありません");
        }
    }
}
