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

namespace Ders18_DatagridViewSartliRenlendirme
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        DataSet veri = new DataSet();
        private void Form1_Load(object sender, EventArgs e)
        {
            
            SqlConnection baglanti = new SqlConnection(@"Data Source = DESKTOP-5DGSRBQ; Initial Catalog = Db_YedekParcaOtomasyonSistemi; Integrated Security = True");
            SqlDataAdapter komut = new SqlDataAdapter("select * from TblMusteri",baglanti);
            komut.Fill(veri, "TblMusteri");
            dataGridView1.DataSource = veri.Tables[0];
            for (int i = 0; i < dataGridView1.Rows.Count-1; i++)
            {
                DataGridViewCellStyle renk = new DataGridViewCellStyle();
                if (Convert.ToBoolean(dataGridView1.Rows[i].Cells[11].Value))
                {
                    renk.BackColor = Color.Red;
                    renk.ForeColor = Color.White;
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
