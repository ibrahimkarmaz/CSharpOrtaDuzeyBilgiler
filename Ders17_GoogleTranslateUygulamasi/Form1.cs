using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Net;
using System.Threading;

namespace Ders17_GoogleTranslateUygulamasi
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        private bool kontrol()//internet bağlantısı var mi yok mu kontrol ?
        {
            try
            {
                WebRequest istek = WebRequest.Create("http://www.google.com");
                WebResponse yanit = istek.GetResponse();
            }
            catch (Exception)
            {
                return false;
            }
            return true;
        }
        private void BtnTranslate_Click(object sender, EventArgs e)
        {
            if (RbTR.Checked==true)
            {
                RtxENG.Text = webBrowser1.Document.GetElementById("Result_Box").InnerText;
            }
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            if (kontrol())
            {
                this.Text = "Bağlantı var";
            }
            else
            {
                this.Text = "Bağlantı yok";
            }
        }
        
        private void RbTR_CheckedChanged(object sender, EventArgs e)
        {
            webBrowser1.Navigate("https://translate.google.com.tr/#tr/en/");
        }

        private void RbENG_CheckedChanged(object sender, EventArgs e)
        {
            webBrowser1.Navigate("https://translate.google.com.tr/#en/tr/");
        }

        private void RtxTR_TextChanged(object sender, EventArgs e)
        {
            webBrowser1.Document.GetElementById("Source").InnerText=RtxTR.Text;
        }
    }
}
