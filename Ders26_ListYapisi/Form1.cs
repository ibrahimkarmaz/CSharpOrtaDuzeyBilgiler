using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Ders26_ListYapisi
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            string[] dizi = new string[2];
            dizi[0] = "ibrahim karmaz";
            dizi[1] = "Yaş:24";
            List<string> ibrahim = new List<string>(dizi);//OLUŞTURMA
            ibrahim.Add("Boy/Kilo:170cm/91kg");
            ibrahim.Add("x");
            ibrahim.Add("y");

            //MessageBox.Show(ibrahim.Count.ToString());//Liste boyutunu alma

            //VERİLERİ EKRANA YAZDIRMA
            foreach (var item in ibrahim)
            {
                listBox1.Items.Add(item.ToString());
            }

            for (int i = 0; i < ibrahim.Count; i++)
            {
                comboBox1.Items.Add(ibrahim[i]);
            }
            ibrahim.Remove("x");
            ibrahim.RemoveAt(3);
            ibrahim.ForEach(x => listBox1.Items.Add(x.ToString()));

            Console.WriteLine(ibrahim.Contains("ahmet"));
            Console.WriteLine(ibrahim.BinarySearch("ahmet"));

        }
    }
}
