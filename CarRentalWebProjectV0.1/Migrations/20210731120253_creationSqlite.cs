using System;
using Microsoft.EntityFrameworkCore.Migrations;

namespace CarRentalWebProjectV0._1.Migrations
{
    public partial class creationSqlite : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "CarRentals",
                columns: table => new
                {
                    CarRentalId = table.Column<int>(type: "INTEGER", nullable: false)
                        .Annotation("Sqlite:Autoincrement", true),
                    Name = table.Column<string>(type: "TEXT", nullable: true),
                    CpfCnpj = table.Column<int>(type: "INTEGER", nullable: false),
                    Telephone = table.Column<int>(type: "INTEGER", nullable: false),
                    Email = table.Column<string>(type: "TEXT", nullable: true),
                    Country = table.Column<string>(type: "TEXT", nullable: true),
                    Model = table.Column<string>(type: "TEXT", nullable: true),
                    LicensePlate = table.Column<string>(type: "TEXT", nullable: true),
                    Payment = table.Column<string>(type: "TEXT", nullable: true),
                    Withdraw = table.Column<DateTime>(type: "TEXT", nullable: false),
                    Devolution = table.Column<DateTime>(type: "TEXT", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_CarRentals", x => x.CarRentalId);
                });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "CarRentals");
        }
    }
}
