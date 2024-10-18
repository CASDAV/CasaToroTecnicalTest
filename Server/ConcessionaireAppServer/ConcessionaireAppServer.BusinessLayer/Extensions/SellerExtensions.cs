using ConcessionaireAppServer.Entities.Entities;
using DTOs.Entities;

namespace ConcessionaireAppServer.BusinessLayer.Extensions
{
    internal static class SellerExtensions
    {
        internal static SellerResponse DbClassToDTO(Seller seller)
        {
            return new SellerResponse()
            {
                Id = seller.Id,
                Name = seller.Name,
                Email = seller.Email,
                JoinDate = seller.JoinDate,
                Location = seller.Location,
                PhoneNumber = seller.PhoneNumber
            };
        }

        internal static Seller DTOToDbClass(SellerResponse seller)
        {
            return new Seller()
            {
                Id = seller.Id,
                Name = seller.Name?? string.Empty,
                Email = seller.Email?? string.Empty,
                JoinDate = seller.JoinDate,
                Location = seller.Location,
                PhoneNumber = seller.PhoneNumber?? string.Empty
            };
        }

        internal static List<SellerResponse> ListDbClassToListDTO(List<Seller> sellers)
        {
            List<SellerResponse> sellerResponses = new List<SellerResponse>();

            sellers.ForEach(seller => sellerResponses.Add(DbClassToDTO(seller)));

            return sellerResponses;
        }
    }
}
