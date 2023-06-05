using WaetherForecasterBLL.Interfaces;
using WaetherForecasterBLL.Services;
using WaetherForecasterBLL;
using Microsoft.Extensions.DependencyInjection;
using WaetherForecasterBLL.Factory.Interfaces;
using WaetherForecasterBLL.Factory;

namespace WeatherForecasterPL
{
    public static class AddFactory
    {
        public static void AddFactoryInjection(this IServiceCollection services)
        {
            services.AddScoped<IRequestsLogServicesFactory, RequestsLogServicesFactory>();
            services.AddScoped<IErrorsLogServicesFactory, ErrorsLogServicesFactory>();
        }
    }
}
