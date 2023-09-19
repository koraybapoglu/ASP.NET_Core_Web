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
	public class GameCateogryManager : IGameCategoryService
	{
		IGameCategoryDAL DaL;
		public GameCateogryManager(IGameCategoryDAL gamecategoryDal)
		{
			DaL = gamecategoryDal;
		}
		public bool Add(GameCategory entity)
		{
			try
			{
				bool result = DaL.Add(entity);
				if (result)
				{
					EpGameLog.AddLog($"{entity.GameID} adlı oyunun ID'si ile {entity.CategoryID} adlı kategorinin ID'si birleştirilmiştir.", LogType.Insert);
					return true;
				}
				else
				{
					EpGameLog.AddLog($"{entity.GameID} adlı oyunun ID'si ile {entity.CategoryID} adlı kategorinin ID'si birleştirilemedi !", LogType.NonValidation);
					return false;
				}
			}
			catch (Exception ex)
			{
				EpGameLog.AddLog(ex.Message, LogType.Error);
				return false;
			}
		}

		public bool Delete(GameCategory entity)
		{
			try
			{
				bool result = DaL.Delete(entity);
				if (result)
				{
					EpGameLog.AddLog($"{entity.GameID} adlı oyun ID'si ve {entity.CategoryID} adlı kategori ID'sinin veri bağlantısı başarıyla silinmiştir !", LogType.Delete);
					return true;
				}
				else
				{
					EpGameLog.AddLog($"{entity.GameID} adlı oyun ID'si ve {entity.CategoryID} adlı kategori ID'sinin veri bağlantısı Silinemedi !", LogType.NonValidation);
					return false;
				}
			}
			catch (Exception ex)
			{
				EpGameLog.AddLog(ex.Message, LogType.NonValidation);
				return false;
			}
		}

		public GameCategory Get(int id)
		{
			try
			{
				return DaL.Get(id);
			}
			catch (Exception ex)
			{
				EpGameLog.AddLog(ex.Message, LogType.Error);
				return null;
			}
		}

		public IEnumerable<GameCategory> GetAll()
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

		public bool Update(GameCategory entity)
		{
			try
			{
				bool result = DaL.Update(entity);
				if (result)
				{
					EpGameLog.AddLog($"{entity.GameID} adlı oyun ID'sine sahip ve {entity.CategoryID} adlı kategori ID'sine sahip ürün başarıyla güncellendi !", LogType.Update);
					return true;
				}
				else
				{
					EpGameLog.AddLog($"{entity.GameID} adlı oyun ID'sine sahip ve {entity.CategoryID} adlı kategori ID'sine sahip ürün başarıyla güncellenemedi !", LogType.NonValidation);
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
