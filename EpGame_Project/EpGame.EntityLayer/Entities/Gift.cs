using EpGame.Core.Entity;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EpGame.EntityLayer.Entities
{
	public class Gift : BaseEntity
	{
		public int GameID { get; set; }
		public int SendUserID { get; set; }
		public int ReceiverUserID { get; set; }
		public virtual Game Games { get; set; }
	}
}
