using EpGame.Core.Entity;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EpGame.EntityLayer.Entities
{
	public class Category : BaseEntity
	{
		public string CategoryName { get; set; }
		public virtual ICollection<GameCategory> GameCategory { get; set; }
	}
}
