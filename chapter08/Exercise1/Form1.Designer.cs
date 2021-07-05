
namespace Exercise1 {
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
            this.tbOutput = new System.Windows.Forms.TextBox();
            this.btAction = new System.Windows.Forms.Button();
            this.nudYear = new System.Windows.Forms.NumericUpDown();
            this.nudDay = new System.Windows.Forms.NumericUpDown();
            this.nudMonrh = new System.Windows.Forms.NumericUpDown();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.tbU = new System.Windows.Forms.TextBox();
            this.n = new System.Windows.Forms.TextBox();
            this.dtm = new System.Windows.Forms.DateTimePicker();
            ((System.ComponentModel.ISupportInitialize)(this.nudYear)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.nudDay)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.nudMonrh)).BeginInit();
            this.SuspendLayout();
            // 
            // tbOutput
            // 
            this.tbOutput.Font = new System.Drawing.Font("ＭＳ ゴシック", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(128)));
            this.tbOutput.Location = new System.Drawing.Point(87, 340);
            this.tbOutput.Name = "tbOutput";
            this.tbOutput.Size = new System.Drawing.Size(287, 34);
            this.tbOutput.TabIndex = 0;
            this.tbOutput.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            // 
            // btAction
            // 
            this.btAction.Location = new System.Drawing.Point(458, 340);
            this.btAction.Name = "btAction";
            this.btAction.Size = new System.Drawing.Size(108, 32);
            this.btAction.TabIndex = 1;
            this.btAction.Text = "実行";
            this.btAction.UseVisualStyleBackColor = true;
            this.btAction.Click += new System.EventHandler(this.btAction_Click);
            // 
            // nudYear
            // 
            this.nudYear.Font = new System.Drawing.Font("ＭＳ 明朝", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(128)));
            this.nudYear.Location = new System.Drawing.Point(56, 55);
            this.nudYear.Maximum = new decimal(new int[] {
            2200,
            0,
            0,
            0});
            this.nudYear.Minimum = new decimal(new int[] {
            1990,
            0,
            0,
            0});
            this.nudYear.Name = "nudYear";
            this.nudYear.Size = new System.Drawing.Size(120, 31);
            this.nudYear.TabIndex = 2;
            this.nudYear.ThousandsSeparator = true;
            this.nudYear.Value = new decimal(new int[] {
            1990,
            0,
            0,
            0});
            // 
            // nudDay
            // 
            this.nudDay.Font = new System.Drawing.Font("ＭＳ 明朝", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(128)));
            this.nudDay.Location = new System.Drawing.Point(541, 55);
            this.nudDay.Maximum = new decimal(new int[] {
            31,
            0,
            0,
            0});
            this.nudDay.Minimum = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.nudDay.Name = "nudDay";
            this.nudDay.Size = new System.Drawing.Size(120, 31);
            this.nudDay.TabIndex = 3;
            this.nudDay.Value = new decimal(new int[] {
            1,
            0,
            0,
            0});
            // 
            // nudMonrh
            // 
            this.nudMonrh.Font = new System.Drawing.Font("ＭＳ 明朝", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(128)));
            this.nudMonrh.Location = new System.Drawing.Point(304, 55);
            this.nudMonrh.Maximum = new decimal(new int[] {
            12,
            0,
            0,
            0});
            this.nudMonrh.Minimum = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.nudMonrh.Name = "nudMonrh";
            this.nudMonrh.Size = new System.Drawing.Size(120, 31);
            this.nudMonrh.TabIndex = 4;
            this.nudMonrh.Value = new decimal(new int[] {
            1,
            0,
            0,
            0});
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("MS UI Gothic", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(128)));
            this.label1.Location = new System.Drawing.Point(182, 62);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(34, 24);
            this.label1.TabIndex = 5;
            this.label1.Text = "年";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("MS UI Gothic", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(128)));
            this.label2.Location = new System.Drawing.Point(667, 62);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(34, 24);
            this.label2.TabIndex = 6;
            this.label2.Text = "日";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("MS UI Gothic", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(128)));
            this.label3.Location = new System.Drawing.Point(430, 62);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(34, 24);
            this.label3.TabIndex = 7;
            this.label3.Text = "月";
            // 
            // tbU
            // 
            this.tbU.Font = new System.Drawing.Font("ＭＳ ゴシック", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(128)));
            this.tbU.Location = new System.Drawing.Point(87, 398);
            this.tbU.Name = "tbU";
            this.tbU.Size = new System.Drawing.Size(287, 34);
            this.tbU.TabIndex = 8;
            this.tbU.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            // 
            // n
            // 
            this.n.Font = new System.Drawing.Font("ＭＳ ゴシック", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(128)));
            this.n.Location = new System.Drawing.Point(87, 281);
            this.n.Name = "n";
            this.n.Size = new System.Drawing.Size(287, 34);
            this.n.TabIndex = 9;
            // 
            // dtm
            // 
            this.dtm.Location = new System.Drawing.Point(56, 122);
            this.dtm.Name = "dtm";
            this.dtm.Size = new System.Drawing.Size(200, 19);
            this.dtm.TabIndex = 10;
            this.dtm.Value = new System.DateTime(2001, 4, 25, 0, 0, 0, 0);
            this.dtm.ValueChanged += new System.EventHandler(this.dtm_ValueChanged);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(825, 476);
            this.Controls.Add(this.dtm);
            this.Controls.Add(this.n);
            this.Controls.Add(this.tbU);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.nudMonrh);
            this.Controls.Add(this.nudDay);
            this.Controls.Add(this.nudYear);
            this.Controls.Add(this.btAction);
            this.Controls.Add(this.tbOutput);
            this.Name = "Form1";
            this.Text = "Form1";
            ((System.ComponentModel.ISupportInitialize)(this.nudYear)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.nudDay)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.nudMonrh)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox tbOutput;
        private System.Windows.Forms.Button btAction;
        private System.Windows.Forms.NumericUpDown nudYear;
        private System.Windows.Forms.NumericUpDown nudDay;
        private System.Windows.Forms.NumericUpDown nudMonrh;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox tbU;
        private System.Windows.Forms.TextBox n;
        private System.Windows.Forms.DateTimePicker dtm;
    }
}

