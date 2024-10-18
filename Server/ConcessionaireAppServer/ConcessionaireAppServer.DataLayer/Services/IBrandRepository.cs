using ConcessionaireAppServer.Entities.Entities;

namespace ConcessionaireAppServer.DataLayer.Services
{
    public interface IBrandRepository
    {
        Task<List<Brand>> GetBrands();

        Task<bool> CreateNewBrand (Brand brand);
    }
}
