using BusinessLayer.Abstract;
using Microsoft.AspNetCore.Mvc;

namespace TraversalProject.Components.Default;

public class _SubAboutVC : ViewComponent
{
    private readonly ISubAboutService _subAboutService;

    public _SubAboutVC(ISubAboutService subAboutService)
    {
        _subAboutService = subAboutService;
    }

    public IViewComponentResult Invoke()
    {
        var subAbout = _subAboutService.GetList().Where(x => x.Status == true);
        return View(subAbout);
    }
}