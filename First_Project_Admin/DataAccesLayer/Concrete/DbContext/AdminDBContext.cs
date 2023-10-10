using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Admin.DataAccesLayer.Mappings;
using Admin.EntityLayer.POCO;
using Microsoft.EntityFrameworkCore;

namespace Admin.DataAccesLayer
{
    public class AdminDBContext : DbContext
    {
        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder.UseSqlServer("Server=DESKTOP-RN1V6Q9;Database=DbBasicAdmin;Trusted_Connection=True;TrustServerCertificate=true;");
            base.OnConfiguring(optionsBuilder);
        }
        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.ApplyConfigurationsFromAssembly(typeof(AdminMap).Assembly);
        }
        public DbSet<Admins> Admins { get; set; }
    }
}
