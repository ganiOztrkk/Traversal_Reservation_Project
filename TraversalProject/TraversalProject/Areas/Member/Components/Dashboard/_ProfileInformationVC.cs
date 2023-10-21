using EntityLayer.Concrete;
using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Mvc;

namespace TraversalProject.Areas.Member.Components.Dashboard;

public class _ProfileInformationVC : ViewComponent
{
    private readonly UserManager<AppUser> _userManager;

    public _ProfileInformationVC(UserManager<AppUser> userManager)
    {
        _userManager = userManager;
    }

    public async Task<IViewComponentResult> InvokeAsync()
    {
        var user = await _userManager.FindByNameAsync(User.Identity!.Name!);
        ViewBag.UserName = user!.Name + " " + user.Surname;
        ViewBag.Phone = user.PhoneNumber!;
        ViewBag.Email = user.Email!;
        return View();
    }
    
}