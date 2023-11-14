using System.Diagnostics;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.SignalR;
using WeatherAppV2.Domain.Interfaces;
using WeatherAppV2.WebApp.Models;
using WeatherAppV2.WebApp.Models.services;
using WeatherAppV2.WebApp.Models.ViewModels;

namespace WeatherAppV2.WebApp.Controllers
{
    public class ProvinceController : Controller
    {

        #region ---------------------- VARIABLES ZONE -------------------------------
        private readonly IProvinceRepository _provinceRepository;
        private readonly IHubContext<TemperatureHub> _hubContext;

        public ProvinceController( IProvinceRepository provinceRepository , IHubContext<TemperatureHub> hubContext)
        {
            this._provinceRepository = provinceRepository;
            this._hubContext = hubContext;
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