using System.ComponentModel.DataAnnotations;

namespace Cashly.Shared;

public class UserRegister
{
    [Required]
    public string Username { get; set; } = string.Empty;
    [Required, StringLength(10, MinimumLength = 5)]
    public string Password { get; set; } = string.Empty;
    [Compare("Password", ErrorMessage = "The passwords do not match.")]
    public string ConfirmPassword { get; set; } = string.Empty;
}
