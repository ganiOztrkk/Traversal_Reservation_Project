using Microsoft.AspNetCore.Mvc;

namespace TraversalProject.Components.Default;

public class _SliderVC : ViewComponent
{
    public IViewComponentResult Invoke()
    {
        return View();
    }
}