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

namespace BirSekizArasiTekrar
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        Baglanti BaglantiIslemleri = new Baglanti();
        enum CinsiyetEnum
        {
            ERKEK,KADIN
        }
        private void Form1_Load(object sender, EventArgs e)
        {
            TxtTc.TextAlign = TxtAd.TextAlign = TxtSoyad.TextAlign = HorizontalAlignment.Center;
            TxtTc.MaxLength = 11;
            TxtAd.MaxLength = TxtSoyad.MaxLength = 20;
            DosyaAc.Title = "RESİM SEÇİNİZ";
            DosyaAc.Multiselect = false;
            DosyaAc.Filter = "RESİM SEÇ | *jpg;*png;*gif;";
            DosyaAc.RestoreDirectory = true;
            pictureBox1.SizeMode = PictureBoxSizeMode.StretchImage;
            /*for (int i = 0; i < 2; i++)//ENUM COMBOBOXA ÇEKME
            {
                CmbCinsiyet.Items.Add((CinsiyetEnum)i);
            }*/
            
            CmbCinsiyet.DataSource = Enum.GetValues(typeof(CinsiyetEnum));//ENUMU COMBOBOX'A ÇEKME
            CmbCinsiyet.SelectedItem = "ERKEK";

        }
        private void TxtAd_TextChanged(object sender, EventArgs e)
        {
            TxtAd.Text = TxtAd.Text.ToUpper();
            TxtAd.Select(TxtAd.TextLength, 0);
        }

        private void TxtSoyad_TextChanged(object sender, EventArgs e)
        {
            TxtSoyad.Text = TxtSoyad.Text.ToUpper();
            TxtSoyad.Select(TxtSoyad.TextLength, 0);
        }

        private void TxtTc_TextChanged(object sender, EventArgs e)
        {
            try
            {
                if (TxtTc.Text!="")
                {
                    TxtTc.Text = (Convert.ToDouble(TxtTc.Text) * 1).ToString();
                    TxtTc.Select(TxtTc.TextLength, 0);
                }
                
            }
            catch (Exception)
            {
                TxtTc.Text = "";
                MessageBox.Show("T.C KİMLİK NO GİRİŞİNDE HATA OLUŞTU.","HATA",MessageBoxButtons.OK,MessageBoxIcon.Error);
                
            }
        }
        struct ProfilBilgileri
        {
            public string TCBilgi;
            public string AdBilgi;
            public string SoyadBilgi;
            public string CinsiyetBilgi;
            public string ResimUzantiBilgi;
           

        }
        ProfilBilgileri Profil=new ProfilBilgileri();
        private void button2_Click(object sender, EventArgs e)
        {
            Profil.TCBilgi = TxtTc.Text;
            Profil.AdBilgi = TxtAd.Text;
            Profil.SoyadBilgi = TxtSoyad.Text;
            Profil.CinsiyetBilgi = CmbCinsiyet.SelectedItem.ToString();
            Profil.ResimUzantiBilgi = pictureBox1.ImageLocation.ToString();

            BaglantiIslemleri.BaglantiAdresiniGetir();
            SqlCommand Komut = new SqlCommand("INSERT INTO Tbl_InfoProfile VALUES(@P1,@P2,@P3,@P4,@P5)", BaglantiIslemleri.BaglantiAdresiniGetir());
            Komut.Parameters.AddWithValue("@P1", Profil.TCBilgi);
            Komut.Parameters.AddWithValue("@P2", Profil.AdBilgi);
            Komut.Parameters.AddWithValue("@P3", Profil.SoyadBilgi);
            Komut.Parameters.AddWithValue("@P4", Profil.CinsiyetBilgi);
            Komut.Parameters.AddWithValue("@P5", Profil.ResimUzantiBilgi);
            Komut.ExecuteNonQuery();

        }
        OpenFileDialog DosyaAc = new OpenFileDialog();
        private void button1_Click(object sender, EventArgs e)
        {
            if (DosyaAc.ShowDialog()==DialogResult.OK)
            {
                pictureBox1.ImageLocation = DosyaAc.FileName;
            }

        }

        private void button3_Click(object sender, EventArgs e)
        {
            Liste ac = new Liste();
            ac.Show();
            this.Hide();
        }
    }
}
