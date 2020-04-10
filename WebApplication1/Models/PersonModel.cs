using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace WebApplication1.Models
{
    public class PersonModel
    {
        [Display(Name = "First Name")]
        [Required(ErrorMessage ="Please enter first name")]
        public string FirstName { get; set; }


        [Display(Name = "Last Name")]
        [Required(ErrorMessage = "Please enter Last name")]
        public string LastName { get; set; }

        [Display(Name = "Emplyee ID")]
        [Range(100000, 999999, ErrorMessage = "Enter Employee ID")]
        public int EmployeeID { get; set; }


        [DataType(DataType.EmailAddress)]
        [Display(Name = "Email Address")]
        [Required(ErrorMessage = "Please enter a valid email")]
        public string EmailAddress { get; set; }

        [Display(Name ="Confirm Email")]
        [Compare("EmailAddress", ErrorMessage ="Emails must match")]
        public string ConfirmEmail { get; set; }

        [Display(Name ="Password")]
        [Required(ErrorMessage ="Please enter a password")]
        [DataType(DataType.Password)]
        [StringLength(100, MinimumLength = 10, ErrorMessage ="Please provide stronger password")]
        public string Password { get; set; }

        [Display(Name = "Confirm Password")]
        [DataType(DataType.Password)]
        [Compare("Password", ErrorMessage ="Passwords do not match")]
        public string ConfirmPassword { get; set; }

    }
}
