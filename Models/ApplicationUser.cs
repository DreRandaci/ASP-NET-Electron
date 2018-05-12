using System;
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
        public DateTime DateCreated { get; set; }

        public virtual ICollection<Client> Clients { get; set; }

        public virtual ICollection<Expense> Expenses { get; set; }
    }
}