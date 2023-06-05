using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WeatherForecasterDAL.DbStartUp
{
    public static class DbInitializer
    {
        public static void Initialize(DBContext context) 
        {
            context.Database.EnsureCreated();
        }
    }
}
