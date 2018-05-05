using System;
using System.ComponentModel.DataAnnotations;

namespace number_cruncher.Models
{
    public class InsuranceRecord
    {
        [Key]
        public int InsuranceId { get; set; }
        [Required]
        public ApplicationUser User { get; set; }
        [Required]
        public ExpenseCategory Type { get; set; }
        [Required]
        public string Name { get; set; }
        [Required]
        public int Amount { get; set; }
        [Required]
        public DateTime Date { get; set; }
    }
}