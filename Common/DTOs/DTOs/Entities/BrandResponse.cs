using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace DTOs.Entities
{
    public class BrandResponse
    {
        [Key]
        public int Id { get; set; }

        [Required]
        [StringLength(40)]
        public string? Name { get; set; }

    }
}
