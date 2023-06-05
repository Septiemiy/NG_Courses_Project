using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WeatherForecasterDAL.Entities
{
    public class RequestsLog : BaseEntity
    {
        public string MethodType { get; set; }
        public string EndpointName { get; set; }

    }
}
