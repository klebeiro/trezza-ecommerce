using chronovault_api.Model;
using Microsoft.EntityFrameworkCore;

namespace chronovault_api.Infra.Data
{
    public class ChronovaultDbContext : DbContext {
        public DbSet<Product> Products { get; set; }
        public DbSet<User> Users { get; set; }

        public ChronovaultDbContext(DbContextOptions<ChronovaultDbContext> options)
        : base(options) { }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            base.OnModelCreating(modelBuilder);
        }
    }
}
