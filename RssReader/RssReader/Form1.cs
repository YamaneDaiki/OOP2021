﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Net;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Xml.Linq;

namespace RssReader {
    public partial class Form1 : Form {
        public Form1() {
            InitializeComponent();
        }

        private void btRead_Click(object sender, EventArgs e) {
            setRssTitle(tbUrl.Text);
        }
        private void setRssTitle(string url) {
            using (var wc = new WebClient()) {
                wc.Headers.Add("Content-type", "charset=UTF-8");
                var uri = new Uri(url);
                var stream = wc.OpenRead(uri);



                XDocument xdoc = XDocument.Load(stream);
                var nodes = xdoc.Root.Descendants("title");
                foreach (var node in nodes) {
                    lbTitles.Items.Add(Regex.Replace(node.Value, "[i]", ""));
                }
            }
        }

        private void lbTitles_SelectedIndexChanged(object sender, EventArgs e) {
            var num = lbTitles.SelectedIndex;
            wbBrowser url
        }
    }
}
