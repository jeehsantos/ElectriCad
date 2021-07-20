using Microsoft.EntityFrameworkCore;

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
        public DbSet<Portfolio> tb_portifolio { get; set; }
        public DbSet<Sectors> tb_sectors { get; set; }

    }
}
