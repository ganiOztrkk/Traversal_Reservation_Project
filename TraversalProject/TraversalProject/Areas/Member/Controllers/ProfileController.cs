using EntityLayer.Concrete;
using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Mvc;
using TraversalProject.Areas.Member.Models;

namespace TraversalProject.Areas.Member.Controllers;

[Area("Member")]
[Route("Member/[controller]/[action]")]
public class ProfileController : Controller
{
    private readonly UserManager<AppUser> _userManager;
    private readonly ProfileEditVM _profileEdit;

    public ProfileController(UserManager<AppUser> userManager, ProfileEditVM profileEdit)
    {
        _userManager = userManager;
        _profileEdit = profileEdit;
    }

    [HttpGet]
    public async Task<IActionResult> Index()
    {
        var values = await _userManager.FindByNameAsync(User.Identity!.Name!);
        _profileEdit.Name = values!.Name;
        _profileEdit.Surname = values!.Surname;
        _profileEdit.Email = values!.Email;
        _profileEdit.Username = values!.UserName;
        _profileEdit.Gender = values!.Gender;
        _profileEdit.ImageUrl = values!.ImageUrl;
        _profileEdit.PhoneNumber = values!.PhoneNumber;
        return View(_profileEdit);
    }

    [HttpPost]
    public async Task<IActionResult> Index(ProfileEditVM profileEditVm)
    {
        var user = await _userManager.FindByNameAsync(User.Identity!.Name!);
        if (profileEditVm.Image != null)
        {
            var resource = Directory.GetCurrentDirectory();
            var extension = Path.GetExtension(profileEditVm.Image.FileName);
            var imageName = Guid.NewGuid() + extension;
            var saveLocation = resource + "/wwwroot/userimages/" + imageName;
            var stream = new FileStream(saveLocation, FileMode.Create);
            await profileEditVm.Image.CopyToAsync(stream);
            user!.ImageUrl = "/userimages/" + imageName;
        }

        user!.Name = profileEditVm.Name;
        user!.Surname = profileEditVm.Surname;
        user!.Email = profileEditVm.Email;
        user!.Gender = profileEditVm.Gender;
        user!.PhoneNumber = profileEditVm.PhoneNumber;
        user!.UserName = profileEditVm.Username;
        user!.PasswordHash = _userManager.PasswordHasher.HashPassword(user, profileEditVm.Password!);
        var result = await _userManager.UpdateAsync(user);
        if (result.Succeeded)
        {
            return RedirectToAction("SignIn", "Login");
        }
        return View();
    }
}