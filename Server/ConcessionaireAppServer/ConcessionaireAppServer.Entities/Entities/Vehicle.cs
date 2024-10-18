using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace ConcessionaireAppServer.Entities.Entities
{
    public class Vehicle
    {
        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public int Id { get; set; }

        public int BrandId { get; set; }

        [StringLength(40)]
        public string Model { get; set; } = null!;

        public int Year { get; set; }

        public decimal Price { get; set; }

        [StringLength(40)]
        public string Color { get; set; } = null!;

        public int Mileage {  get; set; }

        public int VehicleTypeId { get; set; }

        public int TransmissionTypeId { get; set; }

        public int StatusId { get; set; }

        public DateTime DateAdded { get; set; }

        public virtual Sale? Sale { get; set; }

        public virtual Brand Brand { get; set; } = null!; 

        public virtual VehicleType VehicleType { get; set; } = null!;

        public virtual TransmisionType TransmissionType { get; set; } = null!;

        public virtual VehicleStatus VehicleStatus { get; set; } = null!;

    }
}
