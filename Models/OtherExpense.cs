using System;
using System.ComponentModel.DataAnnotations;

namespace number_cruncher.Models
{
    public class OtherExpense
    {
        [Key]
        public int OtherExpenseId { get; set; }
        [Required]
        public ApplicationUser User { get; set; }
        [Required]
        public ExpenseCategory ExpenseCategory { get; set; }
        [Required]
        public int Amount { get; set; }
        [Required]
        public DateTime ExpenseDate { get; set; }
    }
}