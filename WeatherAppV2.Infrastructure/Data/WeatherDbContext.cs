using System;
using System.Collections.Generic;
using Microsoft.EntityFrameworkCore;
using WeatherAppV2.Domain;
using WeatherAppV2.Domain.Entities.EMunicipality;
using WeatherAppV2.Domain.Entities.EProvince;
using WeatherAppV2.Domain.Entities.EUser;

namespace WeatherAppV2.Infrastructure.Data;

public partial class WeatherDbContext : DbContext
{
    public WeatherDbContext()
    {
    }

    public WeatherDbContext(DbContextOptions<WeatherDbContext> options)
        : base(options)
    {
    }
    public DbSet<User> Users { get; set; }
    public DbSet<User_Bank_Detail> User_Bank_Details { get; set; }
    public DbSet<Users_Password> Users_Passwords { get; set; }
    public DbSet<Municipality> Municipalities  { get; set; }
    public DbSet<Province> Provinces { get; set; }
    public DbSet<User_Municipalities> User_Municipalities { get; set; }

    public DbSet<Popular_Municipalities> popular_Municipalities { get; set; }

}
