using Microsoft.EntityFrameworkCore;

namespace GummiBear.Models
{
    public class GummiBearContext : DbContext
    {
        public DbSet<Product> Products { get; set; }
        public DbSet<Review> Reviews { get; set; }

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
            => optionsBuilder
                .UseMySql(@"Server=localhost;Port=8889;database=gummibear;uid=root;pwd=root;");
    }
}