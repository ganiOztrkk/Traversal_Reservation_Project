using AutoMapper;
using BusinessLayer.Abstract;
using DTOLayer.DTOs.AnnouncementDTOs;
using EntityLayer.Concrete;
using Microsoft.AspNetCore.Mvc;

namespace TraversalProject.Areas.Admin.Controllers;

[Area("Admin")]
[Route("Admin/[controller]/[action]")]
public class AnnouncementController : Controller
{
    private readonly IAnnouncementService _announcementService;
    private readonly IMapper _mapper;

    public AnnouncementController(IAnnouncementService announcementService, IMapper mapper)
    {
        _announcementService = announcementService;
        _mapper = mapper;
    }

    public IActionResult Index()
    {
        var announcements = _announcementService.GetList();
        return View(announcements);
    }

    [HttpGet]
    public IActionResult AddAnnouncement()
    {
        return View();
    }
    [HttpPost]
    public IActionResult AddAnnouncement(AnnouncementAddDTOs announcementAddDtOs)
    {
        var values = _mapper.Map<Announcement>(announcementAddDtOs);
        values.Date = Convert.ToDateTime(DateTime.Now.ToShortDateString());
        if (!ModelState.IsValid) return View();
        _announcementService.Insert(values);
        return RedirectToAction("Index");
    }
   
    
    [HttpGet]
    public IActionResult UpdateAnnouncement(int id)
    {
        var announcement = _announcementService.GetById(id);
        return View(announcement);
    }
    [HttpPost]
    public IActionResult UpdateAnnouncement(Announcement announcement)
    {
        _announcementService.Update(announcement);
        return RedirectToAction("Index");
    }
    
    public IActionResult DeleteAnnouncement(int id)
    {
        var announcement = _announcementService.GetById(id);
        _announcementService.Delete(announcement!);
        return RedirectToAction("Index");
    }
}