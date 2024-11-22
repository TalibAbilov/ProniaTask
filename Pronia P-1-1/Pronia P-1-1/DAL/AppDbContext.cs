using Microsoft.EntityFrameworkCore;
using Pronia_P_1_1.Models;

namespace Pronia_P_1_1.DAL
{
    public class AppDbContext : DbContext
    {
        public AppDbContext(DbContextOptions options):base(options)
        {
            
        }
        public DbSet<Slider> Sliders { get; set; }
        public DbSet<Product> Products { get; set; }
        public DbSet<Category> Categories { get; set; }
        public DbSet<Tag> Tags { get; set; }
        public DbSet<TagProduct> TagsProducts { get; set; }
        public DbSet<ProductImage> ProductImages { get; set; }
    }
}
