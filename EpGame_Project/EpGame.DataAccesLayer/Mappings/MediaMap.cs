using EpGame.EntityLayer.Entities;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EpGame.DataAccesLayer.Mappings
{
	public class MediaMap : IEntityTypeConfiguration<Media>
	{
		public void Configure(EntityTypeBuilder<Media> builder)
		{
			throw new NotImplementedException();
		}
	}
}
