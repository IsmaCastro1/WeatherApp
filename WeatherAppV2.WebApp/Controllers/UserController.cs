using Microsoft.AspNetCore.Mvc;
using WeatherAppV2.Domain.Interfaces;
using WeatherAppV2.WebApp.Models.ViewModels;
using WeatherAppV2.Domain.Entities.EUser;
using System.Text.Json;
using WeatherAppV2.Domain.Models;
using WeatherAppV2.Infrastructure.Services;
using WeatherAppV2.WebApp.Domain.Models;

namespace WeatherAppV2.WebApp.Controllers
{
	public class UserController : Controller
	{

		private readonly IUserRepository _userRepository;
        private readonly ITemperatureService _temperatureService;

        public UserController(IUserRepository userRepository, ITemperatureService temperatureService)
        {
            this._userRepository = userRepository;
            this._temperatureService = temperatureService;
        }


        #region ------------ REGISTER -----------------------
        public IActionResult Register()
		{
            try
            {
                UserView userlog = JsonSerializer.Deserialize<UserView>(HttpContext.Session.GetString("userdata"));
                ViewBag.user = userlog;
            }
            catch (Exception ex){}

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

			return RedirectToAction("Login");
        }
        #endregion-----------------------------------------------

        #region ------------------- LOGIN --------------------
        public IActionResult Login()
		{
            try
            {
                UserView userlog = JsonSerializer.Deserialize<UserView>(HttpContext.Session.GetString("userdata"));
                ViewBag.user = userlog;
            }
            catch (Exception ex){}

            return View();
		}
		[HttpPost]
		public async Task<IActionResult> Login(String username, String password)
		{
            User user = await _userRepository.GetUserByUsername(username);

			if (user == null || !user.Users_Password.password.Equals(password))
			{
				ViewData["ErrorLogin"] = "Usuario o Contraseña incorrectos";
				return View();
			}

			HttpContext.Session.SetString("userdata",JsonSerializer.Serialize<UserView>(new UserView { Email = user.Email, LasName = user.LasName , Name = user.Name, Username = user.Username , Password ="", id = user.IdUser }));

			return RedirectToAction("UserPanel");
        }
        #endregion -----------------------------------------------

        #region ---------------------- USER PANEL ------------------
        public async Task<IActionResult> UserPanel()
		{

			try
			{
                UserView user = JsonSerializer.Deserialize<UserView>(HttpContext.Session.GetString("userdata"));

                ViewBag.user = user;

                if (user == null)
                {
                    RedirectToAction("Login");
                }

                List<TemperatureRoot> muntemperature = new List<TemperatureRoot>();

		        foreach (User_Municipalities user_Municipalities in await _userRepository.GetUserMunicipalites(user.id))
                {
                    MessageReponse<TemperatureRoot> temp = await _temperatureService.GetMunicipalityTemperature(user_Municipalities.CODIGOINE.Substring(0,5));
                    temp.data.municipio = user_Municipalities.municipality;
                    muntemperature.Add(temp.data);
                }


                ViewBag.UserMunicipalities = muntemperature;

                return View(user);
				
            }
			catch (Exception ex)
			{
				return RedirectToAction("Login");
			}
			
		}
        #endregion ----------------------------------------------------
    }
}
