using System;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata;

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

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<Product>()
                   //.HasOne(z => z.Product)
                   .HasMany(c => c.Reviews)
                   .WithOne(e => e.Product)
                        .OnDelete(DeleteBehavior.Cascade)
                      
                   .IsRequired();

            //base.OnModelCreating(builder);
        }


    }
}