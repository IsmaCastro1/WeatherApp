using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using WeatherAppV2.Domain.Entities.EUser;

namespace WeatherAppV2.Domain.Interfaces;

public interface IUserRepository
{
	Task<Boolean> InsertUser(Users_Password user);
}
