using System.ComponentModel.DataAnnotations;

namespace ConcessionaireAppServer.Entities.Entities
{
    public class ViewSaleDetail
    {
        public int SaleId { get; set; }

        public DateTime SaleDate { get; set; }

        public decimal SaleAmount { get; set; }

        [StringLength(40)]
        public string CustomerName { get; set; } = null!;

        [EmailAddress]
        public string? CustomerEmail { get; set; }

        [StringLength(10)]
        public string CustomerPhone { get; set; } = null!;

        [StringLength(40)]
        public string VehicleModel { get; set; } = null!;

        [StringLength(40)]
        public string BrandName { get; set; } = null!;

        [StringLength(40)]
        public string SellerName { get; set; } = null!;
    }
}
