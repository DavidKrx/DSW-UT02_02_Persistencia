using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace UT02_02_CodeFirst.Migrations
{
    /// <inheritdoc />
    public partial class Seedercars : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.UpdateData(
                table: "Car",
                keyColumn: "Id",
                keyValue: 1,
                column: "ReleaseDate",
                value: new DateTime(2024, 10, 7, 13, 5, 31, 525, DateTimeKind.Local).AddTicks(707));

            migrationBuilder.UpdateData(
                table: "Car",
                keyColumn: "Id",
                keyValue: 2,
                column: "ReleaseDate",
                value: new DateTime(2024, 10, 7, 13, 5, 31, 525, DateTimeKind.Local).AddTicks(753));

            migrationBuilder.UpdateData(
                table: "Car",
                keyColumn: "Id",
                keyValue: 3,
                column: "ReleaseDate",
                value: new DateTime(2024, 10, 7, 13, 5, 31, 525, DateTimeKind.Local).AddTicks(756));
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.UpdateData(
                table: "Car",
                keyColumn: "Id",
                keyValue: 1,
                column: "ReleaseDate",
                value: new DateTime(2024, 10, 4, 9, 47, 34, 996, DateTimeKind.Local).AddTicks(3978));

            migrationBuilder.UpdateData(
                table: "Car",
                keyColumn: "Id",
                keyValue: 2,
                column: "ReleaseDate",
                value: new DateTime(2024, 10, 4, 9, 47, 34, 996, DateTimeKind.Local).AddTicks(4025));

            migrationBuilder.UpdateData(
                table: "Car",
                keyColumn: "Id",
                keyValue: 3,
                column: "ReleaseDate",
                value: new DateTime(2024, 10, 4, 9, 47, 34, 996, DateTimeKind.Local).AddTicks(4028));
        }
    }
}
