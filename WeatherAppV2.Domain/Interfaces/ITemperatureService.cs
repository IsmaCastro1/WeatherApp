using WeatherAppV2.Domain.Models;
using WeatherAppV2.WebApp.Domain.Models;

namespace WeatherAppV2.Domain.Interfaces
{
    public interface ITemperatureService
    {
        public Task<MessageReponse<TemperatureRoot>> GetMunicipalityTemperature(String codgeo);
    }
}
