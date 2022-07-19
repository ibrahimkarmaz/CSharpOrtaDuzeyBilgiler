
namespace Ders5ResimEklemeCekme_Veritabani_
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
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.LblResimDosyaAd = new System.Windows.Forms.Label();
            this.ButonDosyaAc = new System.Windows.Forms.Button();
            this.TxtResimYolu = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.TxtKategori = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.TxtPuan = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.TxtFilmTur = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.TxtFilmAd = new System.Windows.Forms.TextBox();
            this.ButtonKaydet = new System.Windows.Forms.Button();
            this.ButonDuzenle = new System.Windows.Forms.Button();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(7, 31);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(64, 18);
            this.label1.TabIndex = 0;
            this.label1.Text = "Film Adı:";
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.LblResimDosyaAd);
            this.groupBox1.Controls.Add(this.ButonDosyaAc);
            this.groupBox1.Controls.Add(this.TxtResimYolu);
            this.groupBox1.Controls.Add(this.label5);
            this.groupBox1.Controls.Add(this.pictureBox1);
            this.groupBox1.Controls.Add(this.TxtKategori);
            this.groupBox1.Controls.Add(this.label4);
            this.groupBox1.Controls.Add(this.TxtPuan);
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Controls.Add(this.TxtFilmTur);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.TxtFilmAd);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Location = new System.Drawing.Point(12, 12);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(382, 188);
            this.groupBox1.TabIndex = 1;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Film İşlemleri";
            // 
            // LblResimDosyaAd
            // 
            this.LblResimDosyaAd.AutoSize = true;
            this.LblResimDosyaAd.Location = new System.Drawing.Point(200, 121);
            this.LblResimDosyaAd.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.LblResimDosyaAd.Name = "LblResimDosyaAd";
            this.LblResimDosyaAd.Size = new System.Drawing.Size(0, 18);
            this.LblResimDosyaAd.TabIndex = 15;
            // 
            // ButonDosyaAc
            // 
            this.ButonDosyaAc.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.ButonDosyaAc.Location = new System.Drawing.Point(335, 148);
            this.ButonDosyaAc.Name = "ButonDosyaAc";
            this.ButonDosyaAc.Size = new System.Drawing.Size(31, 24);
            this.ButonDosyaAc.TabIndex = 11;
            this.ButonDosyaAc.Text = "...";
            this.ButonDosyaAc.UseVisualStyleBackColor = true;
            this.ButonDosyaAc.Click += new System.EventHandler(this.ButonDosyaAc_Click);
            // 
            // TxtResimYolu
            // 
            this.TxtResimYolu.Location = new System.Drawing.Point(93, 148);
            this.TxtResimYolu.Name = "TxtResimYolu";
            this.TxtResimYolu.Size = new System.Drawing.Size(236, 24);
            this.TxtResimYolu.TabIndex = 10;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(7, 151);
            this.label5.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(88, 18);
            this.label5.TabIndex = 9;
            this.label5.Text = "Resim Yolu:";
            // 
            // pictureBox1
            // 
            this.pictureBox1.Location = new System.Drawing.Point(199, 23);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(167, 119);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 8;
            this.pictureBox1.TabStop = false;
            // 
            // TxtKategori
            // 
            this.TxtKategori.Location = new System.Drawing.Point(93, 118);
            this.TxtKategori.Name = "TxtKategori";
            this.TxtKategori.Size = new System.Drawing.Size(100, 24);
            this.TxtKategori.TabIndex = 7;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(7, 121);
            this.label4.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(67, 18);
            this.label4.TabIndex = 6;
            this.label4.Text = "Kategori:";
            // 
            // TxtPuan
            // 
            this.TxtPuan.Location = new System.Drawing.Point(93, 88);
            this.TxtPuan.Name = "TxtPuan";
            this.TxtPuan.Size = new System.Drawing.Size(100, 24);
            this.TxtPuan.TabIndex = 5;
            this.TxtPuan.TextChanged += new System.EventHandler(this.TxtPuan_TextChanged);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(7, 91);
            this.label3.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(78, 18);
            this.label3.TabIndex = 4;
            this.label3.Text = "Film Puan:";
            // 
            // TxtFilmTur
            // 
            this.TxtFilmTur.Location = new System.Drawing.Point(93, 58);
            this.TxtFilmTur.Name = "TxtFilmTur";
            this.TxtFilmTur.Size = new System.Drawing.Size(100, 24);
            this.TxtFilmTur.TabIndex = 3;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(7, 61);
            this.label2.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(74, 18);
            this.label2.TabIndex = 2;
            this.label2.Text = "Film Türü:";
            // 
            // TxtFilmAd
            // 
            this.TxtFilmAd.Location = new System.Drawing.Point(93, 28);
            this.TxtFilmAd.Name = "TxtFilmAd";
            this.TxtFilmAd.Size = new System.Drawing.Size(100, 24);
            this.TxtFilmAd.TabIndex = 1;
            // 
            // ButtonKaydet
            // 
            this.ButtonKaydet.BackColor = System.Drawing.Color.WhiteSmoke;
            this.ButtonKaydet.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.ButtonKaydet.Location = new System.Drawing.Point(153, 206);
            this.ButtonKaydet.Name = "ButtonKaydet";
            this.ButtonKaydet.Size = new System.Drawing.Size(241, 30);
            this.ButtonKaydet.TabIndex = 12;
            this.ButtonKaydet.Text = "KAYDET";
            this.ButtonKaydet.UseVisualStyleBackColor = false;
            this.ButtonKaydet.Click += new System.EventHandler(this.ButtonKaydet_Click);
            // 
            // ButonDuzenle
            // 
            this.ButonDuzenle.BackColor = System.Drawing.Color.WhiteSmoke;
            this.ButonDuzenle.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.ButonDuzenle.Location = new System.Drawing.Point(15, 206);
            this.ButonDuzenle.Name = "ButonDuzenle";
            this.ButonDuzenle.Size = new System.Drawing.Size(132, 30);
            this.ButonDuzenle.TabIndex = 13;
            this.ButonDuzenle.Text = "Düzenle";
            this.ButonDuzenle.UseVisualStyleBackColor = false;
            // 
            // dataGridView1
            // 
            this.dataGridView1.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.DisplayedCells;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Location = new System.Drawing.Point(400, 12);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dataGridView1.Size = new System.Drawing.Size(641, 222);
            this.dataGridView1.TabIndex = 14;
            this.dataGridView1.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView1_CellClick);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 18F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(1053, 246);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.ButonDuzenle);
            this.Controls.Add(this.ButtonKaydet);
            this.Controls.Add(this.groupBox1);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Button ButonDosyaAc;
        private System.Windows.Forms.TextBox TxtResimYolu;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.TextBox TxtKategori;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox TxtPuan;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox TxtFilmTur;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox TxtFilmAd;
        private System.Windows.Forms.Button ButtonKaydet;
        private System.Windows.Forms.Button ButonDuzenle;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.Label LblResimDosyaAd;
    }
}

