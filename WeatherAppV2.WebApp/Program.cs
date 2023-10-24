using Microsoft.EntityFrameworkCore;
using WeatherAppV2.Infrastructure.Data;
using WeatherAppV2.Domain.Interfaces;
using WeatherAppV2.Infrastructure.Repositories;

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

var app = builder.Build();

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

app.MapControllerRoute(
    name: "default",
    pattern: "{controller=Home}/{action=Index}/{id?}");

app.Run();
