using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsApp1
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void BtnSifrele_Click(object sender, EventArgs e)
        {
            string anametin = TxtAnaMetin.Text;//Metini aldık
            byte[] veridizim = ASCIIEncoding.ASCII.GetBytes(anametin);//Byte olarak 8 bit olarak tuttuk
            string sifrelimetin = Convert.ToBase64String(veridizim);//Tobase64 ile 64 bit dönüştürdük.
            TxtSifreMetin.Text = sifrelimetin;//Ekrana yazdırdık
        }

        private void BtnSifreCoz_Click(object sender, EventArgs e)
        {
            string metincoz = TxtSifreMetin.Text;//metini aldik
            byte[] verdizicoz = Convert.FromBase64String(metincoz);//64 bitlik veriyi 8 bite dönüştürmek için FromBase64String kullanıdık
            string anameti2 = ASCIIEncoding.ASCII.GetString(verdizicoz);//bizim 8 bite döüştürdüğümüz veriyi ascı kodlari ile string dönüştürüyoruzç
            TxtAnaMetin.Text = anameti2;//ekrana yazdırma

        }
    }
}
