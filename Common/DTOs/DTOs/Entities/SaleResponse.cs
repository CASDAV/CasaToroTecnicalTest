using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace DTOs.Entities
{
    public class SaleResponse
    {
        [Key]
        public int Id { get; set; }

        [Required]
        public int VehicleId { get; set; }

        [Required]
        public int SellerId { get; set; }

        public DateTime SaleDate { get; set; }

        [Required]
        public decimal SaleAmount { get; set; }

        [Required]
        [StringLength(40)]
        public string? CustomerName { get; set; }

        [EmailAddress]
        public string? CustomerEmail { get; set; }

        [Required]
        [StringLength(10)]
        public string? CustomerPhone { get; set; }
    }
}
