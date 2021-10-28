﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Runtime.Serialization.Formatters.Binary;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CarReportSystem {
    public partial class fmMain : Form {
        BindingList<CarReport> listcarReports = new BindingList<CarReport>();
        public fmMain() {
            InitializeComponent();
            //dgvRegistData.DataSource = listcarReports;
        }

        private void btExit_Click(object sender, EventArgs e) {
            Application.Exit();
        }
        //画像開くボタン
        private void btPictureOpen_Click(object sender, EventArgs e) {
            if (ofdPictureOpen.ShowDialog() == DialogResult.OK) {
                pbPicture.Image = Image.FromFile(ofdPictureOpen.FileName);
            }
        }
        //画像削除ボタン
        private void btPictureDelete_Click(object sender, EventArgs e) {
            pbPicture.Image = null;
        }
        //追加ボタン
        private void btDataAdd_Click(object sender, EventArgs e) {
            if (cbCarName.Text == "" || cbAuthor.Text == "") {
                MessageBox.Show("入力されていません");
                return;
            }
            var cr = new CarReport {
                Date = dtpDate.Value,
                Auther = cbAuthor.Text,
                Maker = selectedGroup(),
                CarName = cbCarName.Text,
                Report = tbReport.Text,
                Picture = pbPicture.Image
            };

            listcarReports.Add(cr);
            setCbAuthor(cbAuthor.Text);
            setCbCarName(cbCarName.Text);
        }


        private CarReport.MakerGroup selectedGroup() {
            foreach (var rb in gbMaker.Controls) {
                if (((RadioButton)rb).Checked) {
                    return (CarReport.MakerGroup)int.Parse((string)((RadioButton)rb).Tag);
                }
            }
            return CarReport.MakerGroup.その他;
        }

        //コンボボックスに記録者をセットする
        private void setCbAuthor(string author) {
            if (!cbAuthor.Items.Contains(author)) {
                cbAuthor.Items.Add(author);
            }

        }
        //コンボボックスに車名をセットする
        private void setCbCarName(string carname) {
            if (!cbCarName.Items.Contains(carname)) {
                cbCarName.Items.Add(carname);
            }
        }

        private void dgvRegistData_CellClick(object sender, DataGridViewCellEventArgs e) {
            if (e.RowIndex == -1) {
                return;
            }
            CarReport selectedCar = listcarReports[e.RowIndex];
            dtpDate.Value = selectedCar.Date;
            cbAuthor.Text = selectedCar.Auther;
            setMakerRadioButton(selectedCar.Maker);

            cbCarName.Text = selectedCar.CarName;
            tbReport.Text = selectedCar.Report;
            pbPicture.Image = selectedCar.Picture;
        }

        private void setMakerRadioButton(CarReport.MakerGroup mg) {
            switch (mg) {
                case CarReport.MakerGroup.トヨタ:
                    rbToyota.Checked = true;
                    break;
                case CarReport.MakerGroup.日産:
                    rbNissan.Checked = true;
                    break;
                case CarReport.MakerGroup.ホンダ:
                    rbHonda.Checked = true;
                    break;
                case CarReport.MakerGroup.スバル:
                    rbSubaru.Checked = true;
                    break;
                case CarReport.MakerGroup.外車:
                    rbImport.Checked = true;
                    break;
                default: //その他
                    rbOther.Checked = true;
                    break;
            }
        }
        //削除ボタン
        private void btDataDelete_Click(object sender, EventArgs e) {
            /*if (dgvRegistData.CurrentCell != null) {
                listcarReports.RemoveAt(dgvRegistData.CurrentRow.Index);
            }*/
        }

        //修正ボタン
        private void btDataCorrect_Click(object sender, EventArgs e) {
            //listcarReports[dgvRegistData.CurrentRow.Index].UpDate(dtpDate.Value, cbAuthor.Text, selectedGroup(), cbCarName.Text, tbReport.Text, pbPicture.Image);
            //dgvRegistData.Refresh(); //コントロールの強制再描画
        }

        //更新ボタンイベント処理
        private void btUpdate_Click(object sender, EventArgs e) {
            if (carReportDataGridView.CurrentRow == null) return;

            carReportDataGridView.CurrentRow.Cells[1].Value = dtpDate.Value;     //日付
            carReportDataGridView.CurrentRow.Cells[2].Value = cbAuthor.Text;     //記録者
            carReportDataGridView.CurrentRow.Cells[3].Value = selectedGroup();   //メーカー
            carReportDataGridView.CurrentRow.Cells[4].Value = cbCarName.Text;    //車名
            carReportDataGridView.CurrentRow.Cells[5].Value = tbReport.Text;     //日付

            //データベースへ反映
            this.Validate();
            this.carReportBindingSource.EndEdit();
            this.tableAdapterManager.UpdateAll(this.infosys202129DataSet);
#if false
            try {
                if (sfdFileSave.ShowDialog() == DialogResult.OK) {
                    //バイナリ形式でシリアル化
                    var bf = new BinaryFormatter();
                    using (FileStream fs = File.Open(sfdFileSave.FileName, FileMode.Create)) {
                        bf.Serialize(fs, listcarReports);
                    }
                }
            } catch (Exception ex) {
                MessageBox.Show(ex.Message);
            }
        }
#endif
        }
            private void btConnect_Click(object sender, EventArgs e) {
                // TODO: このコード行はデータを 'infosys202129DataSet.CarReport' テーブルに読み込みます。必要に応じて移動、または削除をしてください。
                this.carReportTableAdapter.Fill(this.infosys202129DataSet.CarReport);
#if false
            if (ofdFileOpen.ShowDialog() == DialogResult.OK) {
                try {
                    //バイナリ形式で逆シリアル化
                    var bf = new BinaryFormatter();
                    using (FileStream fs = File.Open(ofdFileOpen.FileName, FileMode.Open, FileAccess.Read)) {
                        //逆シリアル化して読み込む
                        listcarReports = (BindingList<CarReport>)bf.Deserialize(fs);
                        dgvRegistData.DataSource = null;
                        dgvRegistData.DataSource = listcarReports;
                    }
                } catch (System.Runtime.Serialization.SerializationException ex) {
                    MessageBox.Show(ex.Message);
                }

                //読み込んだデータを各コンボボックスに登録する
                for (int i = 0; i < dgvRegistData.RowCount; i++) {
                    //データグリッドビューから取得
                    //setCbAuthor((string)dgvRegistData.Rows[i].Cells[1].Value);
                    //setCbCarName((string)dgvRegistData.Rows[i].Cells[3].Value);
                    setCbAuthor(listcarReports[i].Auther);
                    setCbAuthor(listcarReports[i].CarName);
                }
            }
#endif
            }

            private void fmMain_Load(object sender, EventArgs e) {
                //  dgvRegistData.Columns[5].Visible = false;
                //}

                //private void carReportBindingNavigatorSaveItem_Click(object sender, EventArgs e) {
                //    this.Validate();
                //    this.carReportBindingSource.EndEdit();
                //    this.tableAdapterManager.UpdateAll(this.infosys202129DataSet);

                //}
            }

        
    }
    }