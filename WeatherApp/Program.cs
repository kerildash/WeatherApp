namespace WeatherApp
{
	public class Program
	{
		public static void Main(string[] args)
		{
			var builder = WebApplication.CreateBuilder(args);
			builder.Services.AddRazorPages();
			var app = builder.Build();

			app.UseHttpsRedirection();

			app.UseRouting();
			app.MapRazorPages();
			

			app.Run();
		}
	}
}