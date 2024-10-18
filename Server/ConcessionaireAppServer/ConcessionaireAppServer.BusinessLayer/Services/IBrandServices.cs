using ConcessionaireAppServer.Entities.Entities;
using DTOs.Entities;

namespace ConcessionaireAppServer.BusinessLayer.Services
{
    public interface IBrandServices
    {
        Task<List<BrandResponse>> GetBrands();

        Task<bool> CreateNewBrand(BrandResponse brand);
    }
}
