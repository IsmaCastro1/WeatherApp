using Microsoft.EntityFrameworkCore;
using WeatherAppV2.Infrastructure.Data;
using WeatherAppV2.Domain.Interfaces;
using WeatherAppV2.Infrastructure.Repositories;
using WeatherAppV2.WebApp.Models.services;
using WeatherAppV2.Infrastructure.Services;

var builder = WebApplication.CreateBuilder(args);

//DataBase
builder.Services.AddDbContext<WeatherDbContext>(options => 
    {
        options.UseSqlServer(builder.Configuration.GetConnectionString("SqlConnection"));
    }
);

//Repositories
builder.Services.AddScoped<IProvinceRepository, ProvinceRepository>();
builder.Services.AddScoped<IMunicipalityRepository, MunicipalityRepository>();


// Add services to the container.
builder.Services.AddControllersWithViews();

//Servicio SignalR (Tiempo Real)
builder.Services.AddSignalR();

builder.Services.AddScoped<ITemperatureService, TemperatureService>();


var app = builder.Build();

using(var scope = app.Services.CreateScope())
{
    var context = scope.ServiceProvider.GetRequiredService<WeatherDbContext>();
    context.Database.Migrate();
}

// Configure the HTTP request pipeline.
if (!app.Environment.IsDevelopment())
{
    app.UseExceptionHandler("/Home/Error");
    // The default HSTS value is 30 days. You may want to change this for production scenarios, see https://aka.ms/aspnetcore-hsts.
    app.UseHsts();
}

app.UseHttpsRedirection();
app.UseStaticFiles();

app.UseRouting();

app.UseAuthorization();

app.UseEndpoints(endpoints => {
    app.MapHub<TemperatureHub>("/Temperature");
});

app.MapControllerRoute(
    name: "default",
    pattern: "{controller=Home}/{action=Index}/{id?}");




app.Run();
