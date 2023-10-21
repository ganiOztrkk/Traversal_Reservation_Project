using BusinessLayer.Abstract;
using Microsoft.AspNetCore.Mvc;

namespace TraversalProject.Areas.Member.Components.Dashboard;

public class _GuideListVC : ViewComponent
{
    private readonly IGuideService _guideService;

    public _GuideListVC(IGuideService guideService)
    {
        _guideService = guideService;
    }

    
    public IViewComponentResult Invoke()
    {
        var guides = _guideService.GetList();
        return View(guides);
    }
}