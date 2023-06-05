using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Net;
using Microsoft.AspNetCore.Http;

namespace WaetherForecasterBLL.Models
{
    public class RequestsLogModel
    {
        public string MethodType { get; set; }
        public string EndpointName { get; set; }
    }
}
