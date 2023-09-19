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
	public class MediaTypeManager : IMediaTypeService
	{
		IMediaTypeDAL dAL;
		public MediaTypeManager(IMediaTypeDAL gameDAL)
		{
			dAL = gameDAL;
		}
		public bool Add(MediaType entity)
		{
			try
			{
				bool result = dAL.Add(entity);

				if (result)
				{
					EpGameLog.AddLog($"{entity.MediaTypeName} isimli media eklendi!", LogType.Insert);
					return true;
				}
				else
				{
					EpGameLog.AddLog($"{entity.MediaTypeName} isimli media eklenemedi!", LogType.NonValidation);
					return false;
				}
			}
			catch (Exception ex)
			{

				EpGameLog.AddLog(ex.Message, LogType.Error);
				return false;
			}
		}

		public bool Delete(MediaType entity)
		{
			try
			{
				bool result = dAL.Delete(entity);

				if (result)
				{
					EpGameLog.AddLog($"{entity.MediaTypeName} isimli media silindi!", LogType.Delete);
					return true;
				}
				else
				{
					EpGameLog.AddLog($"{entity.MediaTypeName} isimli media silinemedi!", LogType.NotFound);
					return false;
				}
			}
			catch (Exception ex)
			{

				EpGameLog.AddLog(ex.Message, LogType.Error);
				return false;
			}
		}

		public IEnumerable<MediaType> GetAll()
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
		public MediaType Get(int id)
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
		public bool Update(MediaType entity)
		{
			try
			{
				bool result = dAL.Update(entity);

				if (result)
				{
					EpGameLog.AddLog($"{entity.MediaTypeName} isimli media güncellendi!", LogType.Update);
					return true;
				}
				else
				{
					EpGameLog.AddLog($"{entity.MediaTypeName} isimli media güncellenemedi!", LogType.NonValidation);
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
