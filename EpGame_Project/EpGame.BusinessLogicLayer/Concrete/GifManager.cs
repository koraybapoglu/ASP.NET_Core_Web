using EpGame.BusinessLogicLayer.Abstract;
using EpGame.Core.BusinessLogicLayer.Logger;
using EpGame.DataAccesLayer.Abstract;
using EpGame.EntityLayer.Entities;
using Microsoft.EntityFrameworkCore.ChangeTracking.Internal;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EpGame.BusinessLogicLayer.Concrete
{
	public class GifManager : IGiftService
	{
		IGiftDAL dAL;
		public GifManager(IGiftDAL giftdal)
		{
			dAL = giftdal;
		}
		public bool Add(Gift entity)
		{
			try
			{
				bool result = dAL.Add(entity);
				if (result)
				{
					EpGameLog.AddLog($"{entity.SendUserID} ID'li kullanıcı {entity.ReceiverUserID} ID'li kullanıcıya {entity.GameID} ID'li oyunu başarıyla hediye etti.", LogType.Insert);
					return true;
				}
				else
				{
					EpGameLog.AddLog($"{entity.SendUserID} ID'li kullanıcı {entity.ReceiverUserID} ID'li kullanıcıya {entity.GameID} ID'li oyunu başarıyla gönderemedi !", LogType.NonValidation);
					return false;
				}
			}
			catch (Exception ex)
			{
				EpGameLog.AddLog(ex.Message, LogType.Error);
				return false;
			}
		}

		public bool Delete(Gift entity)
		{
			try
			{
				bool result = dAL.Delete(entity);
				if (result)
				{
					EpGameLog.AddLog($"{entity.ID} ID'li gönderim başarılı bir şekilde Silindi !", LogType.Delete);
					return true;
				}
				else
				{
					EpGameLog.AddLog($"{entity.ID} ID'li gönderim başarılı bir şekilde Silinemedi !", LogType.NonValidation);
					return false;
				}
			}
			catch (Exception ex)
			{
				EpGameLog.AddLog(ex.Message, LogType.Error);
				return false;
			}

		}

		public Gift Get(int id)
		{
			try
			{
				return dAL.Get(id);
			}
			catch (Exception ex)
			{
				EpGameLog.AddLog(ex.Message, LogType.Error);
				return null;
			}
		}

		public IEnumerable<Gift> GetAll()
		{
			try
			{
				return dAL.GetAll();
			}
			catch (Exception ex)
			{
				EpGameLog.AddLog(ex.Message, LogType.Error);
				return null;
			}
		}

		public bool Update(Gift entity)
		{
			try
			{
				bool result = dAL.Update(entity);
				if (result)
				{
					EpGameLog.AddLog($"{entity.ID} ID'li veri başarıyla güncellendi !", LogType.Update);
					return true;
				}
				else
				{
					EpGameLog.AddLog($"{entity.ID} ID'li veri başarıyla güncellenemedi !", LogType.NonValidation);
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
