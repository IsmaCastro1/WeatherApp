using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using WeatherAppV2.Domain.Entities.EMunicipality;
using WeatherAppV2.Domain.Interfaces;
using WeatherAppV2.Infrastructure.Data;

namespace WeatherAppV2.Infrastructure.Repositories;
public class MunicipalityRepository : IMunicipalityRepository
{
    private readonly WeatherDbContext _weatherDbContext;

    public MunicipalityRepository(WeatherDbContext weatherDbContext)
    {
        _weatherDbContext = weatherDbContext;
    }

    public async Task<Municipality> GetMunicipalityByCodGeo(string codgeo)
    {
        return await _weatherDbContext.Municipalities.FirstOrDefaultAsync(mun => mun.CodGeo == codgeo);
    }

    public async Task<List<Municipality>> GetMunicipalityByCodProv(string codprov)
    {
        return await _weatherDbContext.Municipalities.Where(
                Municipality => Municipality.Codprov == codprov
            ).ToListAsync();
    }

    public async Task<Municipality> GetMunicipalityById(string Codigoine)
    {
        return await _weatherDbContext.Municipalities.FindAsync(Codigoine);
    }

    public async Task<List<Popular_Municipalities>> GetPopularMunicipalities()
    {
        return await _weatherDbContext.popular_Municipalities.Include(m => m.municipality).ToListAsync();
    }
}
