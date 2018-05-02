using System.ComponentModel.DataAnnotations;

namespace number_cruncher.Models
{
    public class ExpenseCategory
    {
        [Key]
        public int ExpenseCategoryId { get; set; }
        [Required]
        public string Type { get; set; }
    }
}