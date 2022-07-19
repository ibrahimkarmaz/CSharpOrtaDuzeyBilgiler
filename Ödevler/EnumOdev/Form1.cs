using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace EnumOdev
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        enum aylar
        {
            OCAK,ŞUBAT,MART,NİSAN,MAYIS,HAZİRAN,TEMMUZ, AĞUSTOS,EYLÜL,EKİM,KASIM,ARALIK
        }
        private void button1_Click(object sender, EventArgs e)
        {
            MessageBox.Show("AY ADI:"+((aylar)(Convert.ToByte(textBox1.Text)-1)).ToString());
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            for (int i = 1; i <=12; i++)
            {
                chart1.Series["Aylar"].Points.AddXY(((aylar)(i-1)).ToString(),1);
            }
            chart1.ChartAreas[0].AxisX.LabelStyle.Angle = -80;
            chart1.BackColor = Color.FromArgb(50, 50, 50);
            chart1.Series["Aylar"].ChartType = System.Windows.Forms.DataVisualization.Charting.SeriesChartType.Pie;
            chart1.Titles.Add("AYLAR GRAFİĞİ");





            //Button durumları
            //button1.PerformLayout
            //button1.SuspendLayout
            //button1.ResumeLayout
        }
    }
}
