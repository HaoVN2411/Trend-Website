using AssignmentSWD.API.Service.Interfaces;
using AssignmentSWD.API.Service.Models.Trend;
using AssignmentSWD.Core.EnumCore;
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

        public TrendService(IUnitOfWork unitOfWork, IMapper mapper)
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

        public async Task<IEnumerable<TrendEntity>> GetAll()
        {
            return await _unitOfWork.Trends.GetAll();
        }

        public async Task<TrendEntity> GetById(string id)
        {
            return await _unitOfWork.Trends.GetById(id);
        }

        public async Task<IEnumerable<TrendEntity>> SuggestTrend(string keyword)
        {
            var trends = _unitOfWork.Trends.Find(_ => _.Title.Contains(keyword) || _.Content.Contains(keyword));
            return trends.ToList();
        }

        public async Task<TrendEntity> SearchTrend(string keyword)
        {
            var trend = _unitOfWork.Trends.Find(_ => _.Title.Equals(keyword)).FirstOrDefault();
            if (trend != null)
            {
                var searched = _unitOfWork.Searchs.Find(_ => _.Keyword.Equals(keyword)).FirstOrDefault();
                if (searched == null)
                {
                    searched = new SearchEntity { Keyword = keyword, Count = 1 };
                    await _unitOfWork.Searchs.Add(searched);
                }
                else
                {
                    searched.Count++;
                    _unitOfWork.Searchs.Update(searched);
                }
                await _unitOfWork.CompletedAsync();
            }
            return trend;
        }

        public async Task<IEnumerable<TrendEntity>> GetTop10()
        {
            var top10Searches = await _unitOfWork.Searchs.GetAll();
            top10Searches = top10Searches.OrderByDescending(s => s.Count).Take(2).ToList(); //đổi thành 2 để dễ test

            var top10Trends = new List<TrendEntity>();
            foreach (var search in top10Searches)
            {
                var trend = _unitOfWork.Trends.Find(t => t.Title == search.Keyword).FirstOrDefault();
                if (trend != null)
                {
                    top10Trends.Add(trend);
                }
            }
            return top10Trends;
        }

        public async Task<IEnumerable<TrendEntity>> GetTop10ByMonth(DateTime date)
        {
            var startDate = new DateTime(date.Year, date.Month, 1);
            var endDate = startDate.AddMonths(1).AddDays(-1);

            var top10Searches = _unitOfWork.Searchs.Find(search => search.CreatedTime >= startDate && search.CreatedTime <= endDate);

            top10Searches = top10Searches.OrderByDescending(s => s.Count).Take(10).ToList();

            var top10Trends = new List<TrendEntity>();
            foreach (var search in top10Searches)
            {
                var trend = _unitOfWork.Trends.Find(t => t.Title == search.Keyword).FirstOrDefault();
                if (trend != null)
                {
                    top10Trends.Add(trend);
                }
            }
            return top10Trends;
        }

        public async Task<IEnumerable<TrendEntity>> Filter(FilterModel filter)
        {
            var filteredTrends = _unitOfWork.Trends.Get(_ => 
            (_.Region.RegionName.Equals(filter.RegionName) || filter.RegionName == null)
            && (_.CreatedTime >= filter.StartDate || filter.StartDate == null) 
            && (_.CreatedTime <= filter.EndDate || filter.EndDate == null) 
            && (filter.FieldName.Equals(_.Field.FieldName) || filter.FieldName == null) 
            && (filter.PlatformName.Equals(_.Field.FieldName) || filter.PlatformName == null));
            return filteredTrends.ToList();
        }

        //private DateTime GetStartDate(PeriodEnum period)
        //{
        //    return period switch
        //    {
        //        PeriodEnum.Today => DateTime.Today,
        //        PeriodEnum.LastWeek => DateTime.Today.AddDays(-7),
        //        PeriodEnum.LastMonth => DateTime.Today.AddMonths(-1),
        //        PeriodEnum.LastYear => DateTime.Today.AddYears(-1),
        //        _ => throw new ArgumentException("Invalid period specified"),
        //    };
        //}
    }
}