using ConcessionaireAppServer.Entities.Entities;

namespace ConcessionaireAppServer.DataLayer
{
    public interface IDataServices
    {
        Task<List<Brand>> GetBrands();

        Task<bool> CreateNewBrand(Brand brand);

        Task<List<Seller>> GetSellers();

        Task<Seller?> GetSellerById(int id);

        Task<bool> UpdateSeller(Seller seller);

        Task<List<Sale>> GetSales();

        Task<List<Sale>> GetSalesBySellerId(int sellerId);

        Task<bool> DeleteSale(int id);
    }
}
