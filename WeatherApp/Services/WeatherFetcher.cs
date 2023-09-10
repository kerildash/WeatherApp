using WeatherApp.Models;

namespace WeatherApp.Services
{
	public static class WeatherFetcher
	{
		public static void GetCurrentWeather(int id)
		{
			var client = new HttpClient();

			
			string key = "239f9e0170beb6be6282c54b590ff0e8";
			string city = "Minsk";
			using var request = new HttpRequestMessage(HttpMethod.Get, $"https://api.openweathermap.org/data/2.5/weather?q={city}&units=metric&appid={key}");
			request.Headers.Add("X-Gismeteo-Token", "56b30cb255.3443075");

			var response = client.SendAsync(request).Result;
		}

	}
}
