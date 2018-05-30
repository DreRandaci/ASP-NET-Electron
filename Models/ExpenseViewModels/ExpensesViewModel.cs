using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace number_cruncher.Models.ExpenseViewModels
{
  public class ExpensesViewModel
  {
      [Required]
      public ApplicationUser User { get; set; }

      [Required]
      public virtual ICollection<Expense> Expenses { get; set; }
  }
}