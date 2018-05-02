using System.ComponentModel.DataAnnotations;

namespace number_cruncher.Models
{
    public class Vehicle
    {
        [Key]
        public int VehicleId { get; set; }
        [Required]
        public int CurrentMiles { get; set; }
        public string Name { get; set; }
    }
}