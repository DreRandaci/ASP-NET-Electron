using System.ComponentModel.DataAnnotations;

namespace number_cruncher.Models
{
    public class ExpenseRecordImage
    {
        [Key]
        public int ExpenseRecordImageId { get; set; }

        [Required]
        public ExpenseRecord ExpenseRecord { get; set; }

        [Required]
        public string ImagePath { get; set; }
    }
}