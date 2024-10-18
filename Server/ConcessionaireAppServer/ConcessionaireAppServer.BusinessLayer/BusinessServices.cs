using ConcessionaireAppServer.BusinessLayer.Services;
using ConcessionaireAppServer.Entities.Entities;
using DTOs.Entities;

namespace ConcessionaireAppServer.BusinessLayer
{
    public class BusinessServices : IBusinessServices
    {

        private readonly IBrandServices _brandService;
        private readonly ISaleServices _saleService;
        private readonly ISellerServices _sellerService;

        public BusinessServices(IBrandServices brandService, ISaleServices saleService, ISellerServices sellerService)
        {
            _brandService = brandService;
            _saleService = saleService;
            _sellerService = sellerService;
        }

        public async Task<bool> CreateNewBrand(BrandResponse brand)
        {
            return await _brandService.CreateNewBrand(brand);
        }

        public async Task<bool> DeleteSale(int id)
        {
            return await _saleService.DeleteSale(id);
        }

        public async Task<List<BrandResponse>> GetBrands()
        {
            return await _brandService.GetBrands();
        }

        public async Task<List<SaleResponse>> GetSales()
        {
            return await _saleService.GetSales();
        }

        public async Task<List<SaleResponse>> GetSalesBySellerId(int sellerId)
        {
            return await _saleService.GetSalesBySellerId(sellerId);
        }

        public async Task<SellerResponse?> GetSellerById(int id)
        {
            return await _sellerService.GetSellerById(id);
        }

        public async Task<List<SellerResponse>> GetSellers()
        {
            return await _sellerService.GetSellers();
        }

        public async Task<bool> UpdateSeller(SellerResponse seller)
        {
            return await _sellerService.UpdateSeller(seller);
        }
    }
}
