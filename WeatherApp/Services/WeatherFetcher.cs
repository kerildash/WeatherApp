using Newtonsoft.Json;
using WeatherApp.Models;

namespace WeatherApp.Services
{
	public static class WeatherFetcher
	{
		public static async Task<string> GetCurrentWeather(string city)
		{
			var client = new HttpClient();

			
			string key = "239f9e0170beb6be6282c54b590ff0e8";
			using var request = new HttpRequestMessage(HttpMethod.Get, $"https://api.openweathermap.org/data/2.5/weather?q={city}&units=metric&appid={key}");

			var response =  await client.SendAsync(request);
			string responseBody = await response.Content.ReadAsStringAsync();
			Weather currentWeather = JsonConvert.DeserializeObject<Weather>(responseBody);
			return responseBody;
		}

	}
}
