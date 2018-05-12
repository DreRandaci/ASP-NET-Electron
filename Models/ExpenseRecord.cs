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
        public string RecordName { get; set; }

        [Required]
        public double Amount { get; set; }

        [Required]
        public DateTime ExpenseDate { get; set; }

        [Required]
        public bool RecordImage { get; set; }

        public string Details { get; set; }
    }
}