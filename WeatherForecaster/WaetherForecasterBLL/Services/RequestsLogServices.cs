using AutoMapper;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using WaetherForecasterBLL.Interfaces;
using WaetherForecasterBLL.Models;
using WeatherForecasterDAL.Entities;
using WeatherForecasterDAL.Repository.Interfaces;

namespace WaetherForecasterBLL.Services
{
    public class RequestsLogServices : IRequestsLogServices
    {
        private readonly IRequestsLogRepository _requestsRepository;
        private readonly IMapper _mapper;

        public RequestsLogServices(IRequestsLogRepository requestsRepository, IMapper mapper)
        {
            _requestsRepository = requestsRepository;
            _mapper = mapper;
        }

        public async Task AddRequests(RequestsLogModel request)
        {
            var mapped = _mapper.Map<RequestsLog>(request);
            await _requestsRepository.AddAsync(mapped);
        }
    }
}
