using System;
using System.ComponentModel.DataAnnotations;

namespace number_cruncher.Models
{
    public class ExpenseRecord
    {
        [Key]
        public int ExpenseRecordId { get; set; }

        [Required]
        public Expense Expense { get; set; }

        [Required]
        [Display(Name = "Name")]
        public string RecordName { get; set; }

        [Required]
        [Display(Name = "Amount")]
        public double Amount { get; set; }

        [Required]
        [Display(Name = "Expense Date")]
        public DateTime ExpenseDate { get; set; }

        [Required]
        [Display(Name = "Has a picture")]
        public bool RecordImage { get; set; } = false;

        [Display(Name = "Details")]
        public string Details { get; set; }
    }
}