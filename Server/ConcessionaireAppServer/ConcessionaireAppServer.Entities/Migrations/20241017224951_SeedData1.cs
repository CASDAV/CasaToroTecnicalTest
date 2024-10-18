using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

#pragma warning disable CA1814 // Prefer jagged arrays over multidimensional

namespace ConcessionaireAppServer.Entities.Migrations
{
    /// <inheritdoc />
    public partial class SeedData1 : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.InsertData(
                table: "Brands",
                columns: new[] { "Id", "Name" },
                values: new object[,]
                {
                    { -7, "Renault" },
                    { -6, "Ford" },
                    { -5, "Toyota" },
                    { -4, "Audi" },
                    { -3, "Volkswagen" },
                    { -2, "Mercedes" },
                    { -1, "Mazda" }
                });

            migrationBuilder.InsertData(
                table: "TransmisionType",
                columns: new[] { "Id", "Name" },
                values: new object[,]
                {
                    { -2, "Automatic" },
                    { -1, "Manual" }
                });

            migrationBuilder.InsertData(
                table: "VehicleStatus",
                columns: new[] { "Id", "Status" },
                values: new object[,]
                {
                    { -2, "Sold" },
                    { -1, "Available" }
                });

            migrationBuilder.InsertData(
                table: "VehicleTypes",
                columns: new[] { "Id", "Name" },
                values: new object[,]
                {
                    { -5, "Hatchback" },
                    { -4, "Coupe" },
                    { -3, "Sedan" },
                    { -2, "Pickup" },
                    { -1, "SUV" }
                });
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "Brands",
                keyColumn: "Id",
                keyValue: -7);

            migrationBuilder.DeleteData(
                table: "Brands",
                keyColumn: "Id",
                keyValue: -6);

            migrationBuilder.DeleteData(
                table: "Brands",
                keyColumn: "Id",
                keyValue: -5);

            migrationBuilder.DeleteData(
                table: "Brands",
                keyColumn: "Id",
                keyValue: -4);

            migrationBuilder.DeleteData(
                table: "Brands",
                keyColumn: "Id",
                keyValue: -3);

            migrationBuilder.DeleteData(
                table: "Brands",
                keyColumn: "Id",
                keyValue: -2);

            migrationBuilder.DeleteData(
                table: "Brands",
                keyColumn: "Id",
                keyValue: -1);

            migrationBuilder.DeleteData(
                table: "TransmisionType",
                keyColumn: "Id",
                keyValue: -2);

            migrationBuilder.DeleteData(
                table: "TransmisionType",
                keyColumn: "Id",
                keyValue: -1);

            migrationBuilder.DeleteData(
                table: "VehicleStatus",
                keyColumn: "Id",
                keyValue: -2);

            migrationBuilder.DeleteData(
                table: "VehicleStatus",
                keyColumn: "Id",
                keyValue: -1);

            migrationBuilder.DeleteData(
                table: "VehicleTypes",
                keyColumn: "Id",
                keyValue: -5);

            migrationBuilder.DeleteData(
                table: "VehicleTypes",
                keyColumn: "Id",
                keyValue: -4);

            migrationBuilder.DeleteData(
                table: "VehicleTypes",
                keyColumn: "Id",
                keyValue: -3);

            migrationBuilder.DeleteData(
                table: "VehicleTypes",
                keyColumn: "Id",
                keyValue: -2);

            migrationBuilder.DeleteData(
                table: "VehicleTypes",
                keyColumn: "Id",
                keyValue: -1);
        }
    }
}
