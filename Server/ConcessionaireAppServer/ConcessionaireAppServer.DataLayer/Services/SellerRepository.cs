using ConcessionaireAppServer.Entities;
using ConcessionaireAppServer.Entities.Entities;
using Microsoft.EntityFrameworkCore;

namespace ConcessionaireAppServer.DataLayer.Services
{
    public class SellerRepository : ISellerRepository
    {
        private readonly CasaToroTestDbContext _dbContext;

        public SellerRepository(CasaToroTestDbContext dbContext)
        {
            _dbContext = dbContext;
        }

        public async Task<Seller?> GetSellerById(int id)
        {
            return await _dbContext.Sellers.FirstOrDefaultAsync(element => element.Id == id);
        }

        public async Task<List<Seller>> GetSellers()
        {
            return await _dbContext.Sellers.ToListAsync();
        }

        public async Task<bool> UpdateSeller(Seller seller)
        {
            _dbContext.Sellers.Update(seller);

            var queryRes = await _dbContext.SaveChangesAsync();

            return queryRes > 0;
        }
    }
}
