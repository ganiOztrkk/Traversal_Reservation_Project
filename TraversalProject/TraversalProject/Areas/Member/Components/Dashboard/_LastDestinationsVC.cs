using BusinessLayer.Abstract;
using Microsoft.AspNetCore.Mvc;

namespace TraversalProject.Areas.Member.Components.Dashboard;

public class _LastDestinationsVC : ViewComponent
{
    private readonly IDestinationService _destinationService;

    public _LastDestinationsVC(IDestinationService destinationService)
    {
        _destinationService = destinationService;
    }

    public IViewComponentResult Invoke()
    {
        var values = _destinationService.GetLast4Destinations();
        return View(values);
    }
}