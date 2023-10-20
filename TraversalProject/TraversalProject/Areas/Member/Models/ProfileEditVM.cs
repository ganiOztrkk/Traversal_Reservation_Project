using Microsoft.Build.Framework;

namespace TraversalProject.Areas.Member.Models;

public class ProfileEditVM
{
    [Required] public string? Name { get; set; }
    [Required] public string? Surname { get; set; }
    [Required] public string? Email { get; set; }
    [Required]  public string? Username { get; set; }
    [Required]  public string? Password { get; set; }
    [Required]  public string? ConfirmPassword { get; set; }
    public string? Gender { get; set; }
    public string? PhoneNumber { get; set; }
    public string? ImageUrl { get; set; }
    public IFormFile? Image { get; set; }
}
