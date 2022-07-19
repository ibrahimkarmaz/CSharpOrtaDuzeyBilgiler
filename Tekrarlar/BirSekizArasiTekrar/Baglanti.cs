using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;
using System.IO;

namespace BirSekizArasiTekrar
{
    class Baglanti
    {
        public SqlConnection BaglantiAdresiniGetir()
        {
            StreamReader DosyayiCek = new StreamReader("Config.txt");
            string baglanti_adresini_al = DosyayiCek.ReadLine();
            string baglanti_adresini_olustur = "";
            while (baglanti_adresini_al!=null)
            {
                baglanti_adresini_olustur = baglanti_adresini_al;
                baglanti_adresini_al = DosyayiCek.ReadLine();
            }
            SqlConnection baglanti = new SqlConnection(baglanti_adresini_olustur);
            baglanti.Open();
            return baglanti;
        }
    }
}
