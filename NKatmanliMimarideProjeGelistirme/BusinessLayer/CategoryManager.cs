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
        public int BLAdd(Category c)
        {
            if (c.CategoryName.Length<=3)
            {
                return -1;
            }
            return caterepo.insert(c);
        }

        public int BLDelete(int p)
        {
            if (p!=0)
            {
                Category c = caterepo.Find(x=>x.CategoryID==p);
                return caterepo.Delete(c);
            }
            else
            {
                return -1;
            }
        }

        public int BLUpdate(Category p)
        {
            if (p.CategoryName=="" || p.CategoryName.Length<=3 || p.CategoryName.Length>=50 )
            {
                return -1;
            }
            Category ct = caterepo.Find(x=>x.CategoryID==p.CategoryID);
            ct.CategoryName = p.CategoryName;
            return caterepo.Update(ct);
           
        }
    }
}
