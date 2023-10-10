using Admin.Core.DataAccesLayer;
using Admin.EntityLayer.POCO;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Admin.DataAccesLayer
{
    public interface IAdminDAL : IRepository<Admins>
    {
        int GetIdByEmail(string email);
    }
}
