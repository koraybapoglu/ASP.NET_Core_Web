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
	public class EFCategory : ICategoryDAL
	{
		private readonly EpGameDbContext _context;

		public EFCategory(EpGameDbContext context)
		{
			_context = context;
		}

		public bool Add(Category entity)
		{
			try
			{
				_context.Categories.Add(entity);
				_context.SaveChanges();
				return true;
			}
			catch
			{
				return false;
			}
		}

		public bool Delete(Category entity)
		{
			try
			{
				_context.Categories.Remove(entity);
				_context.SaveChanges();
				return true;
			}
			catch
			{
				return false;
			}
		}

		public Category Get(int id)
		{
			return _context.Categories.FirstOrDefault(c => c.ID == id);
		}

		public List<Category> GetAll()
		{
			return _context.Categories.ToList();
		}

		public bool Update(Category entity)
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
