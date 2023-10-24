using WeatherAppV2.Domain;

namespace WeatherAppV2.WebApp.Models.ViewModels
{
    public class VMMunicipalityMenu
    {
        public Province province { get; set; }
        public List<Municipality> municipalites { get; set; }
    }
}
