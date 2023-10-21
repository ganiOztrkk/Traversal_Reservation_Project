using BusinessLayer.Abstract;
using EntityLayer.Concrete;
using Microsoft.AspNetCore.Mvc;

namespace TraversalProject.Areas.Admin.Controllers;

[Area("Admin")]
[Route("Admin/[controller]/[action]")]
public class DestinationController : Controller
{
    private readonly IDestinationService _destinationService;

    public DestinationController(IDestinationService destinationService)
    {
        _destinationService = destinationService;
    }

    public IActionResult Index()
    {
        var destinations = _destinationService.GetList();
        return View(destinations);
    }

    [HttpGet]
    public IActionResult AddDestination()
    {
        return View();
    }

    [HttpPost]
    public IActionResult AddDestination(Destination destination)
    {
        destination.Status = true;
        _destinationService.Insert(destination);
        return RedirectToAction("Index");
    }

    public IActionResult DeleteDestination(int id)
    {
        var destination = _destinationService.GetById(id);
        _destinationService.Delete(destination!);
        return RedirectToAction("Index");
    }

    [HttpGet]
    public IActionResult UpdateDestination(int id)
    {
        var destination = _destinationService.GetById(id);
        return View(destination);
    }

    [HttpPost]
    public IActionResult UpdateDestination(Destination destination)
    {
        _destinationService.Update(destination);
        return RedirectToAction("Index");
    }
}