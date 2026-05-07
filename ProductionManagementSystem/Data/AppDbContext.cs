using Microsoft.EntityFrameworkCore;
using ProductionManagementSystem.Models;
namespace ProductionManagementSystem.Data

{
    public class AppDbContext: DbContext
    {
        public AppDbContext(DbContextOptions<AppDbContext> options)
            : base(options)
        {
        }

        public DbSet<Material> Materials { get; set; }
        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<Material>()
                .Property(x => x.Quantity)
                .HasPrecision(18, 2);

            modelBuilder.Entity<Material>()
                .Property(x => x.MinStock)
                .HasPrecision(18, 2);
        }
        public DbSet<ProductionEntry> ProductionEntries { get; set; }
    }
}
