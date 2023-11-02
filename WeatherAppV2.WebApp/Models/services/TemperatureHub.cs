using Microsoft.AspNetCore.SignalR;

namespace WeatherAppV2.WebApp.Models.services
{
    public class TemperatureHub : Hub
    {
        public async Task Send(float temperature)
        {
            await Clients.All.SendAsync("Receive", temperature);
        }

    }
}
