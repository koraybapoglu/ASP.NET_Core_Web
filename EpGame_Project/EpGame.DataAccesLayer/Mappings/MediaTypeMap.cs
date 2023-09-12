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
	public class MediaTypeMap : IEntityTypeConfiguration<MediaType>
	{
		public void Configure(EntityTypeBuilder<MediaType> builder)
		{
			throw new NotImplementedException();
		}
	}
}
