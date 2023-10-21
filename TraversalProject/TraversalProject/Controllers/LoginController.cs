using EntityLayer.Concrete;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Mvc;
using TraversalProject.Models;

namespace TraversalProject.Controllers;

[AllowAnonymous]
public class LoginController : Controller
{
    private readonly UserManager<AppUser> _userManager;
    private readonly AppUser _appUser;
    private readonly SignInManager<AppUser> _signInManager;

    public LoginController(UserManager<AppUser> userManager, AppUser appUser, SignInManager<AppUser> signInManager)
    {
        _userManager = userManager;
        _appUser = appUser;
        _signInManager = signInManager;
    }

    [HttpGet]
    public IActionResult SignUp()
    {
        return View();
    }

    [HttpPost]
    public async Task<IActionResult> SignUp(UserRegisterVM registerVm)
    {
        _appUser.Name = registerVm.Name;
        _appUser.Surname = registerVm.Surname;
        _appUser.Email = registerVm.Mail;
        _appUser.UserName = registerVm.Username;
        
        if (!ModelState.IsValid) return View();

        var result = await _userManager.CreateAsync(_appUser, registerVm.Password);
        if (result.Succeeded) 
            return RedirectToAction("SignIn");
        else
        {
            foreach (var item in result.Errors)
            {
                ModelState.AddModelError("", item.Description);
            }
            return View();
        }

    }

    [HttpGet]
    public IActionResult SignIn()
    {
        return View();
    }

    [HttpPost]
    public async Task<IActionResult> SignIn(UserLoginVM userLoginVm)
    {
        if (!ModelState.IsValid) return View();
        var result =
            await _signInManager.PasswordSignInAsync(userLoginVm.Username!, userLoginVm.Password!, false, false);
        return result.Succeeded ? RedirectToAction("Index", "Dashboard", new{area="Member"}) : RedirectToAction("SignIn");
    }
}