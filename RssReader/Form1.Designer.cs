
namespace RssReader
{
    partial class Form1
    {
        /// <summary>
        /// 必要なデザイナー変数です。
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// 使用中のリソースをすべてクリーンアップします。
        /// </summary>
        /// <param name="disposing">マネージド リソースを破棄する場合は true を指定し、その他の場合は false を指定します。</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows フォーム デザイナーで生成されたコード

        /// <summary>
        /// デザイナー サポートに必要なメソッドです。このメソッドの内容を
        /// コード エディターで変更しないでください。
        /// </summary>
        private void InitializeComponent()
        {
            this.label1 = new System.Windows.Forms.Label();
            this.tbUrl = new System.Windows.Forms.TextBox();
            this.lbTitles = new System.Windows.Forms.ListBox();
            this.btRead = new System.Windows.Forms.Button();
            this.LB2 = new System.Windows.Forms.Label();
            this.Bt4 = new System.Windows.Forms.Button();
            this.ymd = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("MS UI Gothic", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(128)));
            this.label1.Location = new System.Drawing.Point(16, 18);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(206, 42);
            this.label1.TabIndex = 0;
            this.label1.Text = "RssReader";
            // 
            // tbUrl
            // 
            this.tbUrl.Font = new System.Drawing.Font("MS UI Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(128)));
            this.tbUrl.Location = new System.Drawing.Point(230, 27);
            this.tbUrl.Margin = new System.Windows.Forms.Padding(4);
            this.tbUrl.Name = "tbUrl";
            this.tbUrl.Size = new System.Drawing.Size(844, 35);
            this.tbUrl.TabIndex = 1;
            // 
            // lbTitles
            // 
            this.lbTitles.FormattingEnabled = true;
            this.lbTitles.ItemHeight = 21;
            this.lbTitles.Location = new System.Drawing.Point(23, 92);
            this.lbTitles.Margin = new System.Windows.Forms.Padding(4);
            this.lbTitles.Name = "lbTitles";
            this.lbTitles.Size = new System.Drawing.Size(392, 760);
            this.lbTitles.TabIndex = 2;
            // 
            // btRead
            // 
            this.btRead.Location = new System.Drawing.Point(1084, 31);
            this.btRead.Margin = new System.Windows.Forms.Padding(4);
            this.btRead.Name = "btRead";
            this.btRead.Size = new System.Drawing.Size(103, 32);
            this.btRead.TabIndex = 4;
            this.btRead.Text = "読込み";
            this.btRead.UseVisualStyleBackColor = true;
            this.btRead.Click += new System.EventHandler(this.btRead_Click);
            // 
            // LB2
            // 
            this.LB2.BackColor = System.Drawing.SystemColors.ControlLightLight;
            this.LB2.Location = new System.Drawing.Point(505, 419);
            this.LB2.Name = "LB2";
            this.LB2.Size = new System.Drawing.Size(1048, 652);
            this.LB2.TabIndex = 5;
            // 
            // Bt4
            // 
            this.Bt4.Location = new System.Drawing.Point(300, 958);
            this.Bt4.Name = "Bt4";
            this.Bt4.Size = new System.Drawing.Size(105, 50);
            this.Bt4.TabIndex = 6;
            this.Bt4.Text = "表示";
            this.Bt4.UseVisualStyleBackColor = true;
            // 
            // ymd
            // 
            this.ymd.BackColor = System.Drawing.SystemColors.ControlLightLight;
            this.ymd.Location = new System.Drawing.Point(1179, 149);
            this.ymd.Name = "ymd";
            this.ymd.Size = new System.Drawing.Size(324, 43);
            this.ymd.TabIndex = 7;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(11F, 21F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1665, 1113);
            this.Controls.Add(this.ymd);
            this.Controls.Add(this.Bt4);
            this.Controls.Add(this.LB2);
            this.Controls.Add(this.btRead);
            this.Controls.Add(this.lbTitles);
            this.Controls.Add(this.tbUrl);
            this.Controls.Add(this.label1);
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "Form1";
            this.Text = "32085";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox tbUrl;
        private System.Windows.Forms.ListBox lbTitles;
        private System.Windows.Forms.Button btRead;
        private System.Windows.Forms.Label LB2;
        private System.Windows.Forms.Button Bt4;
        private System.Windows.Forms.Label ymd;
    }
}

