using EpGame.Core.Entity;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EpGame.EntityLayer.Entities
{
	public class Game : BaseEntity
	{
		public string GameName { get; set; }
		public double Price { get; set; }
		public DateTime PublishDate { get; set; }
		public string Description { get; set; }
		public double Size { get; set; }
		public double Rating { get; set; }
		public string SystemRequirements { get; set; }
		public int DownloadCount { get; set; }
		public virtual ICollection<Cart> Cart { get; set; }
		public virtual ICollection<GameCategory> GameCategory { get; set; }
		public virtual ICollection<Media> Media { get; set; }
		public virtual ICollection<Gift> Gift { get; set; }
	}
}
