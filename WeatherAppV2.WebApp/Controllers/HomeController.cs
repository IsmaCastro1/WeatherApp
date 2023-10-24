using System.Diagnostics;
using Microsoft.AspNetCore.Mvc;
using WeatherAppV2.Domain.Interfaces;
using WeatherAppV2.WebApp.Models;

namespace WeatherAppV2.WebApp.Controllers
{
    public class HomeController : Controller
    {

        #region ---------------------- VARIABLES ZONE -------------------------------
        private readonly ILogger<HomeController> _logger;
        private readonly IProvinceRepository _provinceRepository;

        public HomeController(ILogger<HomeController> logger, IProvinceRepository provinceRepository)
        {
            this._logger = logger;
            this._provinceRepository = provinceRepository;
        }
        #endregion

        #region ----------------------------- VIEW ENGINE -------------------------------------
        public async Task<IActionResult> Index()
        {
            return View(await _provinceRepository.GetAllProvinces());
        }

        [ResponseCache(Duration = 0, Location = ResponseCacheLocation.None, NoStore = true)]
        public IActionResult Error()
        {
            return View(new ErrorViewModel { RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier });
        }
        #endregion
   

    
    }
}