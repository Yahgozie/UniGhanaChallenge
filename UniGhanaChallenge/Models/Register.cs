using System;
using System.ComponentModel;
using System.ComponentModel.DataAnnotations;
using System.Xml.Linq;

namespace UniGhanaChallenge.Models
{
	public class Register
	{
        [Required, EmailAddress, Display(Name = "Email Address")]
        public string Email { get; set; }

        [Required,
         StringLength(50, ErrorMessage = "The {0} must be at least {2} characters long.",
         MinimumLength = 6),
        DataType(DataType.Password)]
        public string Password { get; set; }

        [DataType(DataType.Password), Display(Name = "Confirm Password"), Compare("Password", ErrorMessage = "The password and confirm password do not match"), DisplayName("Confirm Password")]
        public string ConfirmPassword { get; set; }

        [Required]
        public string Name { get; set; }
    }
}

