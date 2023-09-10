using Newtonsoft.Json;
using System.Diagnostics.Contracts;

namespace WeatherApp.Models
{
	public class Weather
	{
		[JsonProperty("name")]
		public string? City { get; set; }
		[JsonProperty("main")]
		public WeatherData Data { get; set; }
    }

	public class WeatherData
	{
		[JsonProperty("temp")]
		public double Temperature { get; set; }
	}
}
