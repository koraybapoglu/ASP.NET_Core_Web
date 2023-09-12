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
	public class GameCategoryMap : IEntityTypeConfiguration<GameCategory>
	{
		public void Configure(EntityTypeBuilder<GameCategory> builder)
		{
			builder.ToTable("GameCategories"); // Tablo adını belirleyebilirsiniz.

			builder.HasKey(gc => gc.ID); // Primary key'i belirtiyoruz.

			builder.Property(gc => gc.ID)
				.ValueGeneratedOnAdd(); // ID alanının otomatik olarak oluşturulmasını sağlıyoruz.

			builder.Property(gc => gc.GameID)
				.IsRequired(); // Zorunlu alan olduğunu belirtiyoruz.

			builder.Property(gc => gc.CategoryID)
				.IsRequired(); // Zorunlu alan olduğunu belirtiyoruz.

			// Game ilişkisi için navigation property'yi tanımlıyoruz.
			builder.HasOne(gc => gc.Games)
				.WithMany(g => g.GameCategory)
				.HasForeignKey(gc => gc.GameID); // ForeignKey'i belirtiyoruz.

			// Category ilişkisi için navigation property'yi tanımlıyoruz.
			builder.HasOne(gc => gc.Categories)
				.WithMany(c => c.GameCategory)
				.HasForeignKey(gc => gc.CategoryID); // ForeignKey'i belirtiyoruz.
		}
	}
}
