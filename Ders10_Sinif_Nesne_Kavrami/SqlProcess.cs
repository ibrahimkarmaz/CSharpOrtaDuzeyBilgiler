using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Ders10_Sinif_Nesne_Kavrami
{
    class SqlProcess
    {
        DataSet dds = new DataSet();
        public DataSet DataGride_TabloCek(string TabloAd)
        {
            return dds;
        }

        public DataSet DataGride_Kosullu_TabloCek(string TabloAd,string Kosul)
        {
            return dds;
        }
    }
}
