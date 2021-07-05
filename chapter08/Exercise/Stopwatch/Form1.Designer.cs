
namespace Stopwatch {
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
            this.btStart = new System.Windows.Forms.Button();
            this.btR = new System.Windows.Forms.Button();
            this.btRp = new System.Windows.Forms.Button();
            this.btStop = new System.Windows.Forms.Button();
            this.timelistbox = new System.Windows.Forms.ListBox();
            this.lbt = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // btStart
            // 
            this.btStart.Font = new System.Drawing.Font("MS UI Gothic", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(128)));
            this.btStart.Location = new System.Drawing.Point(49, 193);
            this.btStart.Name = "btStart";
            this.btStart.Size = new System.Drawing.Size(147, 77);
            this.btStart.TabIndex = 0;
            this.btStart.Text = "スタート";
            this.btStart.UseVisualStyleBackColor = true;
            this.btStart.Click += new System.EventHandler(this.btStart_Click);
            // 
            // btR
            // 
            this.btR.Font = new System.Drawing.Font("MS UI Gothic", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(128)));
            this.btR.Location = new System.Drawing.Point(244, 193);
            this.btR.Name = "btR";
            this.btR.Size = new System.Drawing.Size(147, 77);
            this.btR.TabIndex = 1;
            this.btR.Text = "リセット";
            this.btR.UseVisualStyleBackColor = true;
            // 
            // btRp
            // 
            this.btRp.FlatStyle = System.Windows.Forms.FlatStyle.System;
            this.btRp.Font = new System.Drawing.Font("MS UI Gothic", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(128)));
            this.btRp.Location = new System.Drawing.Point(244, 331);
            this.btRp.Name = "btRp";
            this.btRp.Size = new System.Drawing.Size(147, 77);
            this.btRp.TabIndex = 2;
            this.btRp.Text = "ラップ";
            this.btRp.UseVisualStyleBackColor = true;
            // 
            // btStop
            // 
            this.btStop.Font = new System.Drawing.Font("MS UI Gothic", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(128)));
            this.btStop.Location = new System.Drawing.Point(49, 331);
            this.btStop.Name = "btStop";
            this.btStop.Size = new System.Drawing.Size(147, 77);
            this.btStop.TabIndex = 3;
            this.btStop.Text = "ストップ";
            this.btStop.UseVisualStyleBackColor = true;
            // 
            // timelistbox
            // 
            this.timelistbox.FormattingEnabled = true;
            this.timelistbox.ItemHeight = 12;
            this.timelistbox.Location = new System.Drawing.Point(467, 128);
            this.timelistbox.Name = "timelistbox";
            this.timelistbox.Size = new System.Drawing.Size(262, 280);
            this.timelistbox.TabIndex = 4;
            // 
            // lbt
            // 
            this.lbt.AutoSize = true;
            this.lbt.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.lbt.Font = new System.Drawing.Font("ＭＳ ゴシック", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(128)));
            this.lbt.Location = new System.Drawing.Point(161, 97);
            this.lbt.Name = "lbt";
            this.lbt.Size = new System.Drawing.Size(96, 27);
            this.lbt.TabIndex = 5;
            this.lbt.Text = "label1";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.lbt);
            this.Controls.Add(this.timelistbox);
            this.Controls.Add(this.btStop);
            this.Controls.Add(this.btRp);
            this.Controls.Add(this.btR);
            this.Controls.Add(this.btStart);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btStart;
        private System.Windows.Forms.Button btR;
        private System.Windows.Forms.Button btRp;
        private System.Windows.Forms.Button btStop;
        private System.Windows.Forms.ListBox timelistbox;
        private System.Windows.Forms.Label lbt;
    }
}

