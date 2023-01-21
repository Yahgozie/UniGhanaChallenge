using System;
using System.ComponentModel.DataAnnotations;
using Microsoft.AspNetCore.Identity;

namespace UniGhanaChallenge.Models
{
	public class ApplicationUser : IdentityUser
	{
        [Required]
        public string Name { get; set; }
    }
}

