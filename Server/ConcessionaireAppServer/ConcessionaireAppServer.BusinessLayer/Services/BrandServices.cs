using ConcessionaireAppServer.BusinessLayer.Extensions;
using ConcessionaireAppServer.DataLayer;
using DTOs.Entities;

namespace ConcessionaireAppServer.BusinessLayer.Services
{
    public class BrandServices : IBrandServices
    {
        private readonly IDataServices _dataServices;

        public BrandServices(IDataServices dataServices)
        {
            _dataServices = dataServices;
        }

        public async Task<bool> CreateNewBrand(BrandResponse brand)
        {
            if(brand == null)
            {
                throw new NullReferenceException("La marca no puede ser null");
            }

            if(brand.Name == null)
            {
                throw new ArgumentException("El nombre de la marca no puede ser null");
            }

            return await _dataServices.CreateNewBrand(BrandExtensions.DTOToDbClass(brand));
        }

        public async Task<List<BrandResponse>> GetBrands()
        {
            return BrandExtensions.DbListToDTOList(await _dataServices.GetBrands());
        }
    }
}
