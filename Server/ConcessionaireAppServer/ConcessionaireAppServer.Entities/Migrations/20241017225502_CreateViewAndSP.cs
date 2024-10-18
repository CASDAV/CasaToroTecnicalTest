using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace ConcessionaireAppServer.Entities.Migrations
{
    /// <inheritdoc />
    public partial class CreateViewAndSP : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            string CreateView = @"CREATE VIEW ViewSalesDetails AS
                SELECT 
                    s.Id AS SaleId,
                    s.SaleDate,
                    s.SaleAmount,
                    s.CustomerName,
                    s.CustomerEmail,
                    s.CustomerPhone,
                    v.Model AS VehicleModel,
                    b.Name AS BrandName,
                    sel.Name AS SellerName
                FROM 
                    dbo.Sales s
                INNER JOIN 
                    dbo.Vehicles v ON s.VehicleId = v.Id
                INNER JOIN 
                    dbo.Brands b ON v.BrandId = b.Id
                INNER JOIN 
                    dbo.Sellers sel ON s.SellerId = sel.Id;";
            migrationBuilder.Sql(CreateView);

            string CreateSP = @"CREATE PROCEDURE SP_GetSalesBySellerId
                    @SellerId INT
                AS
                BEGIN
                    SELECT 
                        Id, 
                        VehicleId, 
                        SellerId, 
                        SaleDate, 
                        SaleAmount, 
                        CustomerName, 
                        CustomerEmail, 
                        CustomerPhone
                    FROM 
                        dbo.Sales
                    WHERE 
                        SellerId = @SellerId;
                END;";
            migrationBuilder.Sql(CreateSP);
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            string DropView = @"DROP VIEW ViewSalesDetails";
            migrationBuilder.Sql(DropView);

            string DropSP = @"DRPO PROCEDURE SP_GetSalesBySellerId";
            migrationBuilder.Sql(DropSP);
        }
    }
}
