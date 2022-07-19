
namespace Ders7_Stuct_Kullanimi
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
            this.TxtPlakaNo = new System.Windows.Forms.TextBox();
            this.TxtSehirAd = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.TxtUnlu = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.TxtRenk = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.button1 = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(12, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(73, 18);
            this.label1.TabIndex = 0;
            this.label1.Text = "Plaka No:";
            // 
            // TxtPlakaNo
            // 
            this.TxtPlakaNo.Location = new System.Drawing.Point(91, 6);
            this.TxtPlakaNo.Name = "TxtPlakaNo";
            this.TxtPlakaNo.Size = new System.Drawing.Size(152, 24);
            this.TxtPlakaNo.TabIndex = 1;
            this.TxtPlakaNo.Text = "d";
            // 
            // TxtSehirAd
            // 
            this.TxtSehirAd.Location = new System.Drawing.Point(91, 36);
            this.TxtSehirAd.Name = "TxtSehirAd";
            this.TxtSehirAd.Size = new System.Drawing.Size(152, 24);
            this.TxtSehirAd.TabIndex = 3;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(12, 39);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(67, 18);
            this.label2.TabIndex = 2;
            this.label2.Text = "Şehir Ad:";
            // 
            // TxtUnlu
            // 
            this.TxtUnlu.Location = new System.Drawing.Point(15, 90);
            this.TxtUnlu.Multiline = true;
            this.TxtUnlu.Name = "TxtUnlu";
            this.TxtUnlu.Size = new System.Drawing.Size(226, 61);
            this.TxtUnlu.TabIndex = 5;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(12, 69);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(122, 18);
            this.label3.TabIndex = 4;
            this.label3.Text = "Ünlü Olduğu Şey:";
            // 
            // TxtRenk
            // 
            this.TxtRenk.Location = new System.Drawing.Point(91, 157);
            this.TxtRenk.Name = "TxtRenk";
            this.TxtRenk.Size = new System.Drawing.Size(152, 24);
            this.TxtRenk.TabIndex = 7;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(12, 160);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(47, 18);
            this.label4.TabIndex = 6;
            this.label4.Text = "Renk:";
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(15, 197);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(228, 39);
            this.button1.TabIndex = 8;
            this.button1.Text = "Kaydet";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(15, 242);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(228, 39);
            this.button2.TabIndex = 9;
            this.button2.Text = "button2";
            this.button2.UseVisualStyleBackColor = true;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 18F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(253, 291);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.TxtRenk);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.TxtUnlu);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.TxtSehirAd);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.TxtPlakaNo);
            this.Controls.Add(this.label1);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "Form1";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox TxtPlakaNo;
        private System.Windows.Forms.TextBox TxtSehirAd;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox TxtUnlu;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox TxtRenk;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button button2;
    }
}

