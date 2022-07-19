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

namespace ChartNesnesiOrnek1
{
    public partial class Form1 : Form
    {
        ConnectionClass Baglanti_islemleri = new ConnectionClass();
        public Form1()
        {
            InitializeComponent();
        }
        DataSet TabloKayit = new DataSet();
        private void Form1_Load(object sender, EventArgs e)
        {
            Baglanti_islemleri.Baglanti();
            SqlCommand komut = new SqlCommand("Select FilmAd,FilmPuan from Tbl_Filmler", Baglanti_islemleri.Baglanti());
            SqlDataReader oku = komut.ExecuteReader();
            while (oku.Read())
            {
                chart1.Series["Filmler"].Points.AddXY(oku["FilmAd"].ToString(), oku["FilmPuan"]);//VERİLER
            }
            /*  Random rasgele = new Random();
              for (int i = 0; i < chart1.Series["Filmler"].Points.Count; i++)
              {
                  chart1.Series["Filmler"].Points[i].Color = Color.FromArgb(rasgele.Next(0, 256), rasgele.Next(0, 256), rasgele.Next(0, 256));
              }
              */
            chart1.BackColor = Color.Red;//ARKAPLAN RENGİ
            chart1.ChartAreas[0].AxisX.LabelStyle.Angle = -65;//YAZI ÇEVİRME
            chart1.Series["Filmler"].ChartType = System.Windows.Forms.DataVisualization.Charting.SeriesChartType.Pie;//GRAFİK TÜRÜNÜ DEĞİŞTÜRME.
            chart1.Titles.Add("FİMLER VE PUANLARI");//BAŞLIK
        }
    }
}
