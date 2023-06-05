using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Http;

namespace WaetherForecasterBLL.Models
{
    public class ErrorLogModel
    {
        public string ErrorText { get; set; }
        public string MethodType { get; set; }
        public string EndpointName { get; set; }
    }
}
