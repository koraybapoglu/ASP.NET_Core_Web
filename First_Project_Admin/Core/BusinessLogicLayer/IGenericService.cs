using Admin.Core.Entity;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Admin.Core.BusinessLogicLayer
{
    public interface IGenericService<TEntity> where TEntity : class,IBaseEntity,new()
    {
        bool Add(TEntity entity);
        bool Update(TEntity entity);
        bool Delete(TEntity entity);
        List<TEntity> GetAll();
        TEntity Get(int id);
    }
}
