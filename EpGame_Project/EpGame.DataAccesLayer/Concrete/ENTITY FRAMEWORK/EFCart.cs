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
	public class EFCart : ICartDAL
	{
		private readonly EpGameDbContext _context;

		public EFCart(EpGameDbContext context)
		{
			_context = context;
		}

		public bool Add(Cart entity)
		{
			try
			{
				_context.Carts.Add(entity);
				_context.SaveChanges();
				return true;
			}
			catch
			{
				return false;
			}
		}

		public bool Delete(Cart entity)
		{
			try
			{
				_context.Carts.Remove(entity);
				_context.SaveChanges();
				return true;
			}
			catch
			{
				return false;
			}
		}

		public Cart Get(int id)
		{
			return  _context.Carts.FirstOrDefault(c => c.ID == id);
		}

		public List<Cart> GetAll()
		{
			return _context.Carts.ToList();
		}

		public bool Update(Cart entity)
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
