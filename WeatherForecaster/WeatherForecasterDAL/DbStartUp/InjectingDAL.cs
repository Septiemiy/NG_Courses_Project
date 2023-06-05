using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using WeatherForecasterDAL.Repository;
using WeatherForecasterDAL.Repository.Interfaces;

namespace WeatherForecasterDAL.DbStartUp
{
    public static class InjectingDAL
    {
        public static void InjectDAL(
            this IServiceCollection services,
            IConfiguration configuration)
        {
            services.AddDbContext<DBContext>(options =>
            {
                options.UseSqlServer(
                    configuration["ConnectionString"]);
            });

            services.AddScoped(typeof(IBaseRepository<>), typeof(BaseRepository<>));
            services.AddScoped<IRequestsLogRepository, RequestsLogRepository>();
            services.AddScoped<IErrorLogRepository, ErrorLogRepository>();
        }
    }
}
