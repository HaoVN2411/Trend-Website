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

    }
}
