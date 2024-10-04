using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

#pragma warning disable CA1814 // Prefer jagged arrays over multidimensional

namespace UT02_02_CodeFirst.Migrations
{
    /// <inheritdoc />
    public partial class Seeder3car : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.InsertData(
                table: "Car",
                columns: new[] { "Id", "Brand", "Model", "Price", "ReleaseDate" },
                values: new object[,]
                {
                    { 1, "Seat", "Panda", 15000m, new DateTime(2024, 10, 4, 9, 47, 34, 996, DateTimeKind.Local).AddTicks(3978) },
                    { 2, "Seat", "Ibiza", 16000m, new DateTime(2024, 10, 4, 9, 47, 34, 996, DateTimeKind.Local).AddTicks(4025) },
                    { 3, "Audi", "Franchesco", 20000m, new DateTime(2024, 10, 4, 9, 47, 34, 996, DateTimeKind.Local).AddTicks(4028) }
                });
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "Car",
                keyColumn: "Id",
                keyValue: 1);

            migrationBuilder.DeleteData(
                table: "Car",
                keyColumn: "Id",
                keyValue: 2);

            migrationBuilder.DeleteData(
                table: "Car",
                keyColumn: "Id",
                keyValue: 3);
        }
    }
}
