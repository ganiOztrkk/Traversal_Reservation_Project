using Microsoft.AspNetCore.Mvc;

namespace TraversalProject.Areas.Member.Controllers;

[Area("Member")]
public class ProfileController : Controller
{
    // GET
    public IActionResult Index()
    {
        return View();
    }
}