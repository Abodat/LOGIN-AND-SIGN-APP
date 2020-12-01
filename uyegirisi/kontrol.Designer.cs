namespace uyegirisi
{
    partial class kontrol
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.label3 = new System.Windows.Forms.Label();
            this.kod = new System.Windows.Forms.TextBox();
            this.onay = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label3.Location = new System.Drawing.Point(12, 18);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(94, 16);
            this.label3.TabIndex = 12;
            this.label3.Text = "Kodu Giriniz:";
            // 
            // kod
            // 
            this.kod.Location = new System.Drawing.Point(12, 37);
            this.kod.Name = "kod";
            this.kod.Size = new System.Drawing.Size(226, 20);
            this.kod.TabIndex = 11;
            // 
            // onay
            // 
            this.onay.Location = new System.Drawing.Point(15, 72);
            this.onay.Name = "onay";
            this.onay.Size = new System.Drawing.Size(135, 23);
            this.onay.TabIndex = 13;
            this.onay.Text = "Onayla";
            this.onay.UseVisualStyleBackColor = true;
            this.onay.Click += new System.EventHandler(this.onay_Click);
            // 
            // kontrol
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(247, 107);
            this.Controls.Add(this.onay);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.kod);
            this.Name = "kontrol";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "kontrol";
            this.Load += new System.EventHandler(this.kontrol_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox kod;
        private System.Windows.Forms.Button onay;
    }
}