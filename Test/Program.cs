﻿using WeatherApp.Services;

namespace Test
{
	internal class Program
	{
		static async Task Main()
		{
			string resp = await WeatherFetcher.GetCurrentWeather("Minsk");
			
		}
	}
}