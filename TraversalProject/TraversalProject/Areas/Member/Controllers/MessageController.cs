using Microsoft.AspNetCore.Mvc;

namespace TraversalProject.Areas.Member.Controllers;

[Area("Member")]
[Route("Member/[controller]/[action]")]
public class MessageController : Controller
{
    // GET
    public IActionResult Index()
    {
        return View();
    }
}