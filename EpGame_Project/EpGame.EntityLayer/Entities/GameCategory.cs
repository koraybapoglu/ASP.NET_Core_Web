using EpGame.Core.Entity;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EpGame.EntityLayer.Entities
{
	public class GameCategory : IBaseEntity
	{
		public int ID { get; set; }
		public int GameID { get; set; }
		public int CategoryID { get; set; }
		public Game Games { get; set; }
		public Category Categories { get; set; }
	}
}
