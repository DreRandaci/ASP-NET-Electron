using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace number_cruncher.Models.ExpenseViewModels
{
  public class ExpenseRecordsViewModel
  {
      [Required]
      public ApplicationUser User { get; set; }

      [Required]
      public Expense Expense { get; set; }

      [Required]
      public virtual ICollection<ExpenseRecord> ExpenseRecords { get; set; }
  }
}