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
	public class GameManager : IGameService
	{
		IGameDAL DaL;
		public GameManager(IGameDAL gamedal)
		{
			DaL = gamedal;
		}
		public bool Add(Game entity)
		{
			try
			{
				bool result = DaL.Add(entity);
				if (result)
				{
					EpGameLog.AddLog($"{entity.GameName} adlı oyun başarıyla eklendi !", LogType.Insert);
					return true;
				}
				else
				{
					EpGameLog.AddLog($"{entity.GameName} adlı oyun başarıyla eklenemedi !", LogType.NonValidation);
					return false;
				}
			}
			catch (Exception ex)
			{
				EpGameLog.AddLog(ex.Message, LogType.Error);
				return false;
			}
		}

		public bool Delete(Game entity)
		{
			try
			{
				bool result = DaL.Delete(entity);
				if (result)
				{
					EpGameLog.AddLog($"{entity.GameName} adlı oyun başarıyla silindi !", LogType.Delete);
					return true;
				}
				else
				{
					EpGameLog.AddLog($"{entity.GameName} adlı oyun başarıyla silinemedi !", LogType.NonValidation);
					return false;
				}
			}
			catch (Exception ex)
			{
				EpGameLog.AddLog(ex.Message, LogType.Error);
				return false;
			}
		}

		public Game Get(int id)
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

		public IEnumerable<Game> GetAll()
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

		public bool Update(Game entity)
		{
			try
			{
				bool result = DaL.Update(entity);
				if (result)
				{
					EpGameLog.AddLog($"{entity.GameName} adlı oyun başarıyla güncellendi.", LogType.Insert);
					return true;
				}
				else
				{
					EpGameLog.AddLog($"{entity.GameName} adlı oyun başarıyla güncellenemedi !", LogType.NonValidation);
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
