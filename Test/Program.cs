using WeatherApp.Services;

namespace Test
{
	internal class Program
	{
		static void Main(string[] args)
		{
			WeatherFetcher.GetWeather(0);
		}
	}
}