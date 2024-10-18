using ConcessionaireAppServer.Entities;
using ConcessionaireAppServer.Entities.Entities;
using Microsoft.EntityFrameworkCore;

namespace ConcessionaireAppServer.DataLayer.Services
{
    public class BrandRepository : IBrandRepository
    {
        private readonly CasaToroTestDbContext _dbContext;

        public BrandRepository(CasaToroTestDbContext dbContext)
        {
            _dbContext = dbContext;
        }

        public async Task<bool> CreateNewBrand(Brand brand)
        {
            _dbContext.Brands.Add(brand);

            var queryRes =  await _dbContext.SaveChangesAsync();

            return queryRes > 0;
        }

        public async Task<List<Brand>> GetBrands()
        {
            return await _dbContext.Brands.ToListAsync();
        }
    }
}
