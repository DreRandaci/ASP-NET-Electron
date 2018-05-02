using System.ComponentModel.DataAnnotations;

namespace number_cruncher.Models
{
    public class MileageRecord
    {
        [Key]
        public int MileageRecordId { get; set; }
        [Required]
        public Vehicle Vehicle { get; set; }
        public int TripMiles { get; set; }
        public DataType Date { get; set; }
    }
}