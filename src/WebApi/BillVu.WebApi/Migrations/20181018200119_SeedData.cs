using System;
using Microsoft.EntityFrameworkCore.Migrations;

namespace BillVu.WebApi.Migrations
{
    public partial class SeedData : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.InsertData(
                table: "Bills",
                columns: new[] { "Name", "ServiceProviderName", "Amount", "DueDate", "OnlinePayUrl", "ReminderDate" },
                values: new object[] { "Internet", "TWC", 0.0, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, null });

            migrationBuilder.InsertData(
                table: "Bills",
                columns: new[] { "Name", "ServiceProviderName", "Amount", "DueDate", "OnlinePayUrl", "ReminderDate" },
                values: new object[] { "Water", "Charlotte City", 0.0, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, null });

            migrationBuilder.InsertData(
                table: "Bills",
                columns: new[] { "Name", "ServiceProviderName", "Amount", "DueDate", "OnlinePayUrl", "ReminderDate" },
                values: new object[] { "Power", "Duke Energy", 0.0, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, null });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "Bills",
                keyColumns: new[] { "Name", "ServiceProviderName" },
                keyValues: new object[] { "Internet", "TWC" });

            migrationBuilder.DeleteData(
                table: "Bills",
                keyColumns: new[] { "Name", "ServiceProviderName" },
                keyValues: new object[] { "Power", "Duke Energy" });

            migrationBuilder.DeleteData(
                table: "Bills",
                keyColumns: new[] { "Name", "ServiceProviderName" },
                keyValues: new object[] { "Water", "Charlotte City" });
        }
    }
}
