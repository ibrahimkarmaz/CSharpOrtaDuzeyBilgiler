
namespace DalegateKullanimi
{
    partial class Form1
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
            this.LBIslemler = new System.Windows.Forms.ListBox();
            this.label1 = new System.Windows.Forms.Label();
            this.TBSayi1 = new System.Windows.Forms.TextBox();
            this.TBSayi2 = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.BtnHesapla = new System.Windows.Forms.Button();
            this.BtnSoruCevap = new System.Windows.Forms.Button();
            this.BtnTarihSaat = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // LBIslemler
            // 
            this.LBIslemler.FormattingEnabled = true;
            this.LBIslemler.Location = new System.Drawing.Point(16, 120);
            this.LBIslemler.Name = "LBIslemler";
            this.LBIslemler.Size = new System.Drawing.Size(163, 147);
            this.LBIslemler.TabIndex = 0;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(12, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(42, 13);
            this.label1.TabIndex = 1;
            this.label1.Text = "1. Sayı:";
            // 
            // TBSayi1
            // 
            this.TBSayi1.Location = new System.Drawing.Point(60, 6);
            this.TBSayi1.Name = "TBSayi1";
            this.TBSayi1.Size = new System.Drawing.Size(122, 20);
            this.TBSayi1.TabIndex = 2;
            // 
            // TBSayi2
            // 
            this.TBSayi2.Location = new System.Drawing.Point(60, 32);
            this.TBSayi2.Name = "TBSayi2";
            this.TBSayi2.Size = new System.Drawing.Size(122, 20);
            this.TBSayi2.TabIndex = 4;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(12, 35);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(42, 13);
            this.label2.TabIndex = 3;
            this.label2.Text = "2. Sayı:";
            // 
            // BtnHesapla
            // 
            this.BtnHesapla.Location = new System.Drawing.Point(15, 58);
            this.BtnHesapla.Name = "BtnHesapla";
            this.BtnHesapla.Size = new System.Drawing.Size(167, 23);
            this.BtnHesapla.TabIndex = 5;
            this.BtnHesapla.Text = "HESAPLA";
            this.BtnHesapla.UseVisualStyleBackColor = true;
            this.BtnHesapla.Click += new System.EventHandler(this.BtnHesapla_Click);
            // 
            // BtnSoruCevap
            // 
            this.BtnSoruCevap.Location = new System.Drawing.Point(15, 87);
            this.BtnSoruCevap.Name = "BtnSoruCevap";
            this.BtnSoruCevap.Size = new System.Drawing.Size(167, 23);
            this.BtnSoruCevap.TabIndex = 6;
            this.BtnSoruCevap.Text = "SORU-CEVAP(1.Sayi Textbox)";
            this.BtnSoruCevap.UseVisualStyleBackColor = true;
            this.BtnSoruCevap.Click += new System.EventHandler(this.BtnSoruCevap_Click);
            // 
            // BtnTarihSaat
            // 
            this.BtnTarihSaat.Location = new System.Drawing.Point(16, 280);
            this.BtnTarihSaat.Name = "BtnTarihSaat";
            this.BtnTarihSaat.Size = new System.Drawing.Size(167, 23);
            this.BtnTarihSaat.TabIndex = 7;
            this.BtnTarihSaat.Text = "TARİH SAAT";
            this.BtnTarihSaat.UseVisualStyleBackColor = true;
            this.BtnTarihSaat.Click += new System.EventHandler(this.BtnTarihSaat_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(195, 315);
            this.Controls.Add(this.BtnTarihSaat);
            this.Controls.Add(this.BtnSoruCevap);
            this.Controls.Add(this.BtnHesapla);
            this.Controls.Add(this.TBSayi2);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.TBSayi1);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.LBIslemler);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ListBox LBIslemler;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox TBSayi1;
        private System.Windows.Forms.TextBox TBSayi2;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button BtnHesapla;
        private System.Windows.Forms.Button BtnSoruCevap;
        private System.Windows.Forms.Button BtnTarihSaat;
    }
}

