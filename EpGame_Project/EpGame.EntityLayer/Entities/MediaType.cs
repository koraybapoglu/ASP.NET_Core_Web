using EpGame.Core.Entity;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EpGame.EntityLayer.Entities
{
	public class MediaType:BaseEntity
	{
        public string MediaTypeName { get; set; }
        public double MediaSize { get; set; }
        public virtual ICollection<Media> Media { get; set; }
    }
}
