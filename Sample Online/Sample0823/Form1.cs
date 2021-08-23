using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Sample0823
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Exec_Click(object sender, EventArgs e) {
            int n = int.Parse(Value.Text);
            int p = int.Parse(Jyou.Text);
            int result = n;
            Math.Pow(n, p);
            Result.Text = Math.Pow(n, p).ToString();
        }
    }
}
