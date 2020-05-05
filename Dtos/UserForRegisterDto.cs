using System.ComponentModel.DataAnnotations;

namespace DatingApp.API.Dtos
{
  public class UserForRegisterDto
  {
    [Required]
    [StringLength(
      20, MinimumLength = 6,
      ErrorMessage = "Username must be between 6 and 20 characters long"
    )]
    public string Username { get; set; }

    [Required]
    [StringLength(
      20, MinimumLength = 8,
      ErrorMessage = "Password must be between 8 and 20 characters long"
    )]
    public string Password { get; set; }
  }
}