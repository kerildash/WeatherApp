using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using WeatherApp.Services;
using WeatherApp.Models;

namespace WeatherApp.Pages
{
    public class IndexModel : PageModel
    {
        public Weather? Weather { get; set; }
        public async Task OnGetAsync()
        {

            Weather = await WeatherFetcher.GetCurrentWeather("Minsk");
        }
    }
}
