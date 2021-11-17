using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Navigation;
using System.Windows.Shapes;

namespace NumberGame {
    /// <summary>
    /// MainWindow.xaml の相互作用ロジック
    /// </summary>
    public partial class MainWindow : Window {
        public MainWindow() {
            InitializeComponent();
        }

        

        private void Button_Click(object sender, RoutedEventArgs e) { 
            var rand = new Random();
            int value = rand.Next(1, 26);
            var button = (Button)sender;
            if (value == int.Parse(button.Content.ToString())) {
                Tb.Text = "当たり" + value.ToString();
            } else {
                Tb.Text = "はずれ" + value.ToString();
            }

        }
    }
}
