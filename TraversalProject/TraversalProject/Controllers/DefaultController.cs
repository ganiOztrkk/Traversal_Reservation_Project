using Microsoft.AspNetCore.Mvc;

namespace TraversalProject.Controllers;

public class DefaultController : Controller
{
    // GET
    public IActionResult Index()
    {
        return View();
    }
}