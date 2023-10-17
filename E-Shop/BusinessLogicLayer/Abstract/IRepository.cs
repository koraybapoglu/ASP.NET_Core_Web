using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BusinessLogicLayer.Abstract
{
    public interface IRepository<T> where T : class,new()
    {
        List<T> List();
        void Insert(T entity);
        void Delete(T entity);
        void Update(T entity);
        T GetByID(int id);
    }
}
