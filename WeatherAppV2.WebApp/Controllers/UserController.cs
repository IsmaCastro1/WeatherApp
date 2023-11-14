using Microsoft.AspNetCore.Mvc;
using WeatherAppV2.Domain.Interfaces;
using WeatherAppV2.WebApp.Models.ViewModels;
using WeatherAppV2.Domain.Entities.EUser;

namespace WeatherAppV2.WebApp.Controllers
{
	public class UserController : Controller
	{

		private readonly IUserRepository _userRepository;

        public UserController(IUserRepository userRepository)
        {
            this._userRepository = userRepository;
        }
		public IActionResult Register()
		{
			return View();
		}

		[HttpPost]
		public async Task<IActionResult> Register(UserView user)
		{

			if(!ModelState.IsValid)
			{
				ViewData["Error"] = "Errores";
				return View();
			}

			User entityuser = new User { Email = user.Email, LasName = user.LasName, Name = user.Name, Username = user.Username };
			Users_Password entity_users_Password = new Users_Password { User = entityuser, password = user.Password };
			await _userRepository.InsertUser(entity_users_Password);

			return View();
		}


		public IActionResult Login()
		{
			return View();
		}
		[HttpPost]
		public IActionResult Login(String username, String password)
		{
			return View();
		}

	}
}
