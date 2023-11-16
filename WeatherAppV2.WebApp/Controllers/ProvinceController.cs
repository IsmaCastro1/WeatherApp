
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.SignalR;
using WeatherAppV2.Domain.Entities.EMunicipality;
using WeatherAppV2.Domain.Interfaces;
using WeatherAppV2.Domain.Models;
using WeatherAppV2.WebApp.Domain.Models;
using WeatherAppV2.WebApp.Models.services;


namespace WeatherAppV2.WebApp.Controllers
{
    public class ProvinceController : Controller
    {

        #region ---------------------- VARIABLES ZONE -------------------------------
        private readonly IProvinceRepository _provinceRepository;
        private readonly IHubContext<TemperatureHub> _hubContext;
        private readonly IMunicipalityRepository _municipalityRepository;
		private readonly ITemperatureService _temperatureService;

		public ProvinceController( IProvinceRepository provinceRepository , IHubContext<TemperatureHub> hubContext, IMunicipalityRepository municipalityRepository, ITemperatureService temperatureService)
        {
            this._provinceRepository = provinceRepository;
            this._hubContext = hubContext;
            this._municipalityRepository = municipalityRepository;
            this._temperatureService = temperatureService;
        }
        #endregion

        #region ----------------------------- VIEW ENGINE -------------------------------------

        public async Task<IActionResult> Index()
		{

			List<TemperatureRoot> muntemperature = new List<TemperatureRoot>();

			foreach (Popular_Municipalities popularmun in await _municipalityRepository.GetPopularMunicipalities())
			{
				MessageReponse<TemperatureRoot> temp = await _temperatureService.GetMunicipalityTemperature(popularmun.CODIGOINE.Substring(0,5));
				temp.data.municipio = popularmun.municipality;
				muntemperature.Add(temp.data);
			}

            ViewBag.popularmun = muntemperature;

			return View(await _provinceRepository.GetAllProvinces());
        }
        #endregion
   
    }
}