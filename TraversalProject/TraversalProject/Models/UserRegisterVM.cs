using System.ComponentModel.DataAnnotations;

namespace TraversalProject.Models;

public class UserRegisterVM
{
    [Required] public string Name { get; set; }
    [Required] public string Surname { get; set; }
    [Required] public string Username { get; set; }
    [Required] public string Mail { get; set; }
    [Required] public string Password { get; set; }
    [Required][Compare("Password")] public string ConfirmPassword { get; set; }
}