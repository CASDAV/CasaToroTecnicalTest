using System.ComponentModel.DataAnnotations;

namespace ConcessionaireAppServer.Entities.Entities
{
    public class Seller
    {
        [Key]
        public int Id { get; set; }

        [StringLength(40)]
        public string Name { get; set; } = null!;

        [StringLength(50)]
        public string Email { get; set; } = null!;

        [StringLength(10)]
        public string PhoneNumber { get; set; } = null!;

        [StringLength(255)]
        public string? Location { get; set; }

        public DateTime JoinDate { get; set; }

        public virtual ICollection<Sale> Sales { get; set; } = new List<Sale>();
    }
}
