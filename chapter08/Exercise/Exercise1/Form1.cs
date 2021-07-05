using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Globalization;

namespace Exercise1 {
    public partial class Form1 : Form {
        public Form1() {
            InitializeComponent();
        }

        private void btToday_Click(object sender, EventArgs e) {
            var today = DateTime.Now;


            tbDateDisp.Text = String.Format("{0:yyyy/M/d HH:mm}", today) + "\r\n";
            tbDateDisp.Text += today.ToString("yyyy年M月dd日 HH時mm分ss秒") + "\r\n";
            var cultyre = new CultureInfo("ja-JP");
            cultyre.DateTimeFormat.Calendar = new JapaneseCalendar();
            tbDateDisp.Text += today.ToString("ggyy年M月d日(dddd)", cultyre);


        }

        private void Form1_Load(object sender, EventArgs e) {
            Timer tm = new Timer();
            tm.Tick += Tm_Tick;
            tm.Start();
          
        }
        //毎秒呼ばれるイベントハンドラ
        private void Tm_Tick(object sender, EventArgs e) {
            var today = DateTime.Now;
            tssTimeLabel.Text = today.ToString("yyyy年M月dd日 HH時mm分ss秒");
        }
    }
}
