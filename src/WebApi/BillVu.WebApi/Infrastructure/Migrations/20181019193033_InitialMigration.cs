using System;
using Microsoft.EntityFrameworkCore.Migrations;

namespace BillVu.WebApi.Infrastructure.Migrations
{
    public partial class InitialMigration : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "Bills",
                columns: table => new
                {
                    Id = table.Column<Guid>(nullable: false),
                    Name = table.Column<string>(nullable: false),
                    ServiceProviderName = table.Column<string>(nullable: false),
                    Amount = table.Column<double>(nullable: false),
                    DueDate = table.Column<DateTime>(nullable: false),
                    ReminderDate = table.Column<DateTime>(nullable: true),
                    OnlinePayUrl = table.Column<string>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Bills", x => new { x.Name, x.ServiceProviderName });
                });

            migrationBuilder.InsertData(
                table: "Bills",
                columns: new[] { "Name", "ServiceProviderName", "Amount", "DueDate", "Id", "OnlinePayUrl", "ReminderDate" },
                values: new object[] { "Internet", "TWC", 0.0, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new Guid("515fe2a5-c375-494a-9b6b-9c7a091f1c6d"), null, null });

            migrationBuilder.InsertData(
                table: "Bills",
                columns: new[] { "Name", "ServiceProviderName", "Amount", "DueDate", "Id", "OnlinePayUrl", "ReminderDate" },
                values: new object[] { "Water", "Charlotte City", 0.0, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new Guid("297df756-93e5-4582-af8e-1e7a0f58026e"), null, null });

            migrationBuilder.InsertData(
                table: "Bills",
                columns: new[] { "Name", "ServiceProviderName", "Amount", "DueDate", "Id", "OnlinePayUrl", "ReminderDate" },
                values: new object[] { "Power", "Duke Energy", 0.0, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new Guid("4260d6a2-0a4e-44aa-9ece-71414c8f4054"), null, null });

            migrationBuilder.InsertData(
                table: "Bills",
                columns: new[] { "Name", "ServiceProviderName", "Amount", "DueDate", "Id", "OnlinePayUrl", "ReminderDate" },
                values: new object[] { "TV", "TWC", 0.0, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new Guid("51435860-b83e-4900-a99b-93cc3ba06908"), null, null });

            migrationBuilder.CreateIndex(
                name: "IX_Bills_Id",
                table: "Bills",
                column: "Id",
                unique: true);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "Bills");
        }
    }
}
