using Azure.Core;
using BusinessLayer.Abstract;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore.Metadata.Internal;

namespace TraversalProject.Components.Default;

public class _PopularDestinationsVC : ViewComponent
{
    private readonly IDestinationService _destinationService;

    public _PopularDestinationsVC(IDestinationService destinationService)
    {
        _destinationService = destinationService;
    }

    public IViewComponentResult Invoke()
    {
        var destinations = _destinationService.GetList().Where(x => x.Status == true);
        return View(destinations);
    }
}