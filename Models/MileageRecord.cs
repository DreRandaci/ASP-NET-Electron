using System;
using System.ComponentModel.DataAnnotations;

namespace number_cruncher.Models
{
    public class MileageRecord
    {
        [Key]
        public int MileageRecordId { get; set; }
        [Required]
        public ApplicationUser User { get; set; }
        [Required]
        public Vehicle Vehicle { get; set; }
        [Required]
        public ExpenseCategory ExpenseCategory { get; set; }
        public int TripMiles { get; set; }
        public DateTime TripDate { get; set; }
    }
}