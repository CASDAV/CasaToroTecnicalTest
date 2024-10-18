using ConcessionaireAppServer.Entities.Entities;

namespace ConcessionaireAppServer.DataLayer.Services
{
    public interface ISaleRepository
    {
        Task<List<Sale>> GetSales();

        Task<List<Sale>> GetSalesBySellerId(int sellerId);

        Task<bool> DeleteSale(int id);
    }
}
