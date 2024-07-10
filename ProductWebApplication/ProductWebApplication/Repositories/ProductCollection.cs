using Microsoft.EntityFrameworkCore;
using ProductWebApplication.Models;
namespace ProductWebApplication.Repositories
{
    public class ProductCollection:DbContext
    {
        public DbSet<Product>  Product { get; set; }

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            string conString = @"server=localhost;port=3306;user=root;password=root;database=ecommerce";
            optionsBuilder.UseMySQL(conString);
        }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            base.OnModelCreating(modelBuilder);
            modelBuilder.Entity<Product>(entity =>
            {
                entity.HasKey(p => p.Id);
                entity.Property(p => p.Title);
                entity.Property(p => p.Description);
                entity.Property(p => p.UnitPrice);
                entity.Property(p => p.img_url);
                entity.Property(p => p.quantity);
            });
        }

    }
}
