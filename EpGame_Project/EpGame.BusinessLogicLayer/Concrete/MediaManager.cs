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
	public class MediaManager : IMediaService
	{
        IMediaDAL DaL;
        public MediaManager(IMediaDAL mediadal)
        {
                DaL = mediadal;
        }

		public bool Add(Media entity)
		{
			try
			{
				bool result = DaL.Add(entity);
				if (result) 
				{
					EpGameLog.AddLog($"{entity.MediaType} Adlı Medya Başarıyla eklendi.",LogType.Insert);
					return true;
				}
				else
				{
					EpGameLog.AddLog($"{entity.MediaType} Adlı Medya Başarıyla Eklenemedi !", LogType.NonValidation);
					return false;
				}
			}
			catch (Exception ex)
			{
				EpGameLog.AddLog(ex.Message, LogType.Error);
				return false;
			}
		}

		public bool Delete(Media entity)
		{
			try
			{
				bool result = DaL.Delete(entity);
				if (result)
				{
					EpGameLog.AddLog($"{entity.MediaType} adlı Medya Başarıyla Silindi !",LogType.Delete);
					return true;
				}
				else
				{
					EpGameLog.AddLog($"{entity.MediaType} adlı Medya Başarıyla Silienemdi !", LogType.NonValidation);
					return false;
				}
			}
			catch (Exception ex)
			{
				EpGameLog.AddLog(ex.Message,LogType.Error);
				return false;
			}
		}

		public Media Get(int id)
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

		public IEnumerable<Media> GetAll()
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

		public bool Update(Media entity)
		{
			try
			{
				bool result = DaL.Update(entity);
				if (result)
				{
					EpGameLog.AddLog($"{entity.MediaType} adlı Medya Başarıyla Güncellendi !",LogType.Update);
					return true;
				}
				else
				{
					EpGameLog.AddLog($"{entity.MediaType} adlı Medya Başarıyla Güncellenemdi !", LogType.NonValidation);
					return false;
				}
			}
			catch (Exception ex)
			{
				EpGameLog.AddLog (ex.Message, LogType.Error);
				return false;
			}
		}
	}
}
