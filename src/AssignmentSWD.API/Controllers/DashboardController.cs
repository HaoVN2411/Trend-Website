using AssignmentSWD.API.Service.Interfaces;
using AssignmentSWD.API.Service.Models.Dashboard;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace AssignmentSWD.API.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class DashboardController : ControllerBase
    {
        private readonly IDashboardService _dashboardService;

        public DashboardController(IDashboardService dashboardService)
        {
            _dashboardService = dashboardService;
        }

        [HttpGet("/Get-Data-Chart-In-Year-By-Keyword")]
        public IActionResult GetAll(string? keyWordSearch, int? year)
        {
            var result = _dashboardService.GetListDataDashBoardByYear(keyWordSearch, year);
            return Ok(result);
        }

    }
}
