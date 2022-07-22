using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Text;
using System.Threading.Tasks;

namespace DataAccessLayer.Abstract
{//T:Entitiy
    //Repository amacı veritabani işlemlerini tek bir noktadan yönetmek.
    public interface IRepository<T>
    {
        int insert(T p);
        int Update(T p);
        int Delete(T p);
        List<T> List();
        List<T> List(Expression<Func<T,bool>> obj);
        T GetById(int id);
        T Find(Expression<Func<T, bool>> obj);

    }
}
