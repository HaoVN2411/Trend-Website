using AssignmentSWD.API.Service.Interfaces;
using AssignmentSWD.Infrastructure.Entities;
using AssignmentSWD.Infrastructure.Interfaces;
using AutoMapper;
using HaoVN.Template_3_layers.Service.Models.Trend;

namespace AssignmentSWD.API.Service.Service
{
    public class TrendService : ITrendService
    {
        private readonly IUnitOfWork _unitOfWork;
        private readonly IMapper _mapper;

        public TrendService(IUnitOfWork unitOfWork, IMapper mapper )
        {
            _unitOfWork = unitOfWork;
            _mapper = mapper;
        }

        public async Task<bool> CreateTrend(CreateTrendModel model)
        {
            var trendEntity = _mapper.Map<TrendEntity>(model);
            await _unitOfWork.Trends.Add(trendEntity);
            await _unitOfWork.CompletedAsync();
            return true;
        }
    }
}