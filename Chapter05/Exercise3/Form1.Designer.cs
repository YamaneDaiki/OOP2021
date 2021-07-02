
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
            this.label2 = new System.Windows.Forms.Label();
            this.inputStrText = new System.Windows.Forms.TextBox();
            this.kucount = new System.Windows.Forms.Button();
            this.TextBoxSpaceCount = new System.Windows.Forms.TextBox();
            this.big = new System.Windows.Forms.Button();
            this.cu = new System.Windows.Forms.Button();
            this.TgText = new System.Windows.Forms.TextBox();
            this.textBox2 = new System.Windows.Forms.TextBox();
            this.button4 = new System.Windows.Forms.Button();
            this.Tb4 = new System.Windows.Forms.TextBox();
            this.Bt5 = new System.Windows.Forms.Button();
            this.Tb5 = new System.Windows.Forms.TextBox();
            this.Bt54 = new System.Windows.Forms.Button();
            this.Tb54 = new System.Windows.Forms.TextBox();
            this.Text54 = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("MS UI Gothic", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(128)));
            this.label2.Location = new System.Drawing.Point(12, 9);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(78, 21);
            this.label2.TabIndex = 0;
            this.label2.Text = "問題5.3";
            // 
            // inputStrText
            // 
            this.inputStrText.Font = new System.Drawing.Font("MS UI Gothic", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(128)));
            this.inputStrText.Location = new System.Drawing.Point(16, 68);
            this.inputStrText.Name = "inputStrText";
            this.inputStrText.Size = new System.Drawing.Size(626, 31);
            this.inputStrText.TabIndex = 1;
            // 
            // kucount
            // 
            this.kucount.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.kucount.Font = new System.Drawing.Font("ＭＳ ゴシック", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(128)));
            this.kucount.Location = new System.Drawing.Point(22, 113);
            this.kucount.Name = "kucount";
            this.kucount.Size = new System.Drawing.Size(220, 46);
            this.kucount.TabIndex = 2;
            this.kucount.Text = "空白をカウント";
            this.kucount.UseVisualStyleBackColor = true;
            this.kucount.Click += new System.EventHandler(this.kucount_Click);
            // 
            // TextBoxSpaceCount
            // 
            this.TextBoxSpaceCount.Font = new System.Drawing.Font("MS UI Gothic", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(128)));
            this.TextBoxSpaceCount.Location = new System.Drawing.Point(322, 121);
            this.TextBoxSpaceCount.Name = "TextBoxSpaceCount";
            this.TextBoxSpaceCount.Size = new System.Drawing.Size(136, 31);
            this.TextBoxSpaceCount.TabIndex = 3;
            // 
            // big
            // 
            this.big.Font = new System.Drawing.Font("MS UI Gothic", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(128)));
            this.big.Location = new System.Drawing.Point(22, 179);
            this.big.Name = "big";
            this.big.Size = new System.Drawing.Size(224, 47);
            this.big.TabIndex = 4;
            this.big.Text = "big → small";
            this.big.UseVisualStyleBackColor = true;
            this.big.Click += new System.EventHandler(this.big_Click);
            // 
            // cu
            // 
            this.cu.Font = new System.Drawing.Font("MS UI Gothic", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(128)));
            this.cu.Location = new System.Drawing.Point(26, 242);
            this.cu.Name = "cu";
            this.cu.Size = new System.Drawing.Size(220, 45);
            this.cu.TabIndex = 6;
            this.cu.Text = "単語カウント";
            this.cu.UseVisualStyleBackColor = true;
            this.cu.Click += new System.EventHandler(this.cu_Click);
            // 
            // TgText
            // 
            this.TgText.Font = new System.Drawing.Font("MS UI Gothic", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(128)));
            this.TgText.Location = new System.Drawing.Point(322, 249);
            this.TgText.Name = "TgText";
            this.TgText.Size = new System.Drawing.Size(320, 31);
            this.TgText.TabIndex = 7;
            // 
            // textBox2
            // 
            this.textBox2.Font = new System.Drawing.Font("MS UI Gothic", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(128)));
            this.textBox2.Location = new System.Drawing.Point(322, 179);
            this.textBox2.Name = "textBox2";
            this.textBox2.Size = new System.Drawing.Size(515, 31);
            this.textBox2.TabIndex = 8;
            // 
            // button4
            // 
            this.button4.Font = new System.Drawing.Font("MS UI Gothic", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(128)));
            this.button4.Location = new System.Drawing.Point(26, 293);
            this.button4.Name = "button4";
            this.button4.Size = new System.Drawing.Size(220, 45);
            this.button4.TabIndex = 9;
            this.button4.Text = "4文字以下の単語";
            this.button4.UseVisualStyleBackColor = true;
            this.button4.Click += new System.EventHandler(this.button4_Click);
            // 
            // Tb4
            // 
            this.Tb4.Font = new System.Drawing.Font("MS UI Gothic", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(128)));
            this.Tb4.Location = new System.Drawing.Point(332, 307);
            this.Tb4.Name = "Tb4";
            this.Tb4.Size = new System.Drawing.Size(320, 31);
            this.Tb4.TabIndex = 10;
            // 
            // Bt5
            // 
            this.Bt5.Font = new System.Drawing.Font("MS UI Gothic", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(128)));
            this.Bt5.Location = new System.Drawing.Point(22, 458);
            this.Bt5.Name = "Bt5";
            this.Bt5.Size = new System.Drawing.Size(220, 45);
            this.Bt5.TabIndex = 11;
            this.Bt5.Text = "連結";
            this.Bt5.UseVisualStyleBackColor = true;
            this.Bt5.Click += new System.EventHandler(this.Bt5_Click);
            // 
            // Tb5
            // 
            this.Tb5.Font = new System.Drawing.Font("MS UI Gothic", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(128)));
            this.Tb5.Location = new System.Drawing.Point(322, 465);
            this.Tb5.Name = "Tb5";
            this.Tb5.Size = new System.Drawing.Size(515, 31);
            this.Tb5.TabIndex = 12;
            // 
            // Bt54
            // 
            this.Bt54.Font = new System.Drawing.Font("ＭＳ ゴシック", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(128)));
            this.Bt54.Location = new System.Drawing.Point(79, 549);
            this.Bt54.Name = "Bt54";
            this.Bt54.Size = new System.Drawing.Size(220, 43);
            this.Bt54.TabIndex = 13;
            this.Bt54.Text = "5.4";
            this.Bt54.UseVisualStyleBackColor = true;
            this.Bt54.Click += new System.EventHandler(this.Bt54_Click);
            // 
            // Tb54
            // 
            this.Tb54.Font = new System.Drawing.Font("MS UI Gothic", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(128)));
            this.Tb54.Location = new System.Drawing.Point(322, 561);
            this.Tb54.Multiline = true;
            this.Tb54.Name = "Tb54";
            this.Tb54.Size = new System.Drawing.Size(684, 100);
            this.Tb54.TabIndex = 14;
            // 
            // Text54
            // 
            this.Text54.Font = new System.Drawing.Font("MS UI Gothic", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(128)));
            this.Text54.Location = new System.Drawing.Point(322, 521);
            this.Text54.Name = "Text54";
            this.Text54.Size = new System.Drawing.Size(515, 31);
            this.Text54.TabIndex = 15;
            // 
            // Form1
            // 
            this.ClientSize = new System.Drawing.Size(1100, 663);
            this.Controls.Add(this.Text54);
            this.Controls.Add(this.Tb54);
            this.Controls.Add(this.Bt54);
            this.Controls.Add(this.Tb5);
            this.Controls.Add(this.Bt5);
            this.Controls.Add(this.Tb4);
            this.Controls.Add(this.button4);
            this.Controls.Add(this.textBox2);
            this.Controls.Add(this.TgText);
            this.Controls.Add(this.cu);
            this.Controls.Add(this.big);
            this.Controls.Add(this.TextBoxSpaceCount);
            this.Controls.Add(this.kucount);
            this.Controls.Add(this.inputStrText);
            this.Controls.Add(this.label2);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox inputStrText;
        private System.Windows.Forms.Button kucount;
        private System.Windows.Forms.TextBox TextBoxSpaceCount;
        private System.Windows.Forms.Button big;
        private System.Windows.Forms.Button cu;
        private System.Windows.Forms.TextBox TgText;
        private System.Windows.Forms.TextBox textBox2;
        private System.Windows.Forms.Button button4;
        private System.Windows.Forms.TextBox Tb4;
        private System.Windows.Forms.Button Bt5;
        private System.Windows.Forms.TextBox Tb5;
        private System.Windows.Forms.Button Bt54;
        private System.Windows.Forms.TextBox Tb54;
        private System.Windows.Forms.TextBox Text54;
    }
}

