using Microsoft.AspNetCore.Mvc;
using Newtonsoft.Json;
using TraversalProject.Areas.Admin.Models;

namespace TraversalProject.Areas.Admin.Controllers;


[Area("Admin")]
[Route("Admin/[controller]/[action]")]
public class ApiMovieController : Controller
{
    
    public async Task<IActionResult> Index()
    {
        List<ApiMovieVM> apiMovies = new List<ApiMovieVM>();
        var client = new HttpClient();
        var request = new HttpRequestMessage
        {
            Method = HttpMethod.Get,
            RequestUri = new Uri("https://imdb-top-100-movies.p.rapidapi.com/top100movies"),
            Headers =
            {
                { "X-RapidAPI-Key", "57a05ced9fmsh7440ac7d8e5603fp1f46d8jsnd9e3022ec3f3" },
                { "X-RapidAPI-Host", "imdb-top-100-movies.p.rapidapi.com" },
            },
        };
        using (var response = await client.SendAsync(request))
        {
            response.EnsureSuccessStatusCode();
            var body = await response.Content.ReadAsStringAsync();
            apiMovies = JsonConvert.DeserializeObject<List<ApiMovieVM>>(body);
            return View(apiMovies);
        }
        return View();
    }
}