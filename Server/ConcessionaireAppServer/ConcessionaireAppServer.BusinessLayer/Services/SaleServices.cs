using ConcessionaireAppServer.BusinessLayer.Extensions;
using ConcessionaireAppServer.DataLayer;
using DTOs.Entities;

namespace ConcessionaireAppServer.BusinessLayer.Services
{
    public class SaleServices : ISaleServices
    {
        private readonly IDataServices _dataServices;

        public SaleServices(IDataServices dataServices)
        {
            _dataServices = dataServices;
        }

        public Task<bool> DeleteSale(int id)
        {
            return _dataServices.DeleteSale(id);
        }

        public async Task<List<SaleResponse>> GetSales()
        {
            return SaleExtensions.DbListToDTOList(await _dataServices.GetSales());
        }

        public async Task<List<SaleResponse>> GetSalesBySellerId(int sellerId)
        {
            return SaleExtensions.DbListToDTOList(await _dataServices.GetSalesBySellerId(sellerId));
        }
    }
}
