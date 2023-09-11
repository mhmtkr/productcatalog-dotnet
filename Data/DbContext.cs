using Microsoft.EntityFrameworkCore;

namespace Projects.Data
{
    public class DbContext : Microsoft.EntityFrameworkCore.DbContext
    {
        public DbContext(DbContextOptions<DbContext> options) : base(options)
        {
        }

        public DbSet<Product> Products { get; set; }

        // Add other DbSet properties for other entities, if needed

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            base.OnModelCreating(modelBuilder);

            // Define additional configurations for the entities, if needed
            // For example, you can set table names, relationships, etc.
        }
    }
}