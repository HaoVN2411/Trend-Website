using AssignmentSWD.API.Service.Interfaces;
using AssignmentSWD.API.Service.Models.Search;
using AssignmentSWD.Infrastructure.Entities;
using AssignmentSWD.Infrastructure.Interfaces;
using AutoMapper;

namespace AssignmentSWD.API.Service.Service
{
    public class SearchService : ISearchService
    {
        private readonly IUnitOfWork _unitOfWork;
        private readonly IMapper _mapper;

        public SearchService(IUnitOfWork unitOfWork, IMapper mapper)
        {
            _unitOfWork = unitOfWork;
            _mapper = mapper;
        }

        public List<ResponseSearchModel> GetTop10SearchKeywork()
        {
            var timeNow = DateTime.Now;
            var top10SearchKeywork = _unitOfWork.Searchs.Get(x => x.CreatedTime.Value.Month == timeNow.Month
            , x => x.OrderByDescending(_ => _.Count)
            ,"", null, null, 10);
            return _mapper.Map<List<ResponseSearchModel>>(top10SearchKeywork.ToList());
        }
    }
}
