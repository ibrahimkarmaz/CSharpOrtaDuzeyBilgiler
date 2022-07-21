using System;
using System.Collections.Generic;
using System.Linq;
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
        T GetById(int id);

    }
}
