using System;
using System.ComponentModel.DataAnnotations;

namespace number_cruncher.Models
{
    public class Paycheck
    {
        [Key]
        public int PaycheckId { get; set; }

        [Required]
        public Client Client { get; set; }

        [Required]
        public double Amount { get; set; }

        [Required]
        public DateTime DateReceived { get; set; }

        public DateTime? DateDeposited { get; set; }
    }
}