using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WeatherAppV2.Domain.Interfaces;

public interface IProvinceRepository
{
    Task<List<Province>> GetAllProvinces();
    Task<Province> FindProvinceByID(String id);

}
