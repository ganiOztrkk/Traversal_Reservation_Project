using BusinessLayer.Abstract;
using Microsoft.AspNetCore.Mvc;

namespace TraversalProject.Components.Default;

public class _FeatureVC : ViewComponent
{
    private readonly IFeatureService _featureService;

    public _FeatureVC(IFeatureService featureService)
    {
        _featureService = featureService;
    }

    public IViewComponentResult Invoke()
    {
        return View();
    }
}