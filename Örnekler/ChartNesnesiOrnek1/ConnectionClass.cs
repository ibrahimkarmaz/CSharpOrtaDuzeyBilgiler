using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;

namespace ChartNesnesiOrnek1
{
    class ConnectionClass
    {
        public SqlConnection Baglanti()
        {
            SqlConnection baglanti = new SqlConnection(@"Data Source=DESKTOP-5DGSRBQ;Initial Catalog=Db_FilmArsiv;Integrated Security=True");
            baglanti.Open();
            return baglanti;
        }
    }
}
