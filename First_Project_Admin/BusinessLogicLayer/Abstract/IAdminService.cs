using Admin.Core.BusinessLogicLayer;
using Admin.EntityLayer.POCO;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Admin.BusinessLogicLayer.Abstract
{
    public interface IAdminService : IGenericService<Admins>
    { 
        int GetIdByEmail(string email);
    }
}
