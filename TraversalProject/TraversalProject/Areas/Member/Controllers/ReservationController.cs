using BusinessLayer.Abstract;
using DataAccessLayer.Concrete;
using EntityLayer.Concrete;
using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Rendering;
using Microsoft.EntityFrameworkCore;

namespace TraversalProject.Areas.Member.Controllers;

[Area("Member")]
[Route("Member/[controller]/[action]")]
public class ReservationController : Controller
{
    private readonly IReservationService _reservationService;
    private readonly IDestinationService _destinationService;
    private readonly UserManager<AppUser> _userManager;

    public ReservationController(IReservationService reservationService, IDestinationService destinationService, UserManager<AppUser> userManager)
    {
        _reservationService = reservationService;
        _destinationService = destinationService;
        _userManager = userManager;
    }


    public async Task<IActionResult> MyCurrentReservation()
    {
        await using var context = new Context();
        var appUser = await _userManager.FindByNameAsync(User.Identity!.Name!);
        var reservations = context.Reservations!.Include(x => x.Destination)
            .Where(x => x.AppUserId == appUser!.Id && x.Status == "Approved").ToList();
        return View(reservations);
    }

    public async Task<IActionResult> MyOldReservation()
    {
        await using var context = new Context();
        var appUser = await _userManager.FindByNameAsync(User.Identity!.Name!);
        var reservations = context.Reservations!.Include(x => x.Destination)
            .Where(x => x.AppUserId == appUser!.Id && x.Status == "Completed").ToList();
        return View(reservations);
    }

    public async Task<IActionResult> MyApprovalReservation()
    {
        await using var context = new Context();
        var appUser = await _userManager.FindByNameAsync(User.Identity!.Name!);
        var reservations = context.Reservations!.Include(x => x.Destination)
            .Where(x => x.AppUserId == appUser!.Id && x.Status == "Waiting").ToList();
        return View(reservations);
    }

    [HttpGet]
    public IActionResult NewReservation()
    {
        List<SelectListItem> values = 
            (from x in _destinationService.GetList()
            select new SelectListItem
            {
                Text = x.City,
                Value = x.DestinationId.ToString()
            }).ToList();
        ViewBag.Destinations = values;
        return View();
    }

    [HttpPost]
    public IActionResult NewReservation(Reservation reservation)
    {
        reservation.AppUserId = 2;
        reservation.Status = "Waiting";
        _reservationService.Insert(reservation);
        return RedirectToAction("MyCurrentReservation");
    }
}