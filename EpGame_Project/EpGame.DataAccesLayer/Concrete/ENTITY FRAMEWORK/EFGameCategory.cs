using EpGame.DataAccesLayer.Abstract;
using EpGame.EntityLayer.Entities;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EpGame.DataAccesLayer.Concrete.ENTITY_FRAMEWORK
{
	public class EFGameCategory : IGameCategoryDAL
	{
		private readonly EpGameDbContext _context;

		public EFGameCategory(EpGameDbContext context)
		{
			_context = context;
		}

		public bool Add(GameCategory entity)
		{
			try
			{
				_context.GameCategories.Add(entity);
				_context.SaveChanges();
				return true;
			}
			catch
			{
				return false;
			}
		}

		public bool Delete(GameCategory entity)
		{
			try
			{
				_context.GameCategories.Remove(entity);
				_context.SaveChanges();
				return true;
			}
			catch
			{
				return false;
			}
		}

		public GameCategory Get(int id)
		{
			return _context.GameCategories.FirstOrDefault(gc => gc.ID == id);
		}

		public List<GameCategory> GetAll()
		{
			return _context.GameCategories.ToList();
		}

		public bool Update(GameCategory entity)
		{
			try
			{
				_context.Entry(entity).State = EntityState.Modified;
				_context.SaveChanges();
				return true;
			}
			catch
			{
				return false;
			}
		}
	}
}
