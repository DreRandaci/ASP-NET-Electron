using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;

namespace number_cruncher.Models
{
    public class Client
    {
        [Key]
        public int ClientId { get; set; }

        [Required]
        public ApplicationUser User { get; set; }

        [Required]
        public ClientCategory ClientCategory { get; set; }

        [Required]
        public string ClientName { get; set; }

        public virtual ICollection<Paycheck> Paychecks { get; set; }
    }
}