using BillVu.WebApi.Models;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

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
            SeedData.Add(modelBuilder);
        }
    }
}
