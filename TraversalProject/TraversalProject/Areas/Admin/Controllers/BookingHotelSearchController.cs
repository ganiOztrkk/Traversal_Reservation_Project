using System.Net.Http.Headers;
using Microsoft.AspNetCore.Mvc;
using Newtonsoft.Json;
using TraversalProject.Areas.Admin.Models;

namespace TraversalProject.Areas.Admin.Controllers;

public class BookingHotelSearchController : Controller
{
    // GET
    public async Task<IActionResult> Index()
    {
        var client = new HttpClient();
        var request = new HttpRequestMessage
        {
            Method = HttpMethod.Get,
            RequestUri = new Uri(
                "https://booking-com.p.rapidapi.com/v2/hotels/search?order_by=popularity&adults_number=2&checkin_date=2023-09-27&filter_by_currency=AED&dest_id=-1456928&locale=en-gb&checkout_date=2023-09-28&units=metric&room_number=1&dest_type=city&include_adjacency=true&children_number=2&page_number=0&children_ages=5%2C0&categories_filter_ids=class%3A%3A2%2Cclass%3A%3A4%2Cfree_cancellation%3A%3A1"),
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
            var values = JsonConvert.DeserializeObject<BookingHotelSearchVM>(body);
            return View(values.result);
        }
    }
    
    [HttpGet]
    public IActionResult GetCityDestID()
    {
        return View();
    }

    [HttpPost]
    public async Task< IActionResult> GetCityDestID(string p)
    {
        var client = new HttpClient();
        var request = new HttpRequestMessage
        {
            Method = HttpMethod.Get,
            RequestUri = new Uri($"https://booking-com.p.rapidapi.com/v1/hotels/locations?locale=en-gb&name={p}"),
            Headers =
            {
                { "X-RapidAPI-Key", "cb5ee15da1mshb46d59d679af3abp1fe84cjsn167590fdc0cc" },
                { "X-RapidAPI-Host", "booking-com.p.rapidapi.com" },
            },
        };
        using (var response = await client.SendAsync(request))
        {
            response.EnsureSuccessStatusCode();
            var body = await response.Content.ReadAsStringAsync();

            return View();
        }
    }
}