using System;
using System.ComponentModel.DataAnnotations;

namespace SpaDay.ViewModels
{
    public class AddUserViewModel
    {
        [Required]
        [StringLength(15, MinimumLength = 5, ErrorMessage = "Username must be between five and 15 characters.")]
        public string Username { get; set; }

        [Required]
        public string Password { get; set; }

        [EmailAddress]
        [StringLength(20, MinimumLength = 6, ErrorMessage = "Password must be between six and twenty characters.")]
        public string Email { get; set; }

        [Required]
        [Compare("Password", ErrorMessage = "Your password must match!")]
        public string VerifyPassword { get; set; }
    }
}
