using System.ComponentModel.DataAnnotations;

namespace number_cruncher.Models
{
    public class OtherExpense
    {
        [Key]
        public int OtherExpenseId { get; set; }
        public ExpenseCategory ExpenseCategory { get; set; }
        public int Amount { get; set; }
        public DataType Date { get; set; }
    }
}