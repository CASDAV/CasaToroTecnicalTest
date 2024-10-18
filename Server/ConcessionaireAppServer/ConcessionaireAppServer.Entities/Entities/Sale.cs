using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace ConcessionaireAppServer.Entities.Entities
{
    public class Sale
    {
        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public int Id { get; set; }

        [Required]
        public int VehicleId { get; set; }

        [Required]
        public int SellerId { get; set; }

        public DateTime SaleDate { get; set; }

        public decimal SaleAmount { get; set; }

        [StringLength(40)]
        public string CustomerName { get; set; } = null!;

        [EmailAddress]
        public string? CustomerEmail { get; set; }

        [StringLength(10)]
        public string CustomerPhone { get; set; } = null!;

        public virtual Vehicle Vehicle { get; set; } = null!;

        public virtual Seller Seller { get; set; } = null!;
    }
}
