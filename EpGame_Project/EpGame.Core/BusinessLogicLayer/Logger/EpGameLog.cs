using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EpGame.Core.BusinessLogicLayer.Logger
{
	public class EpGameLog
	{
		public static void AddLog(string message,LogType Logtype) 
		{
			FileStream file = new FileStream("EpGameLogs.txt", FileMode.Append);
			StreamWriter writer = new StreamWriter(file);
			writer.WriteLine("Log Türü: " + Logtype + " Hata Mesajı: " + message + " Log Tarihi:" + DateTime.Now);
			writer.Close();
		}
	}
	public enum LogType 
	{
		Error,
		Warning,
		Info,
		Insert,
		Update,
		Delete,
		NotFound,
		NonValidation
	}
}
