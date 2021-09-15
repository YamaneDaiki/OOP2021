
namespace RssReader {
    partial class Form2 {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing) {
            if (disposing && (components != null)) {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent() {
            this.Wb2 = new System.Windows.Forms.WebBrowser();
            this.SuspendLayout();
            // 
            // Wb2
            // 
            this.Wb2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.Wb2.Location = new System.Drawing.Point(0, 0);
            this.Wb2.MinimumSize = new System.Drawing.Size(20, 20);
            this.Wb2.Name = "Wb2";
            this.Wb2.Size = new System.Drawing.Size(1369, 976);
            this.Wb2.TabIndex = 0;
            // 
            // Form2
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(11F, 21F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1369, 976);
            this.Controls.Add(this.Wb2);
            this.Name = "Form2";
            this.Text = "Form2";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.WebBrowser Wb2;
    }
}