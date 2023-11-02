using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using WeatherAppV2.Domain.Entities.EMunicipality;

namespace WeatherAppV2.Domain.Interfaces
{
    public interface ITemperatureService
    {
        public Task<int> GetMunicipalityTemperature(String codgeo);
    }
}
