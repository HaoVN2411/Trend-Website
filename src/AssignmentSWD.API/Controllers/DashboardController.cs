using AssignmentSWD.API.Service.Interfaces;
using AssignmentSWD.API.Service.Models.Dashboard;
using AssignmentSWD.API.Service.Service;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace AssignmentSWD.API.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class DashboardController : ControllerBase
    {
        private readonly IDashboardService _dashboardService;
        private readonly TrendService _trendService;

        public DashboardController(IDashboardService dashboardService, TrendService trendService)
        {
            _dashboardService = dashboardService;
            _trendService = trendService;
        }

        [HttpGet("/Get-Data-Chart-In-Year-By-Keyword")]
        public IActionResult GetAll(string? keyWordSearch, int? year)
        {
            var result = _dashboardService.GetListDataDashBoardByYear(keyWordSearch, year);
            return Ok(result);
        }

        [HttpGet("/Get-Top-10-Trend-By-Month")]
        public async Task<IActionResult> GetTop10TrendByMonth(DateTime date)
        {
            return Ok(await _trendService.GetTop10ByMonth(date));
        }
    }
}
