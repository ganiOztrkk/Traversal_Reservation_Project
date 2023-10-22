using System.Configuration;
using BusinessLayer.Abstract;
using DataAccessLayer.Concrete;
using EntityLayer.Concrete;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;

namespace TraversalProject.Areas.Admin.Controllers;

[Area("Admin")]
[Route("Admin/[controller]/[action]")]
public class UserController : Controller
{
    private readonly IAppUserService _appUserService;
    private readonly IReservationService _reservationService;
    public UserController(IAppUserService appUserService, IReservationService reservationService)
    {
        _appUserService = appUserService;
        _reservationService = reservationService;
    }

    public IActionResult Index()
    {
        var users = _appUserService.GetList();
        return View(users);
    }

    public IActionResult DeleteUser(int id)
    {
        var user = _appUserService.GetById(id);
        _appUserService.Delete(user!);
        return RedirectToAction("Index");
    }

    [HttpGet]
    public IActionResult UpdateUser(int id)
    {
        var user = _appUserService.GetById(id);
        return View(user);
    }
    [HttpPost]
    public IActionResult UpdateUser(AppUser appUser)
    {
        _appUserService.Update(appUser);
        return RedirectToAction("Index");
    }
    
    public IActionResult CommentUser(int id)
    {
        return NoContent();
    }
    public IActionResult ReservationUser(int id)
    {
        using var context = new Context();
        var reservations = context.Reservations!.Include(x => x.Destination).Include(x=>x.AppUser)
            .Where(x => x.AppUserId == id && (x.Status == "Approved"|| x.Status =="Confirmed")).ToList();
        return View(reservations);
    }
}