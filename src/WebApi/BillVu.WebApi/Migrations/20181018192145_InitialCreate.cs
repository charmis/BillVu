using System;
using Microsoft.EntityFrameworkCore.Migrations;

namespace BillVu.WebApi.Migrations
{
    public partial class InitialCreate : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "Bills",
                columns: table => new
                {
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
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "Bills");
        }
    }
}
