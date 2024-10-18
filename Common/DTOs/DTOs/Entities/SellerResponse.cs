using System.ComponentModel.DataAnnotations;

namespace DTOs.Entities
{
    public class SellerResponse
    {
        [Key]
        [Required]
        public int Id { get; set; }

        [Required]
        [StringLength(40)]
        public string? Name { get; set; }

        [Required]
        [StringLength(50)]
        public string? Email { get; set; }

        [Required]
        [StringLength(10)]
        public string? PhoneNumber { get; set; }

        [Required]
        [StringLength(255)]
        public string? Location { get; set; }

        public DateTime JoinDate { get; set; }
    }
}
