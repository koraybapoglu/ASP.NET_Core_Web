using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Admin.Core.Entity
{
    public interface IBaseEntity 
    {

    }
    public class BaseEntity:IBaseEntity
    {
        public BaseEntity()
        {
            Active = true;
            CreatedTime = DateTime.Now;
            UpdatedTime = DateTime.Now;
        }
        public int ID { get; set; }
        public bool Active { get; set; }
        public DateTime CreatedTime { get; set; }
        public DateTime UpdatedTime { get; set; }
    }
   
}
