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
	public class EFMedia : IMediaDAL
	{
		private readonly EpGameDbContext _context;

		public EFMedia(EpGameDbContext context)
		{
			_context = context;
		}

		public bool Add(Media entity)
		{
			try
			{
				_context.Medias.Add(entity);
				_context.SaveChanges();
				return true;
			}
			catch
			{
				return false;
			}
		}

		public bool Delete(Media entity)
		{
			try
			{
				_context.Medias.Remove(entity);
				_context.SaveChanges();
				return true;
			}
			catch
			{
				return false;
			}
		}

		public Media Get(int id)
		{
			return _context.Medias.FirstOrDefault(m => m.ID == id);
		}

		public List<Media> GetAll()
		{
			return _context.Medias.ToList();
		}

		public bool Update(Media entity)
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

