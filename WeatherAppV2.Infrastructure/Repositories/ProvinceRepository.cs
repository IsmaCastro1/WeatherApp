using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using WeatherAppV2.Domain;
using WeatherAppV2.Domain.Interfaces;
using WeatherAppV2.Infrastructure.Data;

namespace WeatherAppV2.Infrastructure.Repositories;
    public class ProvinceRepository : IProvinceRepository
    {
        private readonly WeatherDbContext _weatherDbContext;

        public ProvinceRepository(WeatherDbContext weatherDbContext)
        {
            _weatherDbContext = weatherDbContext;
        }

    public async Task<Province> FindProvinceByID(String id)
    {
        return await _weatherDbContext.Provinces.FindAsync(id);
    }

    public async Task<List<Province>> GetAllProvinces()
        {
            return await _weatherDbContext.Provinces.ToListAsync();
        }
    }

