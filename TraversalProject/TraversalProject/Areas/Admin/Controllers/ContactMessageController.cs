using BusinessLayer.Abstract;
using EntityLayer.Concrete;
using Microsoft.AspNetCore.Mvc;

namespace TraversalProject.Areas.Admin.Controllers;

[Area("Admin")]
[Route("Admin/[controller]/[action]")]
public class ContactMessageController : Controller
{
    private readonly IContactMessageService _contactMessageService;

    public ContactMessageController(IContactMessageService contactMessageService)
    {
        _contactMessageService = contactMessageService;
    }


    public IActionResult Index()
    {
        var messages = _contactMessageService.GetList();
        return View(messages);
    }
    
    
    public IActionResult MessageDetail(int id)
    {
        return View();
    }
    
    public IActionResult DeleteMessage(int id)
    {
        var message = _contactMessageService.GetById(id);
        _contactMessageService.Delete(message!);
        return RedirectToAction("Index");
    }
} 