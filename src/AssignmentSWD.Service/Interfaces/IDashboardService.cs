using AssignmentSWD.API.Service.Models.Dashboard;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AssignmentSWD.API.Service.Interfaces
{
    public interface IDashboardService
    {
        public List<DataDashboardByYear> GetListDataDashBoardByYear(string? keywordSearch, int? year);
    }
}
