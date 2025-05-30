using Microsoft.EntityFrameworkCore;
using FinancialControl.Domain.Entities;

namespace FinancialControl.Infrastructure.Data
{
    public class AppDbContext : DbContext
    {
        public AppDbContext(DbContextOptions<AppDbContext> options) : base(options) { }

        public DbSet<User> Users { get; set; }
        public DbSet<Transaction> Transactions { get; set; }
        public DbSet<Origin> Origins { get; set; }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {   
            foreach(var entityType in modelBuilder.Model.GetEntityTypes())
            {
                var dateTimeProperties = entityType.GetProperties()
                    .Where(p => p.ClrType == typeof(DateTime) || p.ClrType == typeof(DateTime?));

                foreach(var property in dateTimeProperties)
                {
                    property.SetColumnType("timestamp without time zone");
                }
            }

            base.OnModelCreating(modelBuilder);

        }
    }
}
