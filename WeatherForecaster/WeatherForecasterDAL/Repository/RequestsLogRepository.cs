using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using WeatherForecasterDAL.DbStartUp;
using WeatherForecasterDAL.Entities;
using WeatherForecasterDAL.Repository.Interfaces;

namespace WeatherForecasterDAL.Repository
{
    public class RequestsLogRepository : BaseRepository<RequestsLog>, IRequestsLogRepository
    {
        public RequestsLogRepository(DBContext context) : base(context) { }
    }
}
