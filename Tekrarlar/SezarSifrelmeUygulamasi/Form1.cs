using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace SezarSifrelmeUygulamasi
{
    public partial class SifrelemeUygulamasi : Form
    {
        public SifrelemeUygulamasi()
        {
            InitializeComponent();
        }

        private void SifrelemeUygulamasi_Load(object sender, EventArgs e)
        {
            Cbm_Seviye.SelectedIndex = 0;
        }

        private void TxtAnaMetin_TextChanged(object sender, EventArgs e)
        {
            char[] karakterler = TxtAnaMetin.Text.ToCharArray();
            TxtSifrelenmisMetin.Clear();
            byte seviye = Convert.ToByte(Cbm_Seviye.SelectedIndex + 1);
            foreach (char karakter in karakterler)
            {
                TxtSifrelenmisMetin.Text += Convert.ToChar(karakter+seviye).ToString();
            }
        }

        private void TxtSifrelenmisMetin_TextChanged(object sender, EventArgs e)
        {
            /*char[] karakterler = TxtSifrelenmisMetin.Text.ToCharArray();
            TxtAnaMetin.Clear();
            byte seviye = Convert.ToByte(Cbm_Seviye.SelectedIndex + 1);
            foreach (char x in karakterler)
            {
                TxtAnaMetin.Text = Convert.ToChar(x-seviye).ToString();
            }*/
        }
    }
}
