using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace BirSekizArasiTekrar
{
    public partial class PhotoShow : Form
    {
        public PhotoShow()
        {
            InitializeComponent();
        }

        private void PhotoShow_Load(object sender, EventArgs e)
        {
            pictureBox1.ImageLocation = Liste.path;
        }
    }
}
