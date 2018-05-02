using System.ComponentModel.DataAnnotations;

namespace number_cruncher.Models
{
    public class Paycheck
    {
        [Key]
        public int PaycheckId { get; set; }
        [Required]
        public double Amount { get; set; }
        [Required]
        public DataType Date { get; set; }
        public Client Client { get; set; }
    }
}