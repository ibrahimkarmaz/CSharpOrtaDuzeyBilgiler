
namespace Ders17_GoogleTranslateUygulamasi
{
    partial class Form1
    {
        /// <summary>
        ///Gerekli tasarımcı değişkeni.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///Kullanılan tüm kaynakları temizleyin.
        /// </summary>
        ///<param name="disposing">yönetilen kaynaklar dispose edilmeliyse doğru; aksi halde yanlış.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer üretilen kod

        /// <summary>
        /// Tasarımcı desteği için gerekli metot - bu metodun 
        ///içeriğini kod düzenleyici ile değiştirmeyin.
        /// </summary>
        private void InitializeComponent()
        {
            this.label1 = new System.Windows.Forms.Label();
            this.RtxTR = new System.Windows.Forms.RichTextBox();
            this.RtxENG = new System.Windows.Forms.RichTextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.RbTR = new System.Windows.Forms.RadioButton();
            this.BtnTranslate = new System.Windows.Forms.Button();
            this.RbENG = new System.Windows.Forms.RadioButton();
            this.webBrowser1 = new System.Windows.Forms.WebBrowser();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(13, 9);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(58, 18);
            this.label1.TabIndex = 0;
            this.label1.Text = "Türkçe:";
            // 
            // RtxTR
            // 
            this.RtxTR.Location = new System.Drawing.Point(12, 30);
            this.RtxTR.Name = "RtxTR";
            this.RtxTR.Size = new System.Drawing.Size(262, 171);
            this.RtxTR.TabIndex = 1;
            this.RtxTR.Text = "";
            this.RtxTR.TextChanged += new System.EventHandler(this.RtxTR_TextChanged);
            // 
            // RtxENG
            // 
            this.RtxENG.Location = new System.Drawing.Point(280, 30);
            this.RtxENG.Name = "RtxENG";
            this.RtxENG.Size = new System.Drawing.Size(262, 171);
            this.RtxENG.TabIndex = 3;
            this.RtxENG.Text = "";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(281, 9);
            this.label2.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(60, 18);
            this.label2.TabIndex = 2;
            this.label2.Text = "English:";
            // 
            // RbTR
            // 
            this.RbTR.AutoSize = true;
            this.RbTR.Location = new System.Drawing.Point(190, 5);
            this.RbTR.Name = "RbTR";
            this.RbTR.Size = new System.Drawing.Size(84, 22);
            this.RbTR.TabIndex = 4;
            this.RbTR.TabStop = true;
            this.RbTR.Text = "TR-ENG";
            this.RbTR.UseVisualStyleBackColor = true;
            this.RbTR.CheckedChanged += new System.EventHandler(this.RbTR_CheckedChanged);
            // 
            // BtnTranslate
            // 
            this.BtnTranslate.BackColor = System.Drawing.Color.White;
            this.BtnTranslate.Location = new System.Drawing.Point(12, 205);
            this.BtnTranslate.Name = "BtnTranslate";
            this.BtnTranslate.Size = new System.Drawing.Size(530, 31);
            this.BtnTranslate.TabIndex = 5;
            this.BtnTranslate.Text = "Çeviri Yap";
            this.BtnTranslate.UseVisualStyleBackColor = false;
            this.BtnTranslate.Click += new System.EventHandler(this.BtnTranslate_Click);
            // 
            // RbENG
            // 
            this.RbENG.AutoSize = true;
            this.RbENG.Location = new System.Drawing.Point(458, 7);
            this.RbENG.Name = "RbENG";
            this.RbENG.Size = new System.Drawing.Size(84, 22);
            this.RbENG.TabIndex = 6;
            this.RbENG.TabStop = true;
            this.RbENG.Text = "ENG-TR";
            this.RbENG.UseVisualStyleBackColor = true;
            this.RbENG.CheckedChanged += new System.EventHandler(this.RbENG_CheckedChanged);
            // 
            // webBrowser1
            // 
            this.webBrowser1.Location = new System.Drawing.Point(491, 194);
            this.webBrowser1.MinimumSize = new System.Drawing.Size(20, 20);
            this.webBrowser1.Name = "webBrowser1";
            this.webBrowser1.Size = new System.Drawing.Size(250, 250);
            this.webBrowser1.TabIndex = 7;
            this.webBrowser1.Visible = false;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 18F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(128)))));
            this.ClientSize = new System.Drawing.Size(550, 243);
            this.Controls.Add(this.webBrowser1);
            this.Controls.Add(this.RbENG);
            this.Controls.Add(this.BtnTranslate);
            this.Controls.Add(this.RbTR);
            this.Controls.Add(this.RtxENG);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.RtxTR);
            this.Controls.Add(this.label1);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.Name = "Form1";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Google Translate Uygulamasi";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.RichTextBox RtxTR;
        private System.Windows.Forms.RichTextBox RtxENG;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.RadioButton RbTR;
        private System.Windows.Forms.Button BtnTranslate;
        private System.Windows.Forms.RadioButton RbENG;
        private System.Windows.Forms.WebBrowser webBrowser1;
    }
}

