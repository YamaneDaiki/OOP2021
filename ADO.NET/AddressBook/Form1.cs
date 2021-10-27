using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Runtime.Serialization;

namespace AddressBook {
    public partial class Form1 : Form {
        public Form1() {
            InitializeComponent();
        }

        private void personBindingNavigatorSaveItem_Click(object sender, EventArgs e) {
            this.Validate();
            this.personBindingSource.EndEdit();
            this.tableAdapterManager.UpdateAll(this.infosys202129DataSet);

        }

        private void Form1_Load(object sender, EventArgs e) {
            personDataGridView.Columns[0].Visible = false;
            personDataGridView.Columns[1].HeaderText = "名前";
            personDataGridView.Columns[2].HeaderText = "誕生日";
            personDataGridView.Columns[3].HeaderText = "電話番号";
            personDataGridView.Columns[4].HeaderText = "備考";


        }

        private void btConnect_Click(object sender, EventArgs e) {

            // TODO: このコード行はデータを 'infosys202129DataSet.Person' テーブルに読み込みます。必要に応じて移動、または削除をしてください。
            this.personTableAdapter.Fill(this.infosys202129DataSet.Person);

            
        }

        private void btNameFilter_Click(object sender, EventArgs e) {
           
            this.personTableAdapter.FillByName(infosys202129DataSet.Person, tbNameSeartch.Text);
        }

        private void btSave_Click(object sender, EventArgs e) {

            personDataGridView.CurrentRow.Cells[1].Value = tbName.Text;
            personDataGridView.CurrentRow.Cells[2].Value = dpDate.Value;
            personDataGridView.CurrentRow.Cells[3].Value = tbTelphone.Text;
            personDataGridView.CurrentRow.Cells[4].Value = tbMemo.Text;

            this.Validate();
            this.personBindingSource.EndEdit();
            this.tableAdapterManager.UpdateAll(this.infosys202129DataSet);
        }

        private void personDataGridView_SelectionChanged(object sender, EventArgs e) {
            if (personDataGridView.CurrentRow == null) return;
            tbName.Text = personDataGridView.CurrentRow.Cells[1].Value.ToString();
            dpDate.Value = (DateTime)personDataGridView.CurrentRow.Cells[2].Value;
            tbTelphone.Text = personDataGridView.CurrentRow.Cells[3].Value.ToString();
            tbMemo.Text = personDataGridView.CurrentRow.Cells[4].Value.ToString();
        }

        private void btBirthdayFilter_Click(object sender, EventArgs e) {
            this.personTableAdapter.FillByBirthday(infosys202129DataSet.Person,dpDate2.Value.ToString());

        }

        
    }
}
