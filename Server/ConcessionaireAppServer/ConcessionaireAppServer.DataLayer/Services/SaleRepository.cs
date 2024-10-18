using ConcessionaireAppServer.Entities;
using ConcessionaireAppServer.Entities.Entities;
using Microsoft.Data.SqlClient;
using Microsoft.EntityFrameworkCore;

namespace ConcessionaireAppServer.DataLayer.Services
{
    public class SaleRepository : ISaleRepository
    {
        private readonly CasaToroTestDbContext _dbContext;

        public SaleRepository(CasaToroTestDbContext dbContext)
        {
            _dbContext = dbContext;
        }

        public async Task<bool> DeleteSale(int id)
        {
            var item = await _dbContext.Sales.FirstOrDefaultAsync(element => element.Id == id);

            if (item == null)
            {
                throw new Exception("Element to delete not found");
            }

            _dbContext.Sales.Remove(item);

            var queryRes = await _dbContext.SaveChangesAsync();

            return queryRes > 0;
        }

        public async Task<List<Sale>> GetSalesBySellerId(int sellerId)
        {
            SqlParameter[] parameter = new SqlParameter[]
            {
                new SqlParameter("@SellerId", sellerId)
            };

            return await _dbContext.Sales.FromSqlRaw("EXEC [dbo].[SP_GetSalesBySellerId] @SellerId", parameter).ToListAsync();
        }

        public async Task<List<Sale>> GetSales()
        {
            return await _dbContext.Sales.ToListAsync();
        }
    }
}
