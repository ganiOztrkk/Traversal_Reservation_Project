using BusinessLayer.Abstract;
using EntityLayer.Concrete;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;

namespace TraversalProject.Controllers;


[AllowAnonymous]
public class ContactController : Controller
{
    private readonly IContactMessageService _contactMessageService;

    public ContactController(IContactMessageService contactMessageService)
    {
        _contactMessageService = contactMessageService;
    }


    [HttpGet]
    public IActionResult Index()
    {
        return View();
    }
    
    [HttpPost]
    public IActionResult Index(ContactMessage contactMessage)
    {
        if (!ModelState.IsValid) return View();

        contactMessage.MessageDate = DateTime.Now;
        _contactMessageService.Insert(contactMessage);
        return RedirectToAction("Index");
    }
}