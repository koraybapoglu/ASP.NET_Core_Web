using EpGame.Core.Entity;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EpGame.Core.BusinessLogicLayer
{
	public interface IGenericService<TEntity> where TEntity : class,IBaseEntity,new()
	{
        bool Add(TEntity entity);
		bool Delete(TEntity entity);
		bool Update(TEntity entity);
		IEnumerable<TEntity> GetAll();
		TEntity Get(int id);
    }
}
