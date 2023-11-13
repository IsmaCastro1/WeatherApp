using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Http.Json;
using System.Text;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using WeatherAppV2.Domain.Models;
using WeatherAppV2.Domain.Interfaces;
using WeatherAppV2.Domain.Entities.EMunicipality;
using WeatherAppV2.WebApp.Domain.Models;

namespace WeatherAppV2.Infrastructure.Services;

public class TemperatureService : ITemperatureService
{
    private readonly String url = "https://www.el-tiempo.net/api/json/v2";
    private readonly HttpClient client = new HttpClient();
    public async Task<MessageReponse<TemperatureRoot>> GetMunicipalityTemperature(String codgeo)
    {
        try
        {
            TemperatureRoot temperatureRoot;
            String geo = codgeo.Substring(0,2);
            String tempurl = url + "/provincias/" + geo + "/municipios/" + codgeo;
            temperatureRoot = await client.GetFromJsonAsync<TemperatureRoot>(tempurl);
            return new MessageReponse<TemperatureRoot> { data = temperatureRoot, code = "OK" };
        }
        catch (Exception ex)
        {
            return new MessageReponse<TemperatureRoot> { code = "ERROR" , data = null };
        }
    }
}
