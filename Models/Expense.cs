using System;
using System.ComponentModel.DataAnnotations;

namespace number_cruncher.Models
{
    public class Expense
    {
        [Key]
        public int ExpenseId { get; set; }

        [Required]
        public ApplicationUser User { get; set; }

        [Required]
        public ExpenseCategory ExpenseCategory { get; set; }

        [Required]
        public string ExpenseName { get; set; }

        public DateTime? DateCreated { get; set; }

        public string Details { get; set; }
    }
}