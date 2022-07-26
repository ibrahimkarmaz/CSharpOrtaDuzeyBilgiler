﻿using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Linq.Expressions;
using System.Text;
using System.Threading.Tasks;
using DataAccessLayer.Abstract;


namespace DataAccessLayer
{
    public class Repostory<T> : IRepository<T> where T : class
    {
        Context C = new Context();
        DbSet<T> _object;
        public Repostory()
        {
            _object = C.Set<T>();
        }

        public int Delete(T p)
        {
            _object.Remove(p);
            return C.SaveChanges();
        }

        public T Find(Expression<Func<T, bool>> obj)
        {
            return _object.FirstOrDefault(obj);
        }

        public T GetById(int id)
        {
            return _object.Find(id);
        }

        public int insert(T p)
        {
            _object.Add(p);
            return C.SaveChanges();
        }

        public List<T> List()
        {
            return _object.ToList();
        }

        public List<T> List(Expression<Func<T, bool>> obj)
        {
            return _object.Where(obj).ToList();
        }

        public int Update(T p)
        {
            return C.SaveChanges();
        }
    }
}
