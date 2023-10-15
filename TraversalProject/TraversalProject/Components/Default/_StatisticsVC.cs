using Microsoft.AspNetCore.Mvc;

namespace TraversalProject.Components.Default;

public class _StatisticsVC : ViewComponent
{
    public IViewComponentResult Invoke()
    {
        return View();
    }
}