using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;

namespace Ders5ResimEklemeCekme_Veritabani_
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        OpenFileDialog DosyaYolu = new OpenFileDialog();
        SqlConnection baglanti = new SqlConnection(@"Data Source=DESKTOP-5DGSRBQ;Initial Catalog=Db_FilmArsiv;Integrated Security=True");
        DataSet tabloseti = new DataSet();
        private void Form1_Load(object sender, EventArgs e)
        {
            DosyaYolu.Title = "FOTOĞRAF SEÇİNİZ";
            DosyaYolu.Filter = "FOTOĞRAF SEÇ | *jpg;*png;*gif;";
            DosyaYolu.RestoreDirectory = true;//En son dosyadan devam et
            DosyaYolu.Multiselect = false;//Birden fazla seçim true,false
            tabloyu_getir();
        }
        private void tabloyu_getir()
        {
            tabloseti.Clear();
            baglanti.Open();
            SqlDataAdapter komut = new SqlDataAdapter("select * from Tbl_Filmler",baglanti);
            komut.Fill(tabloseti);
            dataGridView1.DataSource = tabloseti.Tables[0];
            baglanti.Close();
        }

        private void ButonDosyaAc_Click(object sender, EventArgs e)
        {
            if (DosyaYolu.ShowDialog()==DialogResult.OK)
            {
                TxtResimYolu.Text = DosyaYolu.FileName;//Dosya Yolu
                LblResimDosyaAd.Text = DosyaYolu.SafeFileName;//Dosya Adı
                pictureBox1.ImageLocation = TxtResimYolu.Text;//Fotoğraf adresi(tam filename)
                pictureBox1.SizeMode = PictureBoxSizeMode.StretchImage;//Fotoğraf boyutu
            }
        }

        private void ButtonKaydet_Click(object sender, EventArgs e)
        {
            baglanti.Open();
            SqlCommand komut = new SqlCommand("insert into Tbl_Filmler values(@p1,@p2,@p3,@p4,@p5)",baglanti);
            komut.Parameters.AddWithValue("@p1",TxtFilmAd.Text);
            komut.Parameters.AddWithValue("@p2", TxtFilmTur.Text);
            komut.Parameters.AddWithValue("@p3", TxtPuan.Text);
            komut.Parameters.AddWithValue("@p4", TxtKategori.Text);
            komut.Parameters.AddWithValue("@p5", TxtResimYolu.Text);
            komut.ExecuteNonQuery();
            baglanti.Close();
            tabloyu_getir();

        }

        private void TxtPuan_TextChanged(object sender, EventArgs e)
        {
            TxtPuan.Text = TxtPuan.Text.Replace(",", ".");
            TxtPuan.Select(TxtPuan.Text.Length, 0);//Textbox içinde satırın sonuna gelme
        }
        string ID_Bilgisi;
        private void dataGridView1_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            int secilen = dataGridView1.SelectedCells[0].RowIndex;
            ID_Bilgisi = dataGridView1.Rows[dataGridView1.SelectedCells[0].RowIndex].Cells[0].Value.ToString();
            //TxtFilmAd.Text = dataGridView1.CurrentRow.Cells[1].Value.ToString();//1. Yöntem secilen kullanmadan
            TxtFilmAd.Text = dataGridView1.Rows[secilen].Cells[1].Value.ToString();//2.Yöndem secilen kullanarak
            TxtFilmTur.Text = dataGridView1.Rows[secilen].Cells[2].Value.ToString();
            TxtPuan.Text= dataGridView1.Rows[secilen].Cells[3].Value.ToString();
            TxtKategori.Text = dataGridView1.Rows[secilen].Cells[4].Value.ToString();
            TxtResimYolu.Text = dataGridView1.Rows[secilen].Cells[5].Value.ToString();

            pictureBox1.ImageLocation = TxtResimYolu.Text;
        }
    }
}
