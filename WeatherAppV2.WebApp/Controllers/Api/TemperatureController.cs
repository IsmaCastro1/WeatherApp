using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.SignalR;
using WeatherAppV2.WebApp.Models.services;
using WeatherAppV2.WebApp.Models.ViewModels;

namespace WeatherAppV2.WebApp.Controllers.Api
{
	[ApiController]
	public class TemperatureController : ControllerBase
	{
		private readonly IHubContext<TemperatureHub> _hubContext;

		public TemperatureController(IHubContext<TemperatureHub> hubContext)
		{
			this._hubContext = hubContext;
		}

		[HttpPost("Temperature")]
		public async Task<IActionResult> TemperatureNow([FromBody] TemperatureNow temperature)
		{
			await _hubContext.Clients.All.SendAsync("Receive", temperature.Temperatura);
			return Ok();
		}
	}
}
