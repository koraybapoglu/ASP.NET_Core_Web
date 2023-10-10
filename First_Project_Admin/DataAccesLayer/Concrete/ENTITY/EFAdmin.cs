using Admin.Core.Entity;
using Admin.EntityLayer.POCO;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Admin.DataAccesLayer.Concrete.ENTITY
{
    public class EFAdmin : IAdminDAL
    {
        private readonly AdminDBContext db=new AdminDBContext();
        public bool Add(Admins entity)
        {
            db.Add(entity);
            return db.SaveChanges() > 0 ? true : false;
        }

        public bool Delete(Admins entity)
        {
            db.Remove(entity);
            return db.SaveChanges() > 0 ? true : false;
        }

        public Admins Get(int id)
        {
            var admin=db.Set<Admins>().Find(id);
            if (admin!=null)
            {
                return admin;
            }
            else
            {
                return null;
            } 
        }

        public List<Admins> GetAll()
        {
            List<Admins> Admins = db.Set<Admins>().ToList();
            if (Admins!=null)
            {
                return Admins;
            }
            else
            {
                return null;
            }
        }

        public int GetIdByEmail(string email)
        {
            var admin = db.Set<Admins>().FirstOrDefault(a => a.Email == email);
            return admin != null ? admin.ID : -1;
        }

        public bool Update(Admins entity)
        {
            db.Update(entity);
            return db.SaveChanges() > 0 ? true : false;
        }
    }
}
