using DataAccesLayer;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BusinessLogicLayer.Abstract
{
    public class GenericRepository<T> : IRepository<T> where T : class, new()
    {
        E_ShopDbContext db= new E_ShopDbContext();
        DbSet<T> data;
        public GenericRepository()
        {
            data = db.Set<T>();  
        }
        public void Delete(T entity)
        {
            data.Remove(entity);
            db.SaveChanges();
        }

        public T GetByID(int id)
        {
            return data.Find(id);
        }

        public void Insert(T entity)
        {
            data.Add(entity);
            db.SaveChanges();
        }

        public List<T> List()
        {
            return data.ToList();
        }

        public void Update(T entity)
        {
            data.Update(entity);
            db.SaveChanges();
        }
    }
}
