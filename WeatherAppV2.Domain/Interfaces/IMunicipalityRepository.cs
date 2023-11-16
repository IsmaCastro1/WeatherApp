using WeatherAppV2.Domain.Entities.EMunicipality;

namespace WeatherAppV2.Domain.Interfaces;
public interface IMunicipalityRepository
{
    Task<List<Municipality>> GetMunicipalityByCodProv(String codprov);
    Task<Municipality> GetMunicipalityById(String Codigoine);
    Task<Municipality> GetMunicipalityByCodGeo(String codgeo);
    Task<List<Popular_Municipalities>> GetPopularMunicipalities();
}
