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
using EntitiyLayer.Entities;


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
            ProductManager pm = new ProductManager();
            /*   Category Kategori = new Category();
               Kategori.CategoryName = "Halılar";
               cm.BLAdd(Kategori);

               cm.BLDelete(1);*/

            /* Category guncelle = new Category();
             guncelle.CategoryID = 2;
             guncelle.CategoryName = "Elektonik ve Elektonik Ürünleri";
             if (cm.BLUpdate(guncelle)==-1)
             {
                 Console.WriteLine("Ürün Güncellenemedi.");

             }


             gridControl1.DataSource = cm.GetAll();*/

            //1.TÜMÜNÜ LİSTELEME
            gridControl1.DataSource = pm.GetAll();
            //2.ÜRÜN ADINA GÖRE LİSTELEME
            //gridControl1.DataSource = pm.GetByName("Bulaşık Makinesi");

        }
    }
}
