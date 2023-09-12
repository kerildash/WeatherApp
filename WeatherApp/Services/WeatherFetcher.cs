using Newtonsoft.Json;
using System.Reflection.Metadata.Ecma335;
using WeatherApp.Models;

namespace WeatherApp.Services
{
	public static class WeatherFetcher
	{
		public static async Task<Weather> GetCurrentWeather(string city)
		{
			var client = new HttpClient();
			string key = GetApiKey();
			using var request = new HttpRequestMessage(HttpMethod.Get, $"https://api.openweathermap.org/data/2.5/weather?q={city}&units=metric&appid={key}");

			var response =  await client.SendAsync(request);
			string responseBody = await response.Content.ReadAsStringAsync();
			Weather currentWeather = JsonConvert.DeserializeObject<Weather>(responseBody);
			return currentWeather;
		}
		public static Weather GetTestWeather(string city)
		{
			Weather weather = new Weather
			{
				City = city,
				Data = new WeatherData
				{
					Temperature = 15
				}
			};
			return weather;
		}

		private static string GetApiKey(string variableName = "WEATHER_API_KEY")
		{
			try
			{
				string key = Environment.GetEnvironmentVariable(variableName);
				if (key is null)
				{
					throw new NullReferenceException(
						$"null is received at attempt to get the value of {variableName} system variable.");
				}
				else
				{
					return key;
				}
			}
			catch 
			{
				throw;
			}

		}
	}
}
