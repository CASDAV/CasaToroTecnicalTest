using ConcessionaireAppServer.Entities.Entities;
using DTOs.Entities;

namespace ConcessionaireAppServer.BusinessLayer.Extensions
{
    internal static class SaleExtensions
    {
        internal static SaleResponse DbclassToDTO(Sale sale)
        {
            return new SaleResponse()
            {
                Id = sale.Id,
                CustomerEmail = sale.CustomerEmail,
                CustomerName = sale.CustomerName,
                CustomerPhone = sale.CustomerPhone,
                SaleAmount = sale.SaleAmount,
                SaleDate = sale.SaleDate,
                SellerId = sale.SellerId,
                VehicleId = sale.VehicleId
            };
        }

        internal static Sale DTOToDbClass(SaleResponse sale)
        {
            return new Sale()
            {
                Id = sale.Id,
                CustomerEmail = sale.CustomerEmail,
                CustomerName = sale.CustomerName?? string.Empty,
                CustomerPhone = sale.CustomerPhone?? string.Empty,
                SaleAmount = sale.SaleAmount,
                SaleDate = sale.SaleDate,
                SellerId = sale.SellerId,
                VehicleId = sale.VehicleId
            };
        }

        internal static List<SaleResponse> DbListToDTOList(List<Sale> sales)
        {
            List<SaleResponse> saleResponses = new List<SaleResponse>();

            sales.ForEach(i => saleResponses.Add(DbclassToDTO(i)));

            return saleResponses;
        }
    }
}
