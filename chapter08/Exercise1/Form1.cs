using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Exercise1 {
    public partial class Form1 : Form {
        public Form1() {
            InitializeComponent();
        }

        private void btAction_Click(object sender, EventArgs e) {
            //var today = new DateTime((int)nudYear.Value, (int)nudMonrh.Value, (int)nudDay.Value);
            var today = dtm.Value;
            DayOfWeek dayOfWeek = today.DayOfWeek;
            string dow = " ";
            switch (dayOfWeek) {
                case DayOfWeek.Sunday:
                    dow = "日曜日";
                    break;
                case DayOfWeek.Monday:
                    dow = "月曜日";
                    break;
                case DayOfWeek.Tuesday:
                    dow = "火曜日";
                    break;
                case DayOfWeek.Wednesday:
                    dow = "水曜日";
                    break;
                case DayOfWeek.Thursday:
                    dow = "木曜日";
                    break;
                case DayOfWeek.Friday:
                    dow = "金曜日";
                    break;
                case DayOfWeek.Saturday:
                    dow = "土曜日";
                    break;

            }
            tbOutput.Text = dow + "です";
            var dt2 = DateTime.Now;
            TimeSpan diff = dt2 - today;
            tbU.Text = diff.Days + "日";
            n.Text = GetAge(today, dt2).ToString();
        
        }

        int GetAge(DateTime birthday, DateTime targetDay) {
            var age = targetDay.Year - birthday.Year;
            if (targetDay < birthday.AddYears(age)) {
                age--;
            }
            return age;
            
        }

        private void dtm_ValueChanged(object sender, EventArgs e) {
         
        }
    }
}
