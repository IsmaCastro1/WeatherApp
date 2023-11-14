using System.Reflection.Metadata.Ecma335;
using Microsoft.AspNetCore.Mvc;
using WeatherAppV2.Domain.Entities.EMunicipality;
using WeatherAppV2.Domain.Interfaces;
using WeatherAppV2.Domain.Models;
using WeatherAppV2.WebApp.Domain.Models;
using WeatherAppV2.WebApp.Models.ViewModels;

namespace WeatherAppV2.WebApp.Controllers
{
    public class MunicipalityController : Controller
    {
        private readonly IMunicipalityRepository _municipalityRepository;
        private readonly IProvinceRepository _provinceRepository;
        private readonly ITemperatureService _temperatureService;

        public MunicipalityController(IMunicipalityRepository municipalityRepository, IProvinceRepository provinceRepository, ITemperatureService temperatureService)
        {
            _municipalityRepository = municipalityRepository;
            _provinceRepository = provinceRepository;
            _temperatureService = temperatureService;
        }

        [HttpPost]
        public async Task<IActionResult> MunicipalityMenu(String idprovince)
        {
            VMMunicipalityMenu municipalityMenu = new VMMunicipalityMenu
            {
                municipalites = await _municipalityRepository.GetMunicipalityByCodProv(idprovince),
                province = await _provinceRepository.FindProvinceByID(idprovince)
            };

            return View(municipalityMenu);
        }
        
        [HttpPost]
        public async Task<IActionResult> ShowTemperature (String Codigoine)
        {
            String idmun = Codigoine.Substring(0,5);

            Console.WriteLine(idmun);

            MessageReponse<TemperatureRoot> temp =  await _temperatureService.GetMunicipalityTemperature(idmun);

            if (temp.code.Equals("OK"))
            {
                return View(temp.data);
            }
            else
            {
                return RedirectToAction("Index","Home");
            }         
        }
    }
}
