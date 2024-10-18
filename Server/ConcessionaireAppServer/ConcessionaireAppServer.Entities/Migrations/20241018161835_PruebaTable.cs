using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace ConcessionaireAppServer.Entities.Migrations
{
    /// <inheritdoc />
    public partial class PruebaTable : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "Prueba",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1")
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Prueba", x => x.Id);
                });

            migrationBuilder.UpdateData(
                table: "Sales",
                keyColumn: "Id",
                keyValue: -2,
                column: "SaleDate",
                value: new DateTime(2024, 10, 18, 11, 18, 29, 995, DateTimeKind.Local).AddTicks(4570));

            migrationBuilder.UpdateData(
                table: "Sales",
                keyColumn: "Id",
                keyValue: -1,
                column: "SaleDate",
                value: new DateTime(2024, 10, 18, 11, 18, 29, 995, DateTimeKind.Local).AddTicks(4540));

            migrationBuilder.UpdateData(
                table: "Sellers",
                keyColumn: "Id",
                keyValue: 1,
                column: "JoinDate",
                value: new DateTime(2024, 10, 18, 11, 18, 29, 995, DateTimeKind.Local).AddTicks(4472));

            migrationBuilder.UpdateData(
                table: "Sellers",
                keyColumn: "Id",
                keyValue: 2,
                column: "JoinDate",
                value: new DateTime(2024, 10, 18, 11, 18, 29, 995, DateTimeKind.Local).AddTicks(4507));

            migrationBuilder.UpdateData(
                table: "Vehicles",
                keyColumn: "Id",
                keyValue: -8,
                column: "DateAdded",
                value: new DateTime(2024, 10, 18, 11, 18, 29, 995, DateTimeKind.Local).AddTicks(4429));

            migrationBuilder.UpdateData(
                table: "Vehicles",
                keyColumn: "Id",
                keyValue: -7,
                column: "DateAdded",
                value: new DateTime(2024, 10, 18, 11, 18, 29, 995, DateTimeKind.Local).AddTicks(4399));

            migrationBuilder.UpdateData(
                table: "Vehicles",
                keyColumn: "Id",
                keyValue: -6,
                column: "DateAdded",
                value: new DateTime(2024, 10, 18, 11, 18, 29, 995, DateTimeKind.Local).AddTicks(4369));

            migrationBuilder.UpdateData(
                table: "Vehicles",
                keyColumn: "Id",
                keyValue: -5,
                column: "DateAdded",
                value: new DateTime(2024, 10, 18, 11, 18, 29, 995, DateTimeKind.Local).AddTicks(4338));

            migrationBuilder.UpdateData(
                table: "Vehicles",
                keyColumn: "Id",
                keyValue: -4,
                column: "DateAdded",
                value: new DateTime(2024, 10, 18, 11, 18, 29, 995, DateTimeKind.Local).AddTicks(4304));

            migrationBuilder.UpdateData(
                table: "Vehicles",
                keyColumn: "Id",
                keyValue: -3,
                column: "DateAdded",
                value: new DateTime(2024, 10, 18, 11, 18, 29, 995, DateTimeKind.Local).AddTicks(4277));

            migrationBuilder.UpdateData(
                table: "Vehicles",
                keyColumn: "Id",
                keyValue: -2,
                column: "DateAdded",
                value: new DateTime(2024, 10, 18, 11, 18, 29, 995, DateTimeKind.Local).AddTicks(4247));

            migrationBuilder.UpdateData(
                table: "Vehicles",
                keyColumn: "Id",
                keyValue: -1,
                column: "DateAdded",
                value: new DateTime(2024, 10, 18, 11, 18, 29, 995, DateTimeKind.Local).AddTicks(4184));
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "Prueba");

            migrationBuilder.UpdateData(
                table: "Sales",
                keyColumn: "Id",
                keyValue: -2,
                column: "SaleDate",
                value: new DateTime(2024, 10, 17, 21, 24, 10, 753, DateTimeKind.Local).AddTicks(9024));

            migrationBuilder.UpdateData(
                table: "Sales",
                keyColumn: "Id",
                keyValue: -1,
                column: "SaleDate",
                value: new DateTime(2024, 10, 17, 21, 24, 10, 753, DateTimeKind.Local).AddTicks(9001));

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
    }
}
