using BillVu.WebApi.Models;
using Microsoft.EntityFrameworkCore;

namespace BillVu.WebApi.Infrastructure
{
    public class BillVuDbContext : DbContext
    {
        public BillVuDbContext(DbContextOptions<BillVuDbContext> options): base(options)
        {
        }

        public DbSet<Bill> Bills { get; set; }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<Bill>().HasKey(k => new { k.Name, k.ServiceProviderName });
            modelBuilder.Entity<Bill>().HasIndex(k => k.Id).IsUnique();
            modelBuilder.Entity<Bill>().Property(p => p.Id).ValueGeneratedOnAdd();

            modelBuilder.AddSeedData();
        }
    }
}
