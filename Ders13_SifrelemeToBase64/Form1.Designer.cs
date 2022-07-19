
namespace WindowsFormsApp1
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
            this.TxtAnaMetin = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.TxtSifreMetin = new System.Windows.Forms.TextBox();
            this.BtnSifrele = new System.Windows.Forms.Button();
            this.BtnSifreCoz = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // TxtAnaMetin
            // 
            this.TxtAnaMetin.Location = new System.Drawing.Point(119, 6);
            this.TxtAnaMetin.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.TxtAnaMetin.Name = "TxtAnaMetin";
            this.TxtAnaMetin.Size = new System.Drawing.Size(210, 26);
            this.TxtAnaMetin.TabIndex = 0;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(12, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(85, 20);
            this.label1.TabIndex = 1;
            this.label1.Text = "Ana Metin:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(12, 45);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(95, 20);
            this.label2.TabIndex = 3;
            this.label2.Text = "Şifreli Metin:";
            // 
            // TxtSifreMetin
            // 
            this.TxtSifreMetin.Location = new System.Drawing.Point(119, 42);
            this.TxtSifreMetin.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.TxtSifreMetin.Name = "TxtSifreMetin";
            this.TxtSifreMetin.Size = new System.Drawing.Size(210, 26);
            this.TxtSifreMetin.TabIndex = 2;
            // 
            // BtnSifrele
            // 
            this.BtnSifrele.Location = new System.Drawing.Point(119, 76);
            this.BtnSifrele.Name = "BtnSifrele";
            this.BtnSifrele.Size = new System.Drawing.Size(210, 27);
            this.BtnSifrele.TabIndex = 4;
            this.BtnSifrele.Text = "Şifrele";
            this.BtnSifrele.UseVisualStyleBackColor = true;
            this.BtnSifrele.Click += new System.EventHandler(this.BtnSifrele_Click);
            // 
            // BtnSifreCoz
            // 
            this.BtnSifreCoz.Location = new System.Drawing.Point(119, 109);
            this.BtnSifreCoz.Name = "BtnSifreCoz";
            this.BtnSifreCoz.Size = new System.Drawing.Size(210, 27);
            this.BtnSifreCoz.TabIndex = 5;
            this.BtnSifreCoz.Text = "Şifre Çöz";
            this.BtnSifreCoz.UseVisualStyleBackColor = true;
            this.BtnSifreCoz.Click += new System.EventHandler(this.BtnSifreCoz_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.HotTrack;
            this.ClientSize = new System.Drawing.Size(342, 146);
            this.Controls.Add(this.BtnSifreCoz);
            this.Controls.Add(this.BtnSifrele);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.TxtSifreMetin);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.TxtAnaMetin);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.Name = "Form1";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox TxtAnaMetin;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox TxtSifreMetin;
        private System.Windows.Forms.Button BtnSifrele;
        private System.Windows.Forms.Button BtnSifreCoz;
    }
}

