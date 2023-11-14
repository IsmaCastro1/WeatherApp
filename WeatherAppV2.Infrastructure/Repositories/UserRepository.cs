using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore.ChangeTracking;
using WeatherAppV2.Domain.Entities.EUser;
using WeatherAppV2.Domain.Interfaces;
using WeatherAppV2.Infrastructure.Data;

namespace WeatherAppV2.Infrastructure.Repositories;

public class UserRepository : IUserRepository
{

	private readonly WeatherDbContext _dbContext;

    public UserRepository(WeatherDbContext dbContext)
    {
		this._dbContext = dbContext;
	}

    public async Task<Boolean> InsertUser(Users_Password user)
	{
		 await _dbContext.Users_Passwords.AddAsync(user);	 
		 await _dbContext.SaveChangesAsync();
		 return true;
	}
}
