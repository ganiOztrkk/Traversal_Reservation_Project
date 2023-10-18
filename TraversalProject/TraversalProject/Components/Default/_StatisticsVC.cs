using DataAccessLayer.Concrete;
using Microsoft.AspNetCore.Mvc;

namespace TraversalProject.Components.Default;

public class _StatisticsVC : ViewComponent
{
    public IViewComponentResult Invoke()
    {
        using var context = new Context();
        ViewBag.DestinationCount = context.Destinations!.Count();
        ViewBag.GuideCount = context.Guides!.Count();
        return View();
    }
}