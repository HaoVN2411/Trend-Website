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
        private readonly ISearchService _searchService;

        public DashboardController(IDashboardService dashboardService, ISearchService searchService)
        {
            _dashboardService = dashboardService;
            _searchService = searchService;
        }

        [HttpGet("/Get-Data-Chart-In-Year-By-Keyword")]
        public IActionResult GetAll(string? keyWordSearch, int? year)
        {
            var result = _dashboardService.GetListDataDashBoardByYear(keyWordSearch, year);
            return Ok(result);
        }

        [HttpGet("/Get-Top-10-Keyword-This-Month")]
        public IActionResult GetTop10KeyWorkInMonth(string? keyWordSearch, int? year)
        {
            var result = _searchService.GetTop10SearchKeywork();
            return Ok(result);
        }

    }
}
