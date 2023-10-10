using Admin.EntityLayer.POCO;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace Admin.DataAccesLayer.Mappings
{
    public class AdminMap : IEntityTypeConfiguration<Admins>
    {
        public void Configure(EntityTypeBuilder<Admins> builder)
        {
            builder.ToTable("Admins"); // Veritabanındaki tablo adını belirleyin

            builder.HasKey(e => e.ID); // Anahtar sütununu belirleyin

            // Diğer sütunları eşleyin
            builder.Property(e => e.ID).HasColumnName("ID");
            builder.Property(e => e.Active).HasColumnName("Active");
            builder.Property(e => e.CreatedTime).HasColumnName("CreatedTime");
            builder.Property(e => e.UpdatedTime).HasColumnName("UpdatedTime");
            builder.Property(e => e.UserName).HasColumnName("UserName");
            builder.Property(e => e.Password).HasColumnName("Password");
            builder.Property(e => e.Email).HasColumnName("Email");
        }
    }
}
