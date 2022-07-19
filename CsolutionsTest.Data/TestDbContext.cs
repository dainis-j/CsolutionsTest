using CsolutionsTest.Data.Models;
using Microsoft.EntityFrameworkCore;

namespace CsolutionsTest.Data
{
    public class TestDbContext : DbContext
    {
        public TestDbContext(DbContextOptions<TestDbContext> options)
            : base(options)
        {
        }

        public DbSet<Product>? Product { get; set; }

        public DbSet<AuditOperation>? AuditOperations { get; set; }
    }
}
