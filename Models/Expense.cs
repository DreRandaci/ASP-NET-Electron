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
        [Display(Name = "Category")]
        public ExpenseCategory ExpenseCategory { get; set; }

        [Required]
        [Display(Name = "Name")]
        public string ExpenseName { get; set; }

        [Display(Name = "Date Created")]
        public DateTime? DateCreated { get; set; }

        [Display(Name = "Details")]
        public string Details { get; set; }

        public double Total { get; set; }
    }
}