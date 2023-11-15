using System.Text.Json;
using Microsoft.AspNetCore.Mvc;
using WeatherAppV2.WebApp.Models.ViewModels;

namespace WeatherAppV2.WebApp.Controllers
{
	public class HomeController : Controller
	{
		public IActionResult Index()
		{
            try
            {
                UserView userlog = JsonSerializer.Deserialize<UserView>(HttpContext.Session.GetString("userdata"));
                ViewBag.user = userlog;
            }
            catch (Exception ex)
            {

            }

            return View();
		}
	}
}
