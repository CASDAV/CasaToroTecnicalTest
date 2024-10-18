using ConcessionaireAppServer.BusinessLayer.Extensions;
using ConcessionaireAppServer.DataLayer;
using DTOs.Entities;
using ConcessionaireAppServer.Entities.Entities;

namespace ConcessionaireAppServer.BusinessLayer.Services
{
    public class SellerServices : ISellerServices
    {
        private readonly IDataServices _dataServices;

        public SellerServices(IDataServices dataServices)
        {
            _dataServices = dataServices;
        }

        public async Task<SellerResponse?> GetSellerById(int id)
        {
            return SellerExtensions.DbClassToDTO(await _dataServices.GetSellerById(id) ?? new Seller());
        }

        public async Task<List<SellerResponse>> GetSellers()
        {
            return SellerExtensions.ListDbClassToListDTO(await _dataServices.GetSellers());
        }

        public async Task<bool> UpdateSeller(SellerResponse seller)
        {
            if (seller == null)
            {
                throw new NullReferenceException("El vendedor no puede ser null");
            }

            if (seller.Name == null)
            {
                throw new ArgumentNullException("El nombre no puede ser null");
            }

            if (seller.Email == null)
            {
                throw new ArgumentException("El email no puede ser null");
            }

            if (seller.PhoneNumber == null)
            {
                throw new ArgumentException("El numero de telefono no puede ser null");
            }

            if (seller.Location == null)
            {
                throw new ArgumentException("La ubicacion no puede ser null");
            }

            return await _dataServices.UpdateSeller(SellerExtensions.DTOToDbClass(seller));
        }
    }
}
