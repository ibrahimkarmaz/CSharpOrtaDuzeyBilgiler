
namespace SezarSifrelmeUygulamasi
{
    partial class SifrelemeUygulamasi
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
            this.Cbm_Seviye = new System.Windows.Forms.ComboBox();
            this.TxtSifrelenmisMetin = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.TxtAnaMetin = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.linkLabel1 = new System.Windows.Forms.LinkLabel();
            this.SuspendLayout();
            // 
            // Cbm_Seviye
            // 
            this.Cbm_Seviye.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.Cbm_Seviye.FormattingEnabled = true;
            this.Cbm_Seviye.Items.AddRange(new object[] {
            "Seviye 1 Şifreleme",
            "Seviye 2 Şifreleme",
            "Seviye 3 Şifreleme",
            "Seviye 4 Şifreleme",
            "Seviye 5 Şifreleme"});
            this.Cbm_Seviye.Location = new System.Drawing.Point(401, 337);
            this.Cbm_Seviye.Margin = new System.Windows.Forms.Padding(6, 6, 6, 6);
            this.Cbm_Seviye.Name = "Cbm_Seviye";
            this.Cbm_Seviye.Size = new System.Drawing.Size(374, 34);
            this.Cbm_Seviye.TabIndex = 2;
            // 
            // TxtSifrelenmisMetin
            // 
            this.TxtSifrelenmisMetin.Location = new System.Drawing.Point(401, 41);
            this.TxtSifrelenmisMetin.Margin = new System.Windows.Forms.Padding(6);
            this.TxtSifrelenmisMetin.Multiline = true;
            this.TxtSifrelenmisMetin.Name = "TxtSifrelenmisMetin";
            this.TxtSifrelenmisMetin.Size = new System.Drawing.Size(374, 288);
            this.TxtSifrelenmisMetin.TabIndex = 4;
            this.TxtSifrelenmisMetin.TextChanged += new System.EventHandler(this.TxtSifrelenmisMetin_TextChanged);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(396, 9);
            this.label2.Margin = new System.Windows.Forms.Padding(6, 0, 6, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(172, 26);
            this.label2.TabIndex = 3;
            this.label2.Text = "Şifrelenmiş Metin:";
            // 
            // TxtAnaMetin
            // 
            this.TxtAnaMetin.Location = new System.Drawing.Point(15, 41);
            this.TxtAnaMetin.Margin = new System.Windows.Forms.Padding(6);
            this.TxtAnaMetin.Multiline = true;
            this.TxtAnaMetin.Name = "TxtAnaMetin";
            this.TxtAnaMetin.Size = new System.Drawing.Size(374, 330);
            this.TxtAnaMetin.TabIndex = 1;
            this.TxtAnaMetin.TextChanged += new System.EventHandler(this.TxtAnaMetin_TextChanged);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(10, 9);
            this.label1.Margin = new System.Windows.Forms.Padding(6, 0, 6, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(184, 26);
            this.label1.TabIndex = 0;
            this.label1.Text = "Şifrelenecek Metin:";
            // 
            // linkLabel1
            // 
            this.linkLabel1.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.linkLabel1.Location = new System.Drawing.Point(0, 380);
            this.linkLabel1.Name = "linkLabel1";
            this.linkLabel1.Size = new System.Drawing.Size(809, 26);
            this.linkLabel1.TabIndex = 5;
            this.linkLabel1.TabStop = true;
            this.linkLabel1.Text = "Şifreleme Uygulaması V2.0 Satın Al";
            this.linkLabel1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // SifrelemeUygulamasi
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(12F, 26F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Gold;
            this.ClientSize = new System.Drawing.Size(809, 406);
            this.Controls.Add(this.linkLabel1);
            this.Controls.Add(this.TxtSifrelenmisMetin);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.Cbm_Seviye);
            this.Controls.Add(this.TxtAnaMetin);
            this.Controls.Add(this.label1);
            this.Font = new System.Drawing.Font("Comic Sans MS", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.Margin = new System.Windows.Forms.Padding(6, 6, 6, 6);
            this.Name = "SifrelemeUygulamasi";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Şifreleme Uygulamasi V1.0 ÜCRETSİZ VERSİYON";
            this.Load += new System.EventHandler(this.SifrelemeUygulamasi_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.ComboBox Cbm_Seviye;
        private System.Windows.Forms.TextBox TxtSifrelenmisMetin;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox TxtAnaMetin;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.LinkLabel linkLabel1;
    }
}

