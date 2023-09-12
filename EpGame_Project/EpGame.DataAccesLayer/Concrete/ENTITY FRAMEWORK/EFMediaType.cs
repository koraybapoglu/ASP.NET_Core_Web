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
	public class EFMediaType : IMediaTypeDAL
	{
		private readonly EpGameDbContext _context;

		public EFMediaType(EpGameDbContext context)
		{
			_context = context;
		}

		public bool Add(MediaType entity)
		{
			try
			{
				_context.MediaTypes.Add(entity);
				_context.SaveChanges();
				return true;
			}
			catch
			{
				return false;
			}
		}

		public bool Delete(MediaType entity)
		{
			try
			{
				_context.MediaTypes.Remove(entity);
				_context.SaveChanges();
				return true;
			}
			catch
			{
				return false;
			}
		}

		public MediaType Get(int id)
		{
			return _context.MediaTypes.FirstOrDefault(mt => mt.ID == id);
		}

		public List<MediaType> GetAll()
		{
			return _context.MediaTypes.ToList();
		}

		public bool Update(MediaType entity)
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
