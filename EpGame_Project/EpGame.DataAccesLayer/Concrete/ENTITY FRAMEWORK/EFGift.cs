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
	public class EFGift : IGiftDAL
	{
		private readonly EpGameDbContext _context;

		public EFGift(EpGameDbContext context)
		{
			_context = context;
		}

		public bool Add(Gift entity)
		{
			try
			{
				_context.Gifts.Add(entity);
				_context.SaveChanges();
				return true;
			}
			catch
			{
				return false;
			}
		}

		public bool Delete(Gift entity)
		{
			try
			{
				_context.Gifts.Remove(entity);
				_context.SaveChanges();
				return true;
			}
			catch
			{
				return false;
			}
		}

		public Gift Get(int id)
		{
			return _context.Gifts.FirstOrDefault(g => g.ID == id);
		}

		public List<Gift> GetAll()
		{
			return _context.Gifts.ToList();
		}

		public bool Update(Gift entity)
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
