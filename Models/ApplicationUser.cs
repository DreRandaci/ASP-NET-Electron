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
        public string Password { get; set; }
        public virtual ICollection<Insurance> InsuranceAccounts { get; set; }
        public virtual ICollection<Mileage> MilageRecords { get; set; }
        public virtual ICollection<Paycheck> Paychecks { get; set; }
        public virtual ICollection<Other> OtherRecords { get; set; }
    }
}