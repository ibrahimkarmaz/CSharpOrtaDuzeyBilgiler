using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;

namespace BirSekizArasiTekrar
{
    public partial class Liste : Form
    {
        public Liste()
        {
            InitializeComponent();
        }
        Baglanti baglanti_ac = new Baglanti();
        private void Liste_Load(object sender, EventArgs e)
        {
            baglanti_ac.BaglantiAdresiniGetir();
            SqlDataAdapter komut = new SqlDataAdapter("select * from Tbl_InfoProfile",baglanti_ac.BaglantiAdresiniGetir());
            DataSet set = new DataSet();
            komut.Fill(set);
            dataGridView1.DataSource = set.Tables[0];
            
        }

        private void Liste_FormClosing(object sender, FormClosingEventArgs e)
        {
            Application.Exit();
        }
        public static string path = "";
        private void dataGridView1_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            path=dataGridView1.CurrentRow.Cells[4].Value.ToString();
        }

        private void dataGridView1_DoubleClick(object sender, EventArgs e)
        {
            if (path!="")
            {
                PhotoShow ac = new PhotoShow();
                ac.ShowDialog();
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            CinsiyetChart ac = new CinsiyetChart();
            ac.ShowDialog();
        }
    }
}
