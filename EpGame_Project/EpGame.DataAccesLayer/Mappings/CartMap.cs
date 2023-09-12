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
	public class CartMap : IEntityTypeConfiguration<Cart>
	{
		public void Configure(EntityTypeBuilder<Cart> builder)
		{
			builder.ToTable("Carts"); // Tablo adını belirleyebilirsiniz.

			builder.HasKey(c => c.ID); // Primary key'i belirtiyoruz.

			builder.Property(c => c.ID)
				.ValueGeneratedOnAdd(); // ID alanının otomatik olarak oluşturulmasını sağlıyoruz.

			builder.Property(c => c.GameID)
				.IsRequired(); // Zorunlu alan olduğunu belirtiyoruz.

			builder.Property(c => c.AppUserID)
				.IsRequired(); // Zorunlu alan olduğunu belirtiyoruz.

			builder.Property(c => c.TotalPrice)
				.IsRequired(); // Zorunlu alan olduğunu belirtiyoruz.

			// Game ilişkisi için navigation property'yi tanımlıyoruz.
			builder.HasOne(c => c.Game)
				.WithMany(g => g.Cart)
				.HasForeignKey(c => c.GameID); // ForeignKey'i belirtiyoruz.

			// AppUser ilişkisi için navigation property'yi tanımlıyoruz.
			builder.HasOne(c => c.AppUser)
				.WithMany(u => u.Cart)
				.HasForeignKey(c => c.AppUserID); // ForeignKey'i belirtiyoruz.
		}
	}
}
