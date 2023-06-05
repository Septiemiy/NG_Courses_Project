using WaetherForecasterBLL.Interfaces;
using WaetherForecasterBLL.Services;
using WaetherForecasterBLL.Models;
using WeatherForecaster.GetJSON;
using WeatherForecasterDAL.DbStartUp;
using Serilog;
using WaetherForecasterBLL.Extensions;
using WeatherForecasterPL;
using Microsoft.AspNetCore.Builder;
using WeatherForecasterPL.Middleware;

var builder = WebApplication.CreateBuilder(args);

IConfiguration configuration = builder.Configuration;

builder.Services.InjectDAL(configuration);
builder.Services.AddServiceInjection();
builder.Services.AddFactoryInjection();

// Add services to the container.
builder.Services.AddControllersWithViews();


var app = builder.Build();


// Configure the HTTP request pipeline.
if (!app.Environment.IsDevelopment())
{
    app.UseExceptionHandler("/Daily/Error");
    // The default HSTS value is 30 days. You may want to change this for production scenarios, see https://aka.ms/aspnetcore-hsts.
    app.UseHsts();
}

using (var scope = app.Services.CreateScope())
{
    var serviceProvider = scope.ServiceProvider;
    try
    {
        var context = serviceProvider.GetRequiredService<DBContext>();
        DbInitializer.Initialize(context);
    }
    catch(Exception exception)
    {
        throw exception;
    }
}

app.UseHttpsRedirection();

app.UseStaticFiles();

app.UseAuthorization();

app.MapControllerRoute(
    name: "default",
    pattern: "{controller=WeatherForecasterDaily}/{action=Daily}/{id?}");

app.UseMiddleware<LoggingMiddleware>();
app.UseMiddleware<ErrorsLoggingMiddleware>();

app.Run();