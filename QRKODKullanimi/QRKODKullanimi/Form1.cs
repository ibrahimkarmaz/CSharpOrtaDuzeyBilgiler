using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using QRCoder;//KAREKOD OLUŞTURMA KÜTÜPHANESİ
using ZXing;//KAREKOD ÇÖZME(ÇALIŞMIYOR ARAŞTIRILACAK DİĞER KODLAR.)

namespace QRKODKullanimi
{
    public partial class Form1 : Form
    {
        public object Request { get; private set; }

        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            /*ECCLevel
             * KOD %A  HATA ORANI DÜZENLEME
             * L   %7
             * M   %15 
             * Q   %25 
             * H   %30 
             */

            QRCodeGenerator QRUret = new QRCodeGenerator();//QR Üretme aracı
            QRCodeData QRVeri = QRUret.CreateQrCode(textBox1.Text, QRCodeGenerator.ECCLevel.Q);//Burada QRVerileri alınıyor=QRUret ile oluşturuyoruz(veri,ve hata oranı belirleniyor)
            QRCode KareKod = new QRCode(QRVeri);//Burada Karekod olarak veriyi getiriyoruz
            pictureBox1.Image = KareKod.GetGraphic(20);//Resim halinde dönüştürme ve gösterme
        }

        private void button2_Click(object sender, EventArgs e)
        {
           /* var QCreader = new BarcodeReader();
            string QCfilename = Path.Combine(Request.MapPath("~/images"), "MyQRImage.jpg");
            var QCresult = QCreader.Decode(new Bitmap(QCfilename));
            if (QCresult != null)
            {
                lblQRCode.Text = "My QR Code: " + QCresult.Text;
            }*/
        }
    }
}
