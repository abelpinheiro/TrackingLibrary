using System.ComponentModel.DataAnnotations;

namespace TL.Identity.API.Models;

public class UserDTO
{
    [Required(ErrorMessage = "Field {0} is required")]
    [EmailAddress(ErrorMessage = "Field {0} is in an invalid format")]
    public string Email { get; set; }

    [Required(ErrorMessage = "Field {0} is required")]
    [StringLength(100, ErrorMessage = "Field {0} must be between {2} and {1} characters", MinimumLength = 8)]
    public string Password { get; set; }

    [Compare("Password", ErrorMessage = "Passwords don't match")]
    public string PasswordConfirmation { get; set; }
}