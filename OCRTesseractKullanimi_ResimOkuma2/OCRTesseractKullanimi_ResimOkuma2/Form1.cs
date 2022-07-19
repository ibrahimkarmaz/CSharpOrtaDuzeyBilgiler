using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Tesseract;//Kütüphane

namespace OCRTesseractKullanimi_ResimOkuma2
{
    public partial class Form1 : Form
    {//https://www.nuget.org/packages/Tesseract/
        //adresinde gerekli kod var
        //Bu kodu;Package Manager Console yaz.
        //https://tesseract-ocr.github.io/tessdoc/Data-Files
        //Buradan hangi dil üzerinde çalışılacak bu belirleniyor.
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            /*NOT:PROJE PLAKA VB İŞLEMLER İÇİN UYGUN DEĞİL DÜZ YAZILARDA İYİ İŞ ÇIKARIYOR. BAZI VERİLERİ TAM OKUMUYOR.
            ****
            *Kitap Arka Kapak Gibi yerlerde iyi iş çıkarıyor.
            ****

             */
        }

        private void button2_Click(object sender, EventArgs e)
        {
            if (openFileDialog1.ShowDialog() == DialogResult.OK)
            {
                var img = new Bitmap(openFileDialog1.FileName);//resmin dosya adına göre verileri al
                var ocr = new TesseractEngine("./dil", "eng", EngineMode.Default);//resmi oku hangi dilde okunacağı ve dilin dosya dolunu göster
                var page = ocr.Process(img);//okunan değerleri kaydet
                textBox1.Text = page.GetText();//okunan değerlerin metin olanlarını al
            }
        }
    }
}
