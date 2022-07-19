using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Ders20_SezarSifrelemeCozme
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            char[] karakterler = textBox1.Text.ToCharArray();
            textBox2.Clear();
            foreach (char eleman in karakterler)
            {
                textBox2.Text += Convert.ToChar(eleman+3).ToString();
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            char[] karaterler = textBox2.Text.ToCharArray();
            textBox1.Text = "";
            foreach (char elemancoz in karaterler)
            {
                textBox1.Text += Convert.ToChar(elemancoz - 3).ToString();
            }
        }
    }
}
