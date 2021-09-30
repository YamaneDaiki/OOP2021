
namespace Exercise3 {
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
            this.bt2 = new System.Windows.Forms.Button();
            this.Ofd1 = new System.Windows.Forms.OpenFileDialog();
            this.Ofd2 = new System.Windows.Forms.OpenFileDialog();
            this.SuspendLayout();
            // 
            // bt1
            // 
            this.bt1.Location = new System.Drawing.Point(53, 56);
            this.bt1.Name = "bt1";
            this.bt1.Size = new System.Drawing.Size(101, 42);
            this.bt1.TabIndex = 0;
            this.bt1.Text = "開く...";
            this.bt1.UseVisualStyleBackColor = true;
            this.bt1.Click += new System.EventHandler(this.bt1_Click);
            // 
            // bt2
            // 
            this.bt2.Location = new System.Drawing.Point(53, 143);
            this.bt2.Name = "bt2";
            this.bt2.Size = new System.Drawing.Size(101, 42);
            this.bt2.TabIndex = 1;
            this.bt2.Text = "開く...";
            this.bt2.UseVisualStyleBackColor = true;
            // 
            // Ofd1
            // 
            this.Ofd1.FileName = "openFileDialog1";
            // 
            // Ofd2
            // 
            this.Ofd2.FileName = "openFileDialog2";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.bt2);
            this.Controls.Add(this.bt1);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button bt1;
        private System.Windows.Forms.Button bt2;
        private System.Windows.Forms.OpenFileDialog Ofd1;
        private System.Windows.Forms.OpenFileDialog Ofd2;
    }
}

