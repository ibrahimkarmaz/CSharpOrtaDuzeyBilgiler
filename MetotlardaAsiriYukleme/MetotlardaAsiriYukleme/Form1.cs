using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace MetotlardaAsiriYukleme
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void checkedListBoxControl1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }
        void toplama(int a,int b)
        {
            Console.WriteLine(a+b);
        }
        void toplama(int a, int b,int c)
        {
            Console.WriteLine(a + b+c);
        }
        void toplama(int a, int b, int c,int d)
        {
            Console.WriteLine(a + b + c+d);
        }
        private void Form1_Load(object sender, EventArgs e)
        {//HEPSİNİN İSMİ AYNI OLSADA İÇİNDEKİ YAPTIĞI İŞLEMLER DAHA FAZLA BUNDAN DOLAYUI METOTLARDA AŞIRI YÜKLEME DENİR.
            toplama(1, 2, 3, 4);
            toplama(1, 2, 3);
            toplama(1, 27);
        }
    }
}
