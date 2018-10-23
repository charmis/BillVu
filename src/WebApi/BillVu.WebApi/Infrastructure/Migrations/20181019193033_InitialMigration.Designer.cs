﻿// <auto-generated />
using System;
using BillVu.WebApi.Infrastructure;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Migrations;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;

namespace BillVu.WebApi.Infrastructure.Migrations
{
    [DbContext(typeof(BillVuDbContext))]
    [Migration("20181019193033_InitialMigration")]
    partial class InitialMigration
    {
        protected override void BuildTargetModel(ModelBuilder modelBuilder)
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

                    b.Property<Guid>("Id")
                        .ValueGeneratedOnAdd();

                    b.Property<string>("OnlinePayUrl");

                    b.Property<DateTime?>("ReminderDate");

                    b.HasKey("Name", "ServiceProviderName");

                    b.HasIndex("Id")
                        .IsUnique();

                    b.ToTable("Bills");

                    b.HasData(
                        new { Name = "Internet", ServiceProviderName = "TWC", Amount = 0.0, DueDate = new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), Id = new Guid("515fe2a5-c375-494a-9b6b-9c7a091f1c6d") },
                        new { Name = "Water", ServiceProviderName = "Charlotte City", Amount = 0.0, DueDate = new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), Id = new Guid("297df756-93e5-4582-af8e-1e7a0f58026e") },
                        new { Name = "Power", ServiceProviderName = "Duke Energy", Amount = 0.0, DueDate = new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), Id = new Guid("4260d6a2-0a4e-44aa-9ece-71414c8f4054") },
                        new { Name = "TV", ServiceProviderName = "TWC", Amount = 0.0, DueDate = new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), Id = new Guid("51435860-b83e-4900-a99b-93cc3ba06908") }
                    );
                });
#pragma warning restore 612, 618
        }
    }
}
