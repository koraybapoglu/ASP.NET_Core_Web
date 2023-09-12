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
	public class CategoryMap : IEntityTypeConfiguration<Category>
	{
		public void Configure(EntityTypeBuilder<Category> builder)
		{
			builder.ToTable("Categories"); // Tablo adını belirleyebilirsiniz.

			builder.HasKey(c => c.ID); // Primary key'i belirtiyoruz.

			builder.Property(c => c.ID)
				.ValueGeneratedOnAdd(); // ID alanının otomatik olarak oluşturulmasını sağlıyoruz.

			builder.Property(c => c.CategoryName)
				.IsRequired() // Zorunlu alan olduğunu belirtiyoruz.
				.HasMaxLength(255); // Maksimum karakter uzunluğunu belirtiyoruz.

			builder.Property(c => c.Active)
				.IsRequired(); // Zorunlu alan olduğunu belirtiyoruz.

			builder.Property(c => c.CreatedTime)
				.IsRequired(); // Zorunlu alan olduğunu belirtiyoruz.

			builder.Property(c => c.UpdatedTime)
				.IsRequired(); // Zorunlu alan olduğunu belirtiyoruz.

			// GameCategory ilişkisi için navigation property'yi tanımlıyoruz.
			builder.HasMany(c => c.GameCategory)
				.WithOne(gc => gc.Categories)
				.HasForeignKey(gc => gc.CategoryID); // ForeignKey'i belirtiyoruz.
		}
	}
}
