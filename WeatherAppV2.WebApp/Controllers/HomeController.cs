using Microsoft.AspNetCore.Mvc;

namespace WeatherAppV2.WebApp.Controllers
{
	public class HomeController : Controller
	{
		public IActionResult Index()
		{
			return View();
		}
	}
}
