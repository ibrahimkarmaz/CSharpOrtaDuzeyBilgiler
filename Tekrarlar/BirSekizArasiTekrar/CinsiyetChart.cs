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
    public partial class CinsiyetChart : Form
    {
        public CinsiyetChart()
        {
            InitializeComponent();
        }
        Baglanti baglan = new Baglanti();
        private void CinsiyetChart_Load(object sender, EventArgs e)
        {
            chart1.Titles.Add("CİNSİYET ORAN GRAFİĞİ");
            chart1.BackColor = Color.DarkGray;
            chart1.Series["Cinsiyet"].ChartType = System.Windows.Forms.DataVisualization.Charting.SeriesChartType.Pie;
            chart1.ChartAreas[0].AxisX.LabelStyle.Angle = -70;



            baglan.BaglantiAdresiniGetir();
            SqlCommand komut = new SqlCommand("SELECT Gender,COUNT(Gender) as cinsiyetbilgisi from Tbl_InfoProfile group by Gender",baglan.BaglantiAdresiniGetir());
            SqlDataReader oku = komut.ExecuteReader();
            while (oku.Read())
            {
                chart1.Series["Cinsiyet"].Points.AddXY(oku["Gender"],oku["cinsiyetbilgisi"]);
            }
        }
    }
}
