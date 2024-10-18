using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

#pragma warning disable CA1814 // Prefer jagged arrays over multidimensional

namespace ConcessionaireAppServer.Entities.Migrations
{
    /// <inheritdoc />
    public partial class SeedData3 : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.InsertData(
                table: "Sellers",
                columns: new[] { "Id", "Email", "JoinDate", "Location", "Name", "PhoneNumber" },
                values: new object[,]
                {
                    { 1, "test.sample@example.com", new DateTime(2024, 10, 17, 21, 18, 31, 235, DateTimeKind.Local).AddTicks(3727), "Test street", "TestSeller", "4273629" },
                    { 2, "test.sample2@example.com", new DateTime(2024, 10, 17, 21, 18, 31, 235, DateTimeKind.Local).AddTicks(3752), "Test street", "TestSeller2", "7332626" }
                });

            migrationBuilder.UpdateData(
                table: "Vehicles",
                keyColumn: "Id",
                keyValue: -8,
                column: "DateAdded",
                value: new DateTime(2024, 10, 17, 21, 18, 31, 235, DateTimeKind.Local).AddTicks(3699));

            migrationBuilder.UpdateData(
                table: "Vehicles",
                keyColumn: "Id",
                keyValue: -7,
                column: "DateAdded",
                value: new DateTime(2024, 10, 17, 21, 18, 31, 235, DateTimeKind.Local).AddTicks(3680));

            migrationBuilder.UpdateData(
                table: "Vehicles",
                keyColumn: "Id",
                keyValue: -6,
                column: "DateAdded",
                value: new DateTime(2024, 10, 17, 21, 18, 31, 235, DateTimeKind.Local).AddTicks(3660));

            migrationBuilder.UpdateData(
                table: "Vehicles",
                keyColumn: "Id",
                keyValue: -5,
                column: "DateAdded",
                value: new DateTime(2024, 10, 17, 21, 18, 31, 235, DateTimeKind.Local).AddTicks(3639));

            migrationBuilder.UpdateData(
                table: "Vehicles",
                keyColumn: "Id",
                keyValue: -4,
                column: "DateAdded",
                value: new DateTime(2024, 10, 17, 21, 18, 31, 235, DateTimeKind.Local).AddTicks(3619));

            migrationBuilder.UpdateData(
                table: "Vehicles",
                keyColumn: "Id",
                keyValue: -3,
                column: "DateAdded",
                value: new DateTime(2024, 10, 17, 21, 18, 31, 235, DateTimeKind.Local).AddTicks(3599));

            migrationBuilder.UpdateData(
                table: "Vehicles",
                keyColumn: "Id",
                keyValue: -2,
                column: "DateAdded",
                value: new DateTime(2024, 10, 17, 21, 18, 31, 235, DateTimeKind.Local).AddTicks(3579));

            migrationBuilder.UpdateData(
                table: "Vehicles",
                keyColumn: "Id",
                keyValue: -1,
                column: "DateAdded",
                value: new DateTime(2024, 10, 17, 21, 18, 31, 235, DateTimeKind.Local).AddTicks(3543));
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "Sellers",
                keyColumn: "Id",
                keyValue: 1);

            migrationBuilder.DeleteData(
                table: "Sellers",
                keyColumn: "Id",
                keyValue: 2);

            migrationBuilder.UpdateData(
                table: "Vehicles",
                keyColumn: "Id",
                keyValue: -8,
                column: "DateAdded",
                value: new DateTime(2024, 10, 17, 21, 17, 37, 461, DateTimeKind.Local).AddTicks(5847));

            migrationBuilder.UpdateData(
                table: "Vehicles",
                keyColumn: "Id",
                keyValue: -7,
                column: "DateAdded",
                value: new DateTime(2024, 10, 17, 21, 17, 37, 461, DateTimeKind.Local).AddTicks(5827));

            migrationBuilder.UpdateData(
                table: "Vehicles",
                keyColumn: "Id",
                keyValue: -6,
                column: "DateAdded",
                value: new DateTime(2024, 10, 17, 21, 17, 37, 461, DateTimeKind.Local).AddTicks(5808));

            migrationBuilder.UpdateData(
                table: "Vehicles",
                keyColumn: "Id",
                keyValue: -5,
                column: "DateAdded",
                value: new DateTime(2024, 10, 17, 21, 17, 37, 461, DateTimeKind.Local).AddTicks(5787));

            migrationBuilder.UpdateData(
                table: "Vehicles",
                keyColumn: "Id",
                keyValue: -4,
                column: "DateAdded",
                value: new DateTime(2024, 10, 17, 21, 17, 37, 461, DateTimeKind.Local).AddTicks(5767));

            migrationBuilder.UpdateData(
                table: "Vehicles",
                keyColumn: "Id",
                keyValue: -3,
                column: "DateAdded",
                value: new DateTime(2024, 10, 17, 21, 17, 37, 461, DateTimeKind.Local).AddTicks(5746));

            migrationBuilder.UpdateData(
                table: "Vehicles",
                keyColumn: "Id",
                keyValue: -2,
                column: "DateAdded",
                value: new DateTime(2024, 10, 17, 21, 17, 37, 461, DateTimeKind.Local).AddTicks(5724));

            migrationBuilder.UpdateData(
                table: "Vehicles",
                keyColumn: "Id",
                keyValue: -1,
                column: "DateAdded",
                value: new DateTime(2024, 10, 17, 21, 17, 37, 461, DateTimeKind.Local).AddTicks(5687));
        }
    }
}
