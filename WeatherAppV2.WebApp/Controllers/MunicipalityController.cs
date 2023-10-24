using Microsoft.AspNetCore.Mvc;
using WeatherAppV2.Domain.Interfaces;
using WeatherAppV2.WebApp.Models.ViewModels;

namespace WeatherAppV2.WebApp.Controllers
{
    public class MunicipalityController : Controller
    {
        private readonly IMunicipalityRepository _municipalityRepository;
        private readonly IProvinceRepository _provinceRepository;

        public MunicipalityController(IMunicipalityRepository municipalityRepository, IProvinceRepository provinceRepository)
        {
            _municipalityRepository = municipalityRepository;
            _provinceRepository = provinceRepository;
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
    }
}
