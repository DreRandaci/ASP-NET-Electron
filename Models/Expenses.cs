using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;

namespace number_cruncher.Models
{
    public class Expenses
    {
      [Key]
      public int ExpensesId { get; set; }
      public ApplicationUser User { get; set; }
      public virtual ICollection<MileageRecord> Mileage { get; set; }
      public virtual ICollection<Client> Clients { get; set; }
    }
}