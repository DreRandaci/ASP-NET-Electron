using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace number_cruncher.Models.ExpenseViewModels
{
  public class CreateExpenseViewModel
  {
      [Required]
      public string ExpenseType { get; set; }
      [Required]
      public string ExpenseName { get; set; }

      [Required]
      public DateTime DateCreated { get; set; }

      public string Details { get; set; }
  }
}