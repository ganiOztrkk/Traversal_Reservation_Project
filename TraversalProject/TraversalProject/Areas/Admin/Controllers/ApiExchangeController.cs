using Microsoft.AspNetCore.Mvc;
using System.Net.Http.Headers;
using Newtonsoft.Json;
using TraversalProject.Areas.Admin.Models;

namespace TraversalProject.Areas.Admin.Controllers;


[Area("Admin")]
[Route("Admin/[controller]/[action]")]
public class ApiExchangeController : Controller
{
    public async Task<IActionResult> Index()
    {
        var client = new HttpClient();
        var request = new HttpRequestMessage
        {
            Method = HttpMethod.Get,
            RequestUri = new Uri("https://booking-com.p.rapidapi.com/v1/metadata/exchange-rates?currency=TRY&locale=en-gb"),
            Headers =
            {
                { "X-RapidAPI-Key", "57a05ced9fmsh7440ac7d8e5603fp1f46d8jsnd9e3022ec3f3" },
                { "X-RapidAPI-Host", "booking-com.p.rapidapi.com" },
            },
        };
        using (var response = await client.SendAsync(request))
        {
            response.EnsureSuccessStatusCode();
            var body = await response.Content.ReadAsStringAsync();
            var values = JsonConvert.DeserializeObject<BookingExchangeVM>(body);
            return View(values!.exchange_rates);
        }
    }
}