using BusinessLayer.Abstract;
using Microsoft.AspNetCore.Mvc;

namespace TraversalProject.Components.Default;

public class _TestimonialVC : ViewComponent
{
    private readonly ITestimonialService _testimonialService;

    public _TestimonialVC(ITestimonialService testimonialService)
    {
        _testimonialService = testimonialService;
    }

    public IViewComponentResult Invoke()
    {
        var testimonials = _testimonialService.GetList().Where(x => x.Status == true);
        return View(testimonials);
    }
}