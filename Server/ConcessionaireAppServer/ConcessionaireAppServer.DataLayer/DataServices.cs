using ConcessionaireAppServer.DataLayer.Services;
using ConcessionaireAppServer.Entities.Entities;

namespace ConcessionaireAppServer.DataLayer
{
    public class DataServices : IDataServices
    {
        private readonly ISellerRepository _sellerRepository;
        private readonly ISaleRepository _saleRepository;
        private readonly IBrandRepository _brandRepository;

        public DataServices(ISellerRepository sellerRepository, ISaleRepository saleRepository, IBrandRepository brandRepository)
        {
            _sellerRepository = sellerRepository;
            _saleRepository = saleRepository;
            _brandRepository = brandRepository;
        }

        public async Task<bool> CreateNewBrand(Brand brand)
        {
            return await _brandRepository.CreateNewBrand(brand);
        }

        public async Task<bool> DeleteSale(int id)
        {
            return await _saleRepository.DeleteSale(id);
        }

        public async Task<List<Brand>> GetBrands()
        {
            return await _brandRepository.GetBrands();
        }

        public async Task<List<Sale>> GetSales()
        {
            return await _saleRepository.GetSales();
        }

        public async Task<List<Sale>> GetSalesBySellerId(int sellerId)
        {
            return await _saleRepository.GetSalesBySellerId(sellerId);
        }

        public async Task<Seller?> GetSellerById(int id)
        {
            return await _sellerRepository.GetSellerById(id);
        }

        public async Task<List<Seller>> GetSellers()
        {
            return await _sellerRepository.GetSellers();
        }

        public async Task<bool> UpdateSeller(Seller seller)
        {
            return await _sellerRepository.UpdateSeller(seller);
        }
    }
}
