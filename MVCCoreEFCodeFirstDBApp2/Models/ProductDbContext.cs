using Microsoft.EntityFrameworkCore;

namespace MVCCoreCodeFirstEFApp.Models
{
    public class ProductDbContext : DbContext
    {
        public ProductDbContext(DbContextOptions<ProductDbContext> options)
        {

        }

        public DbSet<Category> Categories { get; set; }

        public DbSet<Product> Products { get; set; }

        protected override void OnConfiguring
            (DbContextOptionsBuilder optionsBuilder)
        {
            if (!optionsBuilder.IsConfigured)
            {
                optionsBuilder.UseSqlServer
                    ("data source=.\\sqlexpress;initial catalog=B21EFCoreCodeFirstDB;user id=user;password=123456;TrustServerCertificate=false;");
            }

            base.OnConfiguring(optionsBuilder);
        }
    }
}
