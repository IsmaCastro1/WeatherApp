using WeatherAppV2.WebApp.Domain.Models;

namespace WeatherAppV2.Domain.Interfaces
{
    public interface ITemperatureService
    {
        public Task<MessageReponse<int>> GetMunicipalityTemperature(String codgeo);
    }
}
