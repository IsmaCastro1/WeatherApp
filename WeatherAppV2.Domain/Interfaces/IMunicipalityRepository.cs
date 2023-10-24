using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WeatherAppV2.Domain.Interfaces;
public interface IMunicipalityRepository
{
    Task<List<Municipality>> GetMunicipalityByCodProv(String codprov);
}
