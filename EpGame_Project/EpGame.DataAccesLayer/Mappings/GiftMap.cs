using EpGame.EntityLayer.Entities;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection.Emit;
using System.Text;
using System.Threading.Tasks;

namespace EpGame.DataAccesLayer.Mappings
{
	public class GiftMap : IEntityTypeConfiguration<Gift>
	{
		public void Configure(EntityTypeBuilder<Gift> builder)
		{
			builder.ToTable("Gifts"); // Tablo adını belirtiyoruz
			builder.HasKey(g => g.ID); // Primary key'i belirtiyoruz
			builder.Property(g => g.ID)
				.HasColumnName("GiftID"); // Kolon adını belirtiyoruz

			builder.Property(g => g.GameID)
				.IsRequired(); // GameID alanının zorunlu olduğunu belirtiyoruz

			builder.Property(g => g.SendUserID)
				.IsRequired(); // SendUserID alanının zorunlu olduğunu belirtiyoruz

			builder.Property(g => g.ReceiverUserID)
				.IsRequired(); // ReceiverUserID alanının zorunlu olduğunu belirtiyoruz

			// Games ile ilişkiyi belirtiyoruz
			builder.HasOne(g => g.Games)
				.WithMany()
				.HasForeignKey(g => g.GameID);

			// Diğer özel eşlemeleri veya kısıtlamaları ekleyebilirsiniz
		}
	}
}
