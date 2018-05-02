using System.ComponentModel.DataAnnotations;

namespace number_cruncher.Models
{
    public class Insurance
    {
        [Key]
        public int InsuranceId { get; set; }
        [Required]
        public string Name { get; set; }
        public ExpenseCategory Type { get; set; }
        public int Amount { get; set; }
        public DataType Date { get; set; }
    }
}