
namespace Exercise2 {
    partial class Form1 {
        /// <summary>
        /// 必要なデザイナー変数です。
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// 使用中のリソースをすべてクリーンアップします。
        /// </summary>
        /// <param name="disposing">マネージド リソースを破棄する場合は true を指定し、その他の場合は false を指定します。</param>
        protected override void Dispose(bool disposing) {
            if (disposing && (components != null)) {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows フォーム デザイナーで生成されたコード

        /// <summary>
        /// デザイナー サポートに必要なメソッドです。このメソッドの内容を
        /// コード エディターで変更しないでください。
        /// </summary>
        private void InitializeComponent() {
            this.bt1 = new System.Windows.Forms.Button();
            this.ofdOpenFile = new System.Windows.Forms.OpenFileDialog();
            this.btChangeFile = new System.Windows.Forms.Button();
            this.btCahnge = new System.Windows.Forms.Button();
            this.sfdSaveFile = new System.Windows.Forms.SaveFileDialog();
            this.SuspendLayout();
            // 
            // bt1
            // 
            this.bt1.Location = new System.Drawing.Point(21, 23);
            this.bt1.Name = "bt1";
            this.bt1.Size = new System.Drawing.Size(122, 83);
            this.bt1.TabIndex = 1;
            this.bt1.Text = "開く...";
            this.bt1.UseVisualStyleBackColor = true;
            this.bt1.Click += new System.EventHandler(this.bt1_Click);
            // 
            // ofdOpenFile
            // 
            this.ofdOpenFile.FileName = "ofdOpenFIle";
            // 
            // btChangeFile
            // 
            this.btChangeFile.Location = new System.Drawing.Point(21, 129);
            this.btChangeFile.Name = "btChangeFile";
            this.btChangeFile.Size = new System.Drawing.Size(122, 83);
            this.btChangeFile.TabIndex = 2;
            this.btChangeFile.Text = "指定";
            this.btChangeFile.UseVisualStyleBackColor = true;
            this.btChangeFile.Click += new System.EventHandler(this.btChangeFile_Click);
            // 
            // btCahnge
            // 
            this.btCahnge.Location = new System.Drawing.Point(21, 234);
            this.btCahnge.Name = "btCahnge";
            this.btCahnge.Size = new System.Drawing.Size(122, 83);
            this.btCahnge.TabIndex = 3;
            this.btCahnge.Text = "行番号追加";
            this.btCahnge.UseVisualStyleBackColor = true;
            this.btCahnge.Click += new System.EventHandler(this.btCahnge_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.btCahnge);
            this.Controls.Add(this.btChangeFile);
            this.Controls.Add(this.bt1);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.Button bt1;
        private System.Windows.Forms.OpenFileDialog ofdOpenFile;
        private System.Windows.Forms.Button btChangeFile;
        private System.Windows.Forms.Button btCahnge;
        private System.Windows.Forms.SaveFileDialog sfdSaveFile;
    }
}

