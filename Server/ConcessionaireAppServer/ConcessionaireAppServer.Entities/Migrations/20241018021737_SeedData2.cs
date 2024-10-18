using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

#pragma warning disable CA1814 // Prefer jagged arrays over multidimensional

namespace ConcessionaireAppServer.Entities.Migrations
{
    /// <inheritdoc />
    public partial class SeedData2 : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.InsertData(
                table: "Vehicles",
                columns: new[] { "Id", "BrandId", "Color", "DateAdded", "Mileage", "Model", "Price", "StatusId", "TransmissionTypeId", "VehicleTypeId", "Year" },
                values: new object[,]
                {
                    { -8, -1, "Red", new DateTime(2024, 10, 17, 21, 17, 37, 461, DateTimeKind.Local).AddTicks(5847), 0, "CX-30", 93000000m, -1, -2, -1, 2024 },
                    { -7, -1, "Red", new DateTime(2024, 10, 17, 21, 17, 37, 461, DateTimeKind.Local).AddTicks(5827), 0, "CX-30", 93000000m, -1, -2, -1, 2024 },
                    { -6, -3, "Gray", new DateTime(2024, 10, 17, 21, 17, 37, 461, DateTimeKind.Local).AddTicks(5808), 0, "Nivus", 94000000m, -2, -2, -1, 2024 },
                    { -5, -3, "Red", new DateTime(2024, 10, 17, 21, 17, 37, 461, DateTimeKind.Local).AddTicks(5787), 0, "Nivus", 94000000m, -1, -2, -1, 2024 },
                    { -4, -3, "Gray", new DateTime(2024, 10, 17, 21, 17, 37, 461, DateTimeKind.Local).AddTicks(5767), 0, "Nivus", 94000000m, -1, -2, -1, 2024 },
                    { -3, -1, "Black", new DateTime(2024, 10, 17, 21, 17, 37, 461, DateTimeKind.Local).AddTicks(5746), 0, "CX-30", 93000000m, -2, -2, -1, 2024 },
                    { -2, -1, "Blue", new DateTime(2024, 10, 17, 21, 17, 37, 461, DateTimeKind.Local).AddTicks(5724), 0, "CX-30", 93000000m, -1, -2, -1, 2024 },
                    { -1, -1, "Red", new DateTime(2024, 10, 17, 21, 17, 37, 461, DateTimeKind.Local).AddTicks(5687), 0, "CX-30", 93000000m, -1, -2, -1, 2024 }
                });
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "Vehicles",
                keyColumn: "Id",
                keyValue: -8);

            migrationBuilder.DeleteData(
                table: "Vehicles",
                keyColumn: "Id",
                keyValue: -7);

            migrationBuilder.DeleteData(
                table: "Vehicles",
                keyColumn: "Id",
                keyValue: -6);

            migrationBuilder.DeleteData(
                table: "Vehicles",
                keyColumn: "Id",
                keyValue: -5);

            migrationBuilder.DeleteData(
                table: "Vehicles",
                keyColumn: "Id",
                keyValue: -4);

            migrationBuilder.DeleteData(
                table: "Vehicles",
                keyColumn: "Id",
                keyValue: -3);

            migrationBuilder.DeleteData(
                table: "Vehicles",
                keyColumn: "Id",
                keyValue: -2);

            migrationBuilder.DeleteData(
                table: "Vehicles",
                keyColumn: "Id",
                keyValue: -1);
        }
    }
}
