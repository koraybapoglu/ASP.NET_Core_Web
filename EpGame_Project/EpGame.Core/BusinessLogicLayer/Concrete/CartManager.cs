using EpGame.BusinessLogicLayer.Abstract;
using EpGame.Core.BusinessLogicLayer.Logger;
using EpGame.DataAccesLayer.Abstract;
using EpGame.EntityLayer.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EpGame.BusinessLogicLayer.Concrete
{
	public class CartManager : ICartService
	{
		ICartDAL daL;
        public CartManager(ICartDAL CartDAL)
        {
			daL = CartDAL;
        }
        public bool Add(Cart entity)
		{
			try
			{
				return daL.Add(entity);
			}
			catch (Exception ex)
			{
				EpGameLog.AddLog(ex.Message, LogType.Error);
				return false;
			}
		}

		public bool Delete(Cart entity)
		{
			try
			{
				return daL.Delete(entity);
			}
			catch (Exception ex)
			{
				EpGameLog.AddLog(ex.Message, LogType.Error);
				return false;
			}
		}

		public Cart Get(int id)
		{
			try
			{
				return daL.Get(id);
			}
			catch (Exception ex)
			{
				EpGameLog.AddLog(ex.Message, LogType.Error);
				return null;
			}
			
		}

		public IEnumerable<Cart> GetAll()
		{
			try
			{
				return daL.GetAll();
			}
			catch (Exception ex)
			{
				EpGameLog.AddLog(ex.Message, LogType.Error);
				return null;
			}
		}

		public bool Update(Cart entity)
		{
			try
			{
				return daL.Update(entity);
			}
			catch (Exception ex)
			{
				EpGameLog.AddLog(ex.Message, LogType.Error);
				return false;
			}
		}
	}
}
