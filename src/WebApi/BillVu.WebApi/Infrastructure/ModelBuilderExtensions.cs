using BillVu.WebApi.Models;
using Microsoft.EntityFrameworkCore;
using System;

namespace BillVu.WebApi.Infrastructure
{
    public static class ModelBuilderExtensions
    {
        public static void AddSeedData(this ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<Bill>().HasData(
                        new Bill { Id = new Guid("515FE2A5-C375-494A-9B6B-9C7A091F1C6D"), Name = "Internet", ServiceProviderName = "TWC" },
                        new Bill { Id = new Guid("297DF756-93E5-4582-AF8E-1E7A0F58026E"), Name = "Water", ServiceProviderName = "Charlotte City" },
                        new Bill { Id = new Guid("4260D6A2-0A4E-44AA-9ECE-71414C8F4054"), Name = "Power", ServiceProviderName = "Duke Energy" },
                        new Bill { Id = new Guid("51435860-B83E-4900-A99B-93CC3BA06908"), Name = "TV", ServiceProviderName = "TWC" }
                        );
        }
    }
}
