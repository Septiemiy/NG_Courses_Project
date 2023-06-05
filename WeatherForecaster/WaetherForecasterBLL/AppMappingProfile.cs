using AutoMapper;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using WaetherForecasterBLL.Models;
using WeatherForecasterDAL.Entities;

namespace WaetherForecasterBLL
{
    public class AppMappingProfile : Profile
    {
        public AppMappingProfile() 
        {
            CreateMap<ErrorLogModel, ErrorLog>()
                .ForMember(errorLogModel => errorLogModel.ErrorText,
                opt => opt.MapFrom(errorLog => errorLog.ErrorText))
                .ForMember(errorLogModel => errorLogModel.MethodType,
                opt => opt.MapFrom(errorLog => errorLog.MethodType))
                .ForMember(errorLogModel => errorLogModel.EndpointName,
                opt => opt.MapFrom(errorLog => errorLog.EndpointName));

            CreateMap<ErrorLog, ErrorLogModel>()
                .ForMember(errorLog => errorLog.ErrorText,
                opt => opt.MapFrom(errorLogModel => errorLogModel.ErrorText))
                .ForMember(errorLog => errorLog.MethodType,
                opt => opt.MapFrom(errorLogModel => errorLogModel.MethodType))
                .ForMember(errorLog => errorLog.EndpointName,
                opt => opt.MapFrom(errorLogModel => errorLogModel.EndpointName));

            CreateMap<RequestsLogModel, RequestsLog>()
                .ForMember(requestsLogModel => requestsLogModel.MethodType,
                opt => opt.MapFrom(requestsLog => requestsLog.MethodType))
                .ForMember(requestsLogModel => requestsLogModel.EndpointName,
                opt => opt.MapFrom(requestsLog => requestsLog.EndpointName));

            CreateMap<RequestsLog, RequestsLogModel>()
                .ForMember(requestsLog => requestsLog.MethodType,
                opt => opt.MapFrom(requestsLogModel => requestsLogModel.MethodType))
                .ForMember(requestsLog => requestsLog.EndpointName,
                opt => opt.MapFrom(requestsLogModel => requestsLogModel.EndpointName));
        }
    }
}
