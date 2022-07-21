using DataAccessLayer;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using EntitiyLayer.Entities;

namespace BusinessLayer 
{//CURD İŞLEMLERİNDEN ÖNCE SÜZGEN DİYEBİLİRİZ ÖRNEK EKLEMEDE SU ŞARTA UYUYOR MU ?
    //TEBRÜBE +=CategoryManager önüne public eklemeden sunum katmanında çağırmadı görmediği için dikkat et buraya
    public class CategoryManager
    {
        Repostory<Category> caterepo = new Repostory<Category>();
        public List<Category> GetAll()
        {
            return caterepo.List();
        }
    }
}
