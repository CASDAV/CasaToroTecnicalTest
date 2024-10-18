using ConcessionaireAppServer.Entities.Entities;
using DTOs.Entities;

namespace ConcessionaireAppServer.BusinessLayer.Services
{
    public interface ISaleServices
    {
        Task<List<SaleResponse>> GetSales();

        Task<List<SaleResponse>> GetSalesBySellerId(int sellerId);

        Task<bool> DeleteSale(int id);
    }
}
