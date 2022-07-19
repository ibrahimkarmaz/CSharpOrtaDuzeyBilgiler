using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO;
using System.Data.SqlClient;

namespace Ders8_DisaridanBaglantiAdresiAlmaSQL
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        string StartingConnectionInfo;
        private void Form1_Load(object sender, EventArgs e)
        {
            StreamReader DosyaYolu = new StreamReader("Config.txt");
            string DosyadanGelenVeriler = DosyaYolu.ReadLine();
            while (DosyadanGelenVeriler!=null)
            {
                StartingConnectionInfo = DosyadanGelenVeriler;
                DosyadanGelenVeriler = DosyaYolu.ReadLine();
            }
            SqlConnection ConnectionSql = new SqlConnection(@StartingConnectionInfo);
            SqlDataAdapter Komut = new SqlDataAdapter("select * from Tbl_Filmler",StartingConnectionInfo);
            DataSet TabloSeti = new DataSet();
            Komut.Fill(TabloSeti);
            dataGridView1.DataSource = TabloSeti.Tables[0];
        }
    }
}
