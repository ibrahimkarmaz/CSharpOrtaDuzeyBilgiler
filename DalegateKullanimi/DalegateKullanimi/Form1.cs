using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace DalegateKullanimi
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        /*
         *delegate Mantığı;
         *Birden fazla metod var ise ve bunlar üzerinde bir sonuç işlemi vb işlemler yapılacak ve tümü veya bir kısmı
         *çağrılıcak ise kullanılan yapıdır. 
         */
        delegate void islemler(int i1, int i2);
        void toplam(int t1,int t2)
        {
            LBIslemler.Items.Add("TOPLAM:"+(t1+t2).ToString());
        }
        void Fark(int f1, int f2)
        {
            LBIslemler.Items.Add("FARK:"+(f1 - f2).ToString());
        }
        void Carp(int c1, int c2)
        {
            LBIslemler.Items.Add("ÇARPIM:"+(c1 *c2).ToString());
        }
        void Bol(int b1, int b2)
        {
            LBIslemler.Items.Add("BÖLÜM:"+(b1 / b2).ToString());
        }
        void Mod(int m1, int m2)
        {
            LBIslemler.Items.Add("MOD:"+(m1 % m2).ToString());
        }
        /*
        1.SORU:4X^2+5X+10
        2.SORU:KÜP
        3.SORU:KARE 
        4.SORU:ÇEMBER ALAN π x r2
        5.SORU:ÇEMBER ÇEVRE 2 x π x r
        Klavyeden girilen tek bir değere göre metod yardımıyla işlemleri yapan ve bunları temsilci yoluyla
        Listboxta gösteren c# kodunu yazınız.*/
        delegate void cevaps(int deger);
        void Soru1(int s1)//4X^2+5X+10
        {
            LBIslemler.Items.Add((4*s1+5*s1+10).ToString());
        }
        void Soru2(int s2)//KÜP
        {
            LBIslemler.Items.Add(Math.Pow(s2,3).ToString());
        }        
        void Soru3(int s3)//KARE
        {
            LBIslemler.Items.Add(Math.Pow(s3,2).ToString());
        }
        double pi = 3.14;
        void Soru4(int s4)//ÇEMBER ALAN π x r2
        {
            LBIslemler.Items.Add(pi*(s4*2));
        }        
        void Soru5(int s5)//ÇEMBER ÇEVRE 2 x π x r
        {
            LBIslemler.Items.Add(2*pi*s5);
        }

        private void BtnHesapla_Click(object sender, EventArgs e)
        {
            LBIslemler.Items.Clear();
            islemler islem = new islemler(toplam);
            islem += Fark;
            islem += Carp;
            islem += Bol;
            islem += Mod;
            islem(Convert.ToInt32(TBSayi1.Text), Convert.ToInt32(TBSayi2.Text));
        }

        private void BtnSoruCevap_Click(object sender, EventArgs e)
        {
            LBIslemler.Items.Clear();
            cevaps cevapla = new cevaps(Soru1);
            cevapla += Soru2;
            cevapla += Soru3;
            cevapla += Soru4;
            cevapla += Soru5;
            cevapla(Convert.ToInt32(TBSayi1.Text));
        }

        delegate void zaman(int x);
        void Tarih(int ekleTarih)
        {
            LBIslemler.Items.Add(DateTime.Now.AddDays(ekleTarih).ToString());
        }
        void Saat(int ekleSaat)
        {
            LBIslemler.Items.Add(DateTime.Now.AddHours(ekleSaat).ToString());
        }

        private void BtnTarihSaat_Click(object sender, EventArgs e)
        {
            LBIslemler.Items.Clear();
            zaman eklemeYap = new zaman(Tarih);
            eklemeYap += Saat;
            eklemeYap(Convert.ToInt32(TBSayi1.Text));

        }
    }
}
