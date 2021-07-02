using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Text;
using Electricad.Models;

namespace Electricad.Data
{
    public class ApplicationDbContext : DbContext
    {
        public ApplicationDbContext(DbContextOptions<ApplicationDbContext> options)
            : base(options)
        {
        }

        public DbSet<User> User { get; set; }
        public DbSet<Review> tb_reviews { get; set; }
        public DbSet<About> tb_about { get; set; }
        public DbSet<Offers> tb_offers { get; set; }
        public DbSet<Portifolio> tb_portifolio { get; set; }
        public DbSet<Sectors> tb_sectors { get; set; }




        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<Review>(entity =>
            {
                entity.Property(e => e.name).IsRequired();
                entity.Property(e => e.comment).IsRequired();
                entity.Property(e => e.dateComment).IsRequired();
            });
        }
         
        }
}
