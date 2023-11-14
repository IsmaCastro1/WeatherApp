using Microsoft.AspNetCore.Mvc;

namespace WeatherAppV2.WebApp.Controllers
{
	public class UserController : Controller
	{
		public IActionResult Login()
		{
			return View();
		}


		public IActionResult Register()
		{
			return View();
		}


		[HttpPost]
		public IActionResult DoRegister()
		{
			return View();
		}

	}
}
