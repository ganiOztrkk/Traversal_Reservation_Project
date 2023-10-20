using BusinessLayer.Abstract;
using EntityLayer.Concrete;
using Microsoft.AspNetCore.Mvc;

namespace TraversalProject.Areas.Member.Controllers;


[Area("Member")]
[Route("Member/[controller]/[action]")]
public class ReservationController : Controller
{
    private readonly IReservationService _reservationService;

    public ReservationController(IReservationService reservationService)
    {
        _reservationService = reservationService;
    }

    [HttpGet]
    public IActionResult MyCurrentReservation()
    {
        return View();
    }
    
    
    
    [HttpGet]
    public IActionResult NewReservation()
    {
        return View();
    }
    [HttpPost]
    public IActionResult NewReservation(Reservation reservation)
    {
        return View();
    }
}