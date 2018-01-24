using Microsoft.EntityFrameworkCore;

namespace GummiBear.Models
{
    public class GummiBearContext : DbContext
    {
        public GummiBearContext()
        {
        }

        public DbSet<Product> Products { get; set; }

        public DbSet<Review> Reviews { get; set; }

        protected override void OnConfiguring(DbContextOptionsBuilder options)
        {
            options.UseMySql(@"Server=localhost;Port=8889;database=gummibear;uid=root;pwd=root;");
        }

        public GummiBearContext(DbContextOptions<GummiBearContext> options)
            : base(options)
        {
        }

        protected override void OnModelCreating(ModelBuilder builder)
        {
            base.OnModelCreating(builder);
        }
    }
}