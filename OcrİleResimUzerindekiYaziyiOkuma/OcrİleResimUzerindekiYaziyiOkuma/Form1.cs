using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using IronOcr;//YAZI OKUMA KÜTÜPHANEM

namespace OcrİleResimUzerindekiYaziyiOkuma
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

        private void button1_Click(object sender, EventArgs e)
        {
            var ocr = new AutoOcr();
            var sonuc = ocr.Read(pictureBox1.Image);
            richTextBox1.Text = sonuc.Text;
        }
    }
}
