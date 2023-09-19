using EpGame.BusinessLogicLayer.Abstract;
using EpGame.Core.BusinessLogicLayer;
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
	public class CategoryManager : ICategoryService
	{
		ICategoryDAL DaL;
        public CategoryManager(ICategoryDAL categoryDaL)
        {
				DaL= categoryDaL;
        }
        public bool Add(Category entity)
		{
			try
			{
				bool result = DaL.Add(entity);
				if (result)
				{
					EpGameLog.AddLog($"{entity.CategoryName} isimli kategori eklendi", LogType.Insert);
					return true;
				}
				else
				{
					EpGameLog.AddLog($"{entity.CategoryName} isimli kategori Eklenemedi !", LogType.NonValidation);
					return false;
				}
			}
			catch (Exception ex)
			{

				EpGameLog.AddLog(ex.Message,LogType.Error);
				return false;
			}
		}

		public bool Delete(Category entity)
		{
			try
			{
				bool result = DaL.Delete(entity);
				if (result)
				{
					EpGameLog.AddLog($"{entity.CategoryName} adlı kategori başarıyla silindi !",LogType.Delete);
					return true;
				}
				else
				{
					EpGameLog.AddLog($"{entity.CategoryName} adlı kategori silinemedi !", LogType.NonValidation);
					return false;
				}
			}
			catch (Exception ex)
			{
				EpGameLog.AddLog(ex.Message,LogType.Error);
				return false;
			}
		}

		public Category Get(int id)
		{
			try
			{
				return DaL.Get(id);
			}
			catch (Exception ex)
			{
				EpGameLog.AddLog(ex.Message,LogType.Error);
				return null;
			}
			
		}

		public IEnumerable<Category> GetAll()
		{
			try
			{
				return DaL.GetAll();
			}
			catch (Exception ex)
			{
				EpGameLog.AddLog(ex.Message, LogType.Error);
				return null;
			}
		}

		public bool Update(Category entity)
		{
			try
			{
				bool result = DaL.Update(entity);
				if (result)
				{
					EpGameLog.AddLog($"{entity.CategoryName} adlı kategori başarıyla güncellendi !",LogType.Update);
					return true;
				}
				else 
				{
					EpGameLog.AddLog($"{entity.CategoryName} adlı kategori başarıyla güncellenemedi !", LogType.NonValidation);
					return false;
				}

			}
			catch (Exception ex)
			{
				EpGameLog.AddLog(ex.Message, LogType.Error);
				return false;
			}
		}
	}
}
