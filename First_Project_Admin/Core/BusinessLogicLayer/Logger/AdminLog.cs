using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Admin.Core.BusinessLogicLayer.Logger
{
    public class AdminLog
    {
        public static void AddLog(string message, LogType logType)
        {
            FileStream file = new FileStream("AdminLog.txt", FileMode.Append);
            StreamWriter sw = new StreamWriter(file);
            sw.WriteLine("Log Türü : " + logType + " Hata Mesajı : " + message + " Log Tarihi : " + DateTime.Now);
            sw.Close();
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
