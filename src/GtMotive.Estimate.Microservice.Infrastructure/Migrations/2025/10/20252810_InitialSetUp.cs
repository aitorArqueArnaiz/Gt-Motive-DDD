using System;
using Microsoft.EntityFrameworkCore.Migrations;

namespace GtMotive.Estimate.Microservice.Infrastructure.Migrations
{
    public partial class InitialCreate : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "Cars",
                columns: table => new
                {
                    Id = table.Column<string>(type: "uniqueidentifier", nullable: false),
                    Brand = table.Column<string>(type: "varchar(255)", nullable: true),
                    Model = table.Column<string>(type: "varchar(255)", nullable: true),
                    Year = table.Column<int>(type: "int", nullable: true),
                    IsAvaible = table.Column<bool>(type: "bit", nullable: false),
                    Registration = table.Column<string>(type: "uniqueidentifier", nullable: true),
                    IsDeleted = table.Column<int>(type: "int", nullable: false),
                    CreatedAt = table.Column<DateTime>(type: "timestamp", nullable: false),
                    UpdatedAt = table.Column<DateTime>(type: "timestamp", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Car", x => x.Id);
                });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "Cars");
        }
    }
}
