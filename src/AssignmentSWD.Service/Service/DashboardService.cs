using AssignmentSWD.API.Service.Interfaces;
using AssignmentSWD.API.Service.Models.Dashboard;
using AssignmentSWD.Infrastructure.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AssignmentSWD.API.Service.Service
{
    public class DashboardService : IDashboardService
    {
        private readonly IUnitOfWork _unitOfWork;

        public DashboardService(IUnitOfWork unitOfWork)
        {
            _unitOfWork = unitOfWork;
        }

        public List<DataDashboardByYear> GetListDataDashBoardByYear(string? keywordSearch, int? year)
        {

            var test = _unitOfWork.Searchs.GetAll().Result.FirstOrDefault().CreatedTime.Value.Year;

            var listDataDashBoard = new List<DataDashboardByYear>();
            var listDashboardInYearOfKeyword = _unitOfWork.Searchs.Get(_ => 
            (_.Keyword.Equals(keywordSearch) || keywordSearch == null)
            && (_.CreatedTime.Value.Year == year || year == null));
            foreach (var item in listDashboardInYearOfKeyword)
            {
                listDataDashBoard.Add(new DataDashboardByYear()
                {
                    Count = item.Count ?? 0,
                    Month = item.CreatedTime.Value.Month
                });
            }
            return listDataDashBoard;
        }
    }
}
