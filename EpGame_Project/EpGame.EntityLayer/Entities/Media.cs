using EpGame.Core.Entity;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EpGame.EntityLayer.Entities
{
	public class Media : BaseEntity
	{
		public string MediaURL { get; set; }
		public int MediaTypeID { get; set; }
        public int GameID { get; set; }
        public string AltText { get; set; }
        public virtual Game Game { get; set; }
        public virtual MediaType MediaType { get; set; }
    }
}
