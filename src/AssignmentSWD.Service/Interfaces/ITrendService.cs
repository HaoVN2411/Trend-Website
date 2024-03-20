using AssignmentSWD.API.Service.Models.Trend;
using AssignmentSWD.Infrastructure.Entities;
using HaoVN.Template_3_layers.Service.Models.Trend;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AssignmentSWD.API.Service.Interfaces
{
    public interface ITrendService
    {
        public Task<bool> CreateTrend(CreateTrendModel model);
        public Task<IEnumerable<TrendEntity>> GetAll();
        public Task<TrendEntity> GetById(string id);
        public Task<IEnumerable<TrendEntity>> SuggestTrend(string keyword);
        public Task<TrendEntity> SearchTrend(string keyword);
        public Task<IEnumerable<TrendEntity>> GetTop10();
        public Task<IEnumerable<TrendEntity>> GetTop10ByMonth();
        public Task<IEnumerable<TrendEntity>> Filter(FilterModel filter);
    }
}
