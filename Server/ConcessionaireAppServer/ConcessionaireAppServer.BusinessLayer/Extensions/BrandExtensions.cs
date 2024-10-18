using ConcessionaireAppServer.Entities.Entities;
using DTOs.Entities;

namespace ConcessionaireAppServer.BusinessLayer.Extensions
{
    internal static class BrandExtensions
    {
        internal static BrandResponse DbClassToDTO(Brand brand)
        {
            return new BrandResponse()
            {
                Id = brand.Id,
                Name = brand.Name,
            };
        }

        internal static Brand DTOToDbClass(BrandResponse brandResponse)
        {
            return new Brand()
            {
                Id = brandResponse.Id,
                Name = brandResponse.Name ?? string.Empty
            };
        }

        internal static List<BrandResponse> DbListToDTOList(List<Brand> brands)
        {
            List<BrandResponse> brandResponses = new List<BrandResponse>();

            brands.ForEach(b => brandResponses.Add(DbClassToDTO(b)));

            return brandResponses;
        }
    }
}
