using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.OleDb;

namespace WindowsFormsApp1
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        OleDbConnection baglanti = new OleDbConnection(@"Provider=Microsoft.ACE.OLEDB.12.0;Data Source=C:\Users\ibrah\OneDrive\Masaüstü\Kitaplar.xlsx;Extended Properties='Excel 12.0 Xml;HDR=YES';");
        
        void veriler()
        {
            OleDbDataAdapter da = new OleDbDataAdapter("Select KitapAd,Yazar,Tür,Fiyat from [Sheet1$] where Arsiv=1",baglanti);
            DataTable set = new DataTable();
            da.Fill(set);
            DGV_Liste.DataSource = set;
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            veriler();
        }

        private void BtnListele_Click(object sender, EventArgs e)
        {
            veriler();
        }

        private void BtnKayit_Click(object sender, EventArgs e)
        {
            baglanti.Open();
            OleDbCommand komut = new OleDbCommand("insert into [sheet1$] values(@p1,@p2,@p3,@p4,@p5)",baglanti);
            komut.Parameters.AddWithValue("@p1", TxtAd.Text);
            komut.Parameters.AddWithValue("@p2", TxtYazar.Text);
            komut.Parameters.AddWithValue("@p3", TxtTur.Text);
            komut.Parameters.AddWithValue("@p4", TxtFiyat.Text);
            komut.Parameters.AddWithValue("@p5", 1);
            komut.ExecuteNonQuery();
            baglanti.Close();
            MessageBox.Show("KAYIT BAŞARILI");
        }
        string secilenad;
        private void DGV_Liste_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            secilenad = TxtAd.Text = DGV_Liste.CurrentRow.Cells[0].Value.ToString();
            TxtYazar.Text= DGV_Liste.CurrentRow.Cells[1].Value.ToString();
            TxtTur.Text= DGV_Liste.CurrentRow.Cells[2].Value.ToString();
            TxtFiyat.Text= DGV_Liste.CurrentRow.Cells[3].Value.ToString();
        }

        private void BtnDuzenle_Click(object sender, EventArgs e)
        {
            baglanti.Open();
            OleDbCommand komut = new OleDbCommand("update [sheet1$] set KitapAd=@p1,Yazar=@p2,Tür=@p3,Fiyat=@p4 where KitapAd=@p5", baglanti);
            komut.Parameters.AddWithValue("@p1", TxtAd.Text);
            komut.Parameters.AddWithValue("@p2", TxtYazar.Text);
            komut.Parameters.AddWithValue("@p3", TxtTur.Text);
            komut.Parameters.AddWithValue("@p4", TxtFiyat.Text);
            komut.Parameters.AddWithValue("@p5", secilenad);
            komut.ExecuteNonQuery();
            baglanti.Close();
            MessageBox.Show("KAYIT DÜZENLENDİ");

        }

        private void BtnSil_Click(object sender, EventArgs e)
        {
            baglanti.Open();
            OleDbCommand komut = new OleDbCommand("update [sheet1$] set Arsiv=@p1 where KitapAd=@p2", baglanti);
            komut.Parameters.AddWithValue("@p1", 0);
            komut.Parameters.AddWithValue("@p2", secilenad);
            komut.ExecuteNonQuery();
            baglanti.Close();
            MessageBox.Show("KAYIT ARŞİVLENDİ");
        }
    }
}
