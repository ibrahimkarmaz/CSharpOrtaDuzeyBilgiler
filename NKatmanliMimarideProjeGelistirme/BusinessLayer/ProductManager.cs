using DataAccessLayer;
using EntitiyLayer.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BusinessLayer
{
    public class ProductManager
    {
        Repostory<Product> reproduct = new Repostory<Product>();
        public List<Product> GetAll()
        {
            return reproduct.List();
        }   
        public List<Product> GetByName(string p)
        {
            return reproduct.List(x => x.ProductName == p);
        }
    }
}
