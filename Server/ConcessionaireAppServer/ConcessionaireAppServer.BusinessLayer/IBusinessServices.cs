using ConcessionaireAppServer.Entities.Entities;
using DTOs.Entities;

namespace ConcessionaireAppServer.BusinessLayer
{
    public interface IBusinessServices
    {
        Task<List<BrandResponse>> GetBrands();

        Task<bool> CreateNewBrand(BrandResponse brand);

        Task<List<SaleResponse>> GetSales();

        Task<List<SaleResponse>> GetSalesBySellerId(int sellerId);

        Task<bool> DeleteSale(int id);

        Task<List<SellerResponse>> GetSellers();

        Task<SellerResponse?> GetSellerById(int id);

        Task<bool> UpdateSeller(SellerResponse seller);
    }
}
