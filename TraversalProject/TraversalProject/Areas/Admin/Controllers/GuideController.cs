using BusinessLayer.Abstract;
using EntityLayer.Concrete;
using Microsoft.AspNetCore.Mvc;

namespace TraversalProject.Areas.Admin.Controllers;

[Area("Admin")]
[Route("Admin/[controller]/[action]")]
public class GuideController : Controller
{
    private readonly IGuideService _guideService;

    public GuideController(IGuideService guideService)
    {
        _guideService = guideService;
    }

    public IActionResult Index()
    {
        var guides = _guideService.GetList();
        return View(guides);
    }

    [HttpGet]
    public IActionResult AddGuide()
    {
        return View();
    }
    
    [HttpPost]
    public IActionResult AddGuide(Guide guide)
    {
        guide.Status = true;
        _guideService.Insert(guide);
        return RedirectToAction("Index");
    }
    
    [HttpGet]
    public IActionResult UpdateGuide(int id)
    {
        var guide = _guideService.GetById(id);
        return View(guide);
    }
    
    [HttpPost]
    public IActionResult UpdateGuide(Guide guide)
    {
        _guideService.Update(guide);
        return RedirectToAction("Index");
    }

    public IActionResult PassiveGuide(int id)
    {
        var guide = _guideService.GetById(id);
        guide!.Status = false;
        _guideService.Update(guide);
        return RedirectToAction("Index");
    }
    
    public IActionResult ActivateGuide(int id)
    {
        var guide = _guideService.GetById(id);
        guide!.Status = true;
        _guideService.Update(guide);
        return RedirectToAction("Index");
    }
}