﻿// <auto-generated />
using System;
using BillVu.WebApi.Infrastructure;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;

namespace BillVu.WebApi.Migrations
{
    [DbContext(typeof(BillVuDbContext))]
    partial class BillVuDbContextModelSnapshot : ModelSnapshot
    {
        protected override void BuildModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "2.1.4-rtm-31024");

            modelBuilder.Entity("BillVu.WebApi.Models.Bill", b =>
                {
                    b.Property<string>("Name");

                    b.Property<string>("ServiceProviderName");

                    b.Property<double>("Amount");

                    b.Property<DateTime>("DueDate");

                    b.Property<string>("OnlinePayUrl");

                    b.Property<DateTime?>("ReminderDate");

                    b.HasKey("Name", "ServiceProviderName");

                    b.ToTable("Bills");

                    b.HasData(
                        new { Name = "Internet", ServiceProviderName = "TWC", Amount = 0.0, DueDate = new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified) },
                        new { Name = "Water", ServiceProviderName = "Charlotte City", Amount = 0.0, DueDate = new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified) },
                        new { Name = "Power", ServiceProviderName = "Duke Energy", Amount = 0.0, DueDate = new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified) }
                    );
                });
#pragma warning restore 612, 618
        }
    }
}
