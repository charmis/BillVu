using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using BillVu.WebApi.Models;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.DependencyInjection;


namespace BillVu.WebApi.Infrastructure
{
    public static class SeedData
    {
        public static void Add(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<Bill>().HasData(
                        new Bill { Name = "Internet", ServiceProviderName = "TWC" },
                        new Bill { Name = "Water", ServiceProviderName = "Charlotte City" },
                        new Bill { Name = "Power", ServiceProviderName = "Duke Energy" }
                        );
        }
    }
}
