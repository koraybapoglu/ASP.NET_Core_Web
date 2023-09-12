using EpGame.DataAccesLayer.Mappings;
using EpGame.EntityLayer.Entities;
using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection.Emit;
using System.Text;
using System.Threading.Tasks;

namespace EpGame.DataAccesLayer
{
	public class EpGameDbContext : IdentityDbContext<AppUser, AppRole, int>
	{
		protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
		{
			optionsBuilder.UseSqlServer("Server=DESKTOP-RN1V6Q9;Database=EpGame;Trusted_Connection=True;TrustServerCertificate=true;");
			base.OnConfiguring(optionsBuilder);
		}
		protected override void OnModelCreating(ModelBuilder builder)
		{
			//builder.ApplyConfiguration(new GameMap());
			//builder.ApplyConfiguration(new CategoryMap());
			//builder.ApplyConfiguration(new CartMap());
			//builder.ApplyConfiguration(new GameCategoryMap());
			//builder.ApplyConfiguration(new GiftMap());
			//builder.ApplyConfiguration(new MediaMap());
			//builder.ApplyConfiguration(new MediaTypeMap());
			builder.Entity<AppRole>().HasData(
				   new AppRole { Id = 1, Name = "Admin", NormalizedName = "ADMIN" },
				   new AppRole { Id = 2, Name = "UserApp", NormalizedName = "USERAPP" }
				   );
			base.OnModelCreating(builder);
			builder.Entity<IdentityUserLogin<int>>().HasKey(l => l.UserId);
		}
		public DbSet<Game> Games { get; set; }
		public DbSet<Category> Categories { get; set; }
		public DbSet<GameCategory> GameCategories { get; set; }
		public DbSet<Media> Medias { get; set; }
		public DbSet<MediaType> MediaTypes { get; set; }
		public DbSet<Cart> Carts { get; set; }
		public DbSet<Gift> Gifts { get; set; }
	}
}
