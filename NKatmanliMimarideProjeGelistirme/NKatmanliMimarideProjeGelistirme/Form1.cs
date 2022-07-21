using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using BusinessLayer;


namespace NKatmanliMimarideProjeGelistirme
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        //Tebrübe+= Katmanlardan sadece bir tanesini ekledim BusinessLayer GetAll kullanırken DataAccess Katmanı ile bağlantı sağlaması gerekiyor onun için tüm katmanlar eklendi.
        private void Form1_Load(object sender, EventArgs e)
        {
            CategoryManager cm = new CategoryManager();
            gridControl1.DataSource = cm.GetAll();
        }
    }
}
