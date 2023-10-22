using Microsoft.AspNetCore.Mvc;

namespace TraversalProject.Areas.Admin.Controllers;

[Area("Admin")]
[Route("Admin/[controller]/[action]")]
public class DashboardController : Controller
{
    
    public IActionResult Index()
    {
        return View();
    }
}