using InvMIS.Domain.Entities;
using Microsoft.EntityFrameworkCore;

namespace InvMIS.Infrastructure.Data
{
    public class InvMISDbContext : DbContext
    {
        public InvMISDbContext(DbContextOptions<InvMISDbContext> options)
            : base(options) { }

        // DbSets for entities
        public DbSet<Product> Products { get; set; }

        // Optional: Fluent API configurations
        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            base.OnModelCreating(modelBuilder);
            // Example: Configure table name
            modelBuilder.Entity<Product>().ToTable("Products");
        }
    }
}
