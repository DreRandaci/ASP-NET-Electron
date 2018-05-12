using System.ComponentModel.DataAnnotations;

namespace number_cruncher.Models
{
  public class ClientCategory
  {
      [Key]
      public int ClientCategoryId { get; set; }

      [Required]
      public string ClientType { get; set; }
  }
}