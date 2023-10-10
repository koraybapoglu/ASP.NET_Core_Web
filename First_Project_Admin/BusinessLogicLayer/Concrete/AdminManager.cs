using Admin.BusinessLogicLayer.Abstract;
using Admin.Core.BusinessLogicLayer.Logger;
using Admin.DataAccesLayer;
using Admin.EntityLayer.POCO;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Admin.BusinessLogicLayer.Concrete
{
    public class AdminManager : IAdminService
    {
        IAdminDAL DaL;
        public AdminManager(IAdminDAL AdminDaL)
        {
                DaL = AdminDaL;
        }
        public bool Add(Admins entity)
        {
            try
            {
                return DaL.Add(entity);
            }
            catch (Exception ex)
            {

                AdminLog.AddLog(ex.Message, LogType.Error);
                return false;
            }
        }

        public bool Delete(Admins entity)
        {
            try
            {
                return DaL.Delete(entity);
            }
            catch (Exception ex)
            {

                AdminLog.AddLog(ex.Message, LogType.Error);
                return false;
            }
        }

        public Admins Get(int id)
        {
            try
            {
                return DaL.Get(id);
            }
            catch (Exception ex)
            {

                AdminLog.AddLog(ex.Message, LogType.Error);
                return null;
            }
        }

        public List<Admins> GetAll()
        {
            try
            {
                return DaL.GetAll();
            }
            catch (Exception ex)
            {

                AdminLog.AddLog(ex.Message, LogType.Error);
                return null;
            }
        }

        public int GetIdByEmail(string email)
        {
            try
            {
                return DaL.GetIdByEmail(email);
            }
            catch (Exception ex)
            {
                return 0;
            }
           
        }

        public bool Update(Admins entity)
        {
            try
            {
                return DaL.Update(entity);
            }
            catch (Exception ex)
            {

                AdminLog.AddLog(ex.Message, LogType.Error);
                return false;
            }
        }
    }
}
