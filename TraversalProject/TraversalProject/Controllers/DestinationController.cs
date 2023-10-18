using BusinessLayer.Abstract;
using EntityLayer.Concrete;
using Microsoft.AspNetCore.Mvc;

namespace TraversalProject.Controllers;

public class DestinationController : Controller
{
    private readonly IDestinationService _destinationService;

    public DestinationController(IDestinationService destinationService)
    {
        _destinationService = destinationService;
    }

    public IActionResult Index()
    {
        var destinations = _destinationService.GetList().Where(x => x.Status == true);
        return View(destinations);
    }

    [HttpGet]
    public IActionResult DestinationDetails(int id)
    {
        ViewBag.Id = id;
        var values = _destinationService.GetById(id);
        return View(values);
    }
    
    [HttpPost]
    public IActionResult DestinationDetails(Destination destination)
    {
        return View();
    }
}