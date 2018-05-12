using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;

namespace number_cruncher.Models
{
    public class Vehicle
    {
        [Key]
        public int VehicleId { get; set; }
        [Required]
        public ApplicationUser User { get; set; }
        [Required]
        public int CurrentMiles { get; set; }
        [Required]
        public string VehicleModel { get; set; }
        public string VehicleName { get; set; }
        [Required]
        public virtual ICollection<MileageRecord> MileageRecords { get; set; }
    }
}