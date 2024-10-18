using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

#pragma warning disable CA1814 // Prefer jagged arrays over multidimensional

namespace ConcessionaireAppServer.Entities.Migrations
{
    /// <inheritdoc />
    public partial class SeedData4 : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.InsertData(
                table: "Sales",
                columns: new[] { "Id", "CustomerEmail", "CustomerName", "CustomerPhone", "SaleAmount", "SaleDate", "SellerId", "VehicleId" },
                values: new object[,]
                {
                    { -2, "test.sampleCustomer2@example.com", "TestCustomer2", "72651726", 94000000m, new DateTime(2024, 10, 17, 21, 24, 10, 753, DateTimeKind.Local).AddTicks(9024), 2, -6 },
                    { -1, "test.sampleCustomer1@example.com", "TestCustomer1", "72651726", 93000000m, new DateTime(2024, 10, 17, 21, 24, 10, 753, DateTimeKind.Local).AddTicks(9001), 1, -3 }
                });

            migrationBuilder.UpdateData(
                table: "Sellers",
                keyColumn: "Id",
                keyValue: 1,
                column: "JoinDate",
                value: new DateTime(2024, 10, 17, 21, 24, 10, 753, DateTimeKind.Local).AddTicks(8955));

            migrationBuilder.UpdateData(
                table: "Sellers",
                keyColumn: "Id",
                keyValue: 2,
                column: "JoinDate",
                value: new DateTime(2024, 10, 17, 21, 24, 10, 753, DateTimeKind.Local).AddTicks(8979));

            migrationBuilder.UpdateData(
                table: "Vehicles",
                keyColumn: "Id",
                keyValue: -8,
                column: "DateAdded",
                value: new DateTime(2024, 10, 17, 21, 24, 10, 753, DateTimeKind.Local).AddTicks(8927));

            migrationBuilder.UpdateData(
                table: "Vehicles",
                keyColumn: "Id",
                keyValue: -7,
                column: "DateAdded",
                value: new DateTime(2024, 10, 17, 21, 24, 10, 753, DateTimeKind.Local).AddTicks(8905));

            migrationBuilder.UpdateData(
                table: "Vehicles",
                keyColumn: "Id",
                keyValue: -6,
                column: "DateAdded",
                value: new DateTime(2024, 10, 17, 21, 24, 10, 753, DateTimeKind.Local).AddTicks(8884));

            migrationBuilder.UpdateData(
                table: "Vehicles",
                keyColumn: "Id",
                keyValue: -5,
                column: "DateAdded",
                value: new DateTime(2024, 10, 17, 21, 24, 10, 753, DateTimeKind.Local).AddTicks(8861));

            migrationBuilder.UpdateData(
                table: "Vehicles",
                keyColumn: "Id",
                keyValue: -4,
                column: "DateAdded",
                value: new DateTime(2024, 10, 17, 21, 24, 10, 753, DateTimeKind.Local).AddTicks(8840));

            migrationBuilder.UpdateData(
                table: "Vehicles",
                keyColumn: "Id",
                keyValue: -3,
                column: "DateAdded",
                value: new DateTime(2024, 10, 17, 21, 24, 10, 753, DateTimeKind.Local).AddTicks(8819));

            migrationBuilder.UpdateData(
                table: "Vehicles",
                keyColumn: "Id",
                keyValue: -2,
                column: "DateAdded",
                value: new DateTime(2024, 10, 17, 21, 24, 10, 753, DateTimeKind.Local).AddTicks(8797));

            migrationBuilder.UpdateData(
                table: "Vehicles",
                keyColumn: "Id",
                keyValue: -1,
                column: "DateAdded",
                value: new DateTime(2024, 10, 17, 21, 24, 10, 753, DateTimeKind.Local).AddTicks(8745));
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "Sales",
                keyColumn: "Id",
                keyValue: -2);

            migrationBuilder.DeleteData(
                table: "Sales",
                keyColumn: "Id",
                keyValue: -1);

            migrationBuilder.UpdateData(
                table: "Sellers",
                keyColumn: "Id",
                keyValue: 1,
                column: "JoinDate",
                value: new DateTime(2024, 10, 17, 21, 18, 31, 235, DateTimeKind.Local).AddTicks(3727));

            migrationBuilder.UpdateData(
                table: "Sellers",
                keyColumn: "Id",
                keyValue: 2,
                column: "JoinDate",
                value: new DateTime(2024, 10, 17, 21, 18, 31, 235, DateTimeKind.Local).AddTicks(3752));

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
    }
}
