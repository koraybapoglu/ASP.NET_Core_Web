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
	public class GameMap : IEntityTypeConfiguration<Game>
	{
		public void Configure(EntityTypeBuilder<Game> builder)
		{
			builder.ToTable("Games"); // Tablo adı belirleyin, gerektiğinde değiştirin

			builder.HasKey(x => x.ID); // Anahtar alanını belirtin, Id özelliğini kullanıyorum.

			builder.Property(x => x.GameName)
				.HasColumnName("Name")
				.IsRequired()
				.HasMaxLength(40); // Maksimum karakter uzunluğunu belirleyin

			builder.Property(x => x.Price)
				.HasColumnName("Price")
				.IsRequired();

			builder.Property(x => x.PublishDate)
				.HasColumnName("PublishDate")
				.IsRequired();

			// Diğer özellikler için aynı şekilde devam edebilirsiniz.

			// Örnek: Rating özelliğini eklemek
			builder.Property(x => x.Rating)
				.HasColumnName("Rating")
				.IsRequired();

			// Diğer ilişkilendirilmiş varlıkları eklemek için:
			builder.HasMany(x => x.Cart)
				.WithOne()
				.HasForeignKey("GameId")
				.IsRequired();

			builder.HasMany(x => x.GameCategory)
				.WithOne()
				.HasForeignKey("GameId")
				.IsRequired();

			builder.HasMany(x => x.Media)
				.WithOne()
				.HasForeignKey("GameId")
				.IsRequired();

			builder.HasMany(x => x.Gift)
				.WithOne()
				.HasForeignKey("GameId")
				.IsRequired();
		}
	}
}