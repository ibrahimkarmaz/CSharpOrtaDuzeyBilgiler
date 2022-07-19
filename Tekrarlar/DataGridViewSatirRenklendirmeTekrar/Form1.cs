using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace DataGridViewSatirRenklendirmeTekrar
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            // TODO: Bu kod satırı 'db_FilmArsivDataSet1.Tbl_Filmler' tablosuna veri yükler. Bunu gerektiği şekilde taşıyabilir, veya kaldırabilirsiniz.
            this.tbl_FilmlerTableAdapter.Fill(this.db_FilmArsivDataSet1.Tbl_Filmler);
            
            for (int i = 0; i < dataGridView1.Rows.Count-1; i++)
            {
                DataGridViewCellStyle renk = new DataGridViewCellStyle();
                Console.WriteLine(dataGridView1.Rows[i].Cells[3].Value);
                if (Convert.ToDouble(dataGridView1.Rows[i].Cells[3].Value)>7.7)
                {
                    Console.WriteLine("a");
                    renk.BackColor = Color.GreenYellow;
                    renk.ForeColor = Color.Red;
                }
                else
                {
                    renk.BackColor = Color.White;
                    renk.ForeColor = Color.Black;

                }
                dataGridView1.Rows[i].DefaultCellStyle = renk;
            }
        }
    }
}
