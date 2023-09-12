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
	public class EFGame : IGameDAL
	{
		private readonly EpGameDbContext _context;

		public EFGame(EpGameDbContext context)
		{
			_context = context;
		}

		public bool Add(Game entity)
		{
			try
			{
				_context.Games.Add(entity);
				_context.SaveChanges();
				return true;
			}
			catch
			{
				return false;
			}
		}

		public bool Delete(Game entity)
		{
			try
			{
				_context.Games.Remove(entity);
				_context.SaveChanges();
				return true;
			}
			catch
			{
				return false;
			}
		}

		public Game Get(int id)
		{
			return _context.Games.FirstOrDefault(g => g.ID == id);
		}

		public List<Game> GetAll()
		{
			return _context.Games.ToList();
		}

		public bool Update(Game entity)
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
