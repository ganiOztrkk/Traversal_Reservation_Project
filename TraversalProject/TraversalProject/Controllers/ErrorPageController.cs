using Microsoft.AspNetCore.Mvc;

namespace TraversalProject.Controllers;

public class ErrorPageController : Controller
{
    // GET
    public IActionResult Error404(int errorCode)
    {
        return View();
    }
}