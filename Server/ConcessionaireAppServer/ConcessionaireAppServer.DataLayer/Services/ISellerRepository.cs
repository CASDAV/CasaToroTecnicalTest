using ConcessionaireAppServer.Entities.Entities;

namespace ConcessionaireAppServer.DataLayer.Services
{
    public interface ISellerRepository
    {
        Task<List<Seller>> GetSellers();

        Task<Seller?> GetSellerById(int id);

        Task<bool> UpdateSeller (Seller seller);

    }
}
