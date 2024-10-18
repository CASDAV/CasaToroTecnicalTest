using ConcessionaireAppServer.Entities.Entities;
using DTOs.Entities;

namespace ConcessionaireAppServer.BusinessLayer.Services
{
    public interface ISellerServices
    {
        Task<List<SellerResponse>> GetSellers();

        Task<SellerResponse?> GetSellerById(int id);

        Task<bool> UpdateSeller(SellerResponse seller);
    }
}
