using Microsoft.Build.Framework;

namespace TraversalProject.Models;

public class UserLoginVM
{
    [Required]
    public string? Username { get; set; }
    [Required]
    public string? Password { get; set; }
}