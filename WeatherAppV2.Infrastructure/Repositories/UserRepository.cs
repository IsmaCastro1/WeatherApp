﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.ChangeTracking;
using Microsoft.EntityFrameworkCore.Migrations.Operations;
using WeatherAppV2.Domain.Entities.EMunicipality;
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

	public async Task<bool> DeleteUserMunicipality(int id)
	{
		User_Municipalities user_Municipalities = await _dbContext.User_Municipalities.FindAsync(id);
		var entity = _dbContext.User_Municipalities.Single(x => x.Id == id);
		_dbContext.User_Municipalities.Remove(entity);
		await _dbContext.SaveChangesAsync();
		return true;
	}

	public async Task<User> GetUserByUsername(string username)
	{
		return await _dbContext.Users
			.Include(u => u.Users_Password)
			.FirstOrDefaultAsync(u => u.Username == username);		
	}

    public async Task<List<User_Municipalities>> GetUserMunicipalites(int iduser)
    {
		return await _dbContext.User_Municipalities
			.Include( m => m.municipality)
			.Where(u => u.IdUser == iduser).ToListAsync();
    }

    public async Task<Boolean> InsertUser(Users_Password user)
	{
		 await _dbContext.Users_Passwords.AddAsync(user);	 
		 await _dbContext.SaveChangesAsync();
		 return true;
	}

	public async Task<Boolean> InsertUserMunicipality(User_Municipalities user_Municipalities)
	{
		await _dbContext.User_Municipalities.AddAsync(user_Municipalities);
		await _dbContext.SaveChangesAsync();
		return true;
	}

}
