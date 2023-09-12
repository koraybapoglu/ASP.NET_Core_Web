using EpGame.Core.Entity;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EpGame.EntityLayer.Entities
{
	public class Cart : BaseEntity
	{
		public int GameID { get; set; }
		public int AppUserID { get; set; }
		public double TotalPrice { get; set; }
		public virtual Game Game { get; set; }
		public virtual AppUser AppUser { get; set; }
	}
}
