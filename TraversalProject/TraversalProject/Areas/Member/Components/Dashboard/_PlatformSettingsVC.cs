using Microsoft.AspNetCore.Mvc;

namespace TraversalProject.Areas.Member.Components.Dashboard;

public class _PlatformSettingsVC : ViewComponent
{
    public IViewComponentResult Invoke()
    {
        return View();
    }
}