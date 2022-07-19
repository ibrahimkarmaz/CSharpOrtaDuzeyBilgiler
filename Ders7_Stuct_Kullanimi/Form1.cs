using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Ders7_Stuct_Kullanimi
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        struct SehirBilgileri
        {
            public byte PlakaNo;
            public string SehirAd;
            public string UnlulukDurumu;
            public string Renk;

            public void Ekle(byte plaka,string sehirad,string unlu,string renk)
            {
                PlakaNo = plaka;
                SehirAd = sehirad;
                UnlulukDurumu = unlu;
                Renk = renk;
            }
        }
        
        private void Form1_Load(object sender, EventArgs e)
        {
            

        }

        private void button1_Click(object sender, EventArgs e)
        {
            SehirBilgileri Sehir = new SehirBilgileri();
            Sehir.Ekle(Convert.ToByte(TxtPlakaNo.Text),TxtSehirAd.Text,TxtUnlu.Text,TxtRenk.Text);
            MessageBox.Show("Plaka No:"+Sehir.PlakaNo.ToString()+"\nŞehir Ad:"+Sehir.SehirAd+"\nŞehiri Ünlü Eden Şey:"+Sehir.UnlulukDurumu+"\nŞehir Rengi:"+Sehir.Renk);
        }
    }
}
