
namespace WeatherApp {
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
            this.Cb1 = new System.Windows.Forms.ComboBox();
            this.Bt1 = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.Tb1 = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // Cb1
            // 
            this.Cb1.FormattingEnabled = true;
            this.Cb1.Location = new System.Drawing.Point(317, 112);
            this.Cb1.Name = "Cb1";
            this.Cb1.Size = new System.Drawing.Size(350, 29);
            this.Cb1.TabIndex = 0;
            // 
            // Bt1
            // 
            this.Bt1.Location = new System.Drawing.Point(784, 104);
            this.Bt1.Name = "Bt1";
            this.Bt1.Size = new System.Drawing.Size(176, 43);
            this.Bt1.TabIndex = 1;
            this.Bt1.Text = "天気表示";
            this.Bt1.UseVisualStyleBackColor = true;
            this.Bt1.Click += new System.EventHandler(this.Bt1_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("MS UI Gothic", 14.14286F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(128)));
            this.label1.Location = new System.Drawing.Point(101, 104);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(177, 34);
            this.label1.TabIndex = 2;
            this.label1.Text = "地域を表示";
            // 
            // Tb1
            // 
            this.Tb1.Location = new System.Drawing.Point(208, 263);
            this.Tb1.Multiline = true;
            this.Tb1.Name = "Tb1";
            this.Tb1.Size = new System.Drawing.Size(647, 352);
            this.Tb1.TabIndex = 3;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(11F, 21F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1264, 785);
            this.Controls.Add(this.Tb1);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.Bt1);
            this.Controls.Add(this.Cb1);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ComboBox Cb1;
        private System.Windows.Forms.Button Bt1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox Tb1;
    }
}

