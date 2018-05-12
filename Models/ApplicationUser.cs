using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using Microsoft.AspNetCore.Identity;

namespace number_cruncher.Models
{
    public class ApplicationUser : IdentityUser
    {
        [Required]
        [Display(Name = "First Name")]
        public string FirstName { get; set; }

        [Required]
        [Display(Name = "Last Name")]
        public string LastName { get; set; }

        [Required]
        [DateTime]
        public DateTime DateCreated
        {
            get => this.dateCreated.HasValue
                    ? this.dateCreated.Value
                    : DateTime.Now;

            set => this.dateCreated = value;
        }

        private DateTime? dateCreated = null;

        public virtual ICollection<Client> Clients { get; set; }

        public virtual ICollection<Expense> Expenses { get; set; }
    }
}