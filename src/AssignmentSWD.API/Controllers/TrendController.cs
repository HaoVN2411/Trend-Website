using AssignmentSWD.API.Service.Interfaces;
using AssignmentSWD.API.Service.Models.Trend;
using AssignmentSWD.Infrastructure.Entities;
using HaoVN.Template_3_layers.Service.Models.Trend;
using Microsoft.AspNetCore.Mvc;

// For more information on enabling Web API for empty projects, visit https://go.microsoft.com/fwlink/?LinkID=397860

namespace AssignmentSWD.API.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class TrendController : ControllerBase
    {
        private readonly ITrendService _trendService;

        public TrendController(ITrendService trendService)
        {
            _trendService = trendService;
        }
        // GET: api/<TrendController>
        [HttpGet("/Get-All-Trend")]
        public async Task<IActionResult> GetAll()
        {
            return Ok(await _trendService.GetAll());
        }

        // GET api/<TrendController>/5
        [HttpGet("{id}")]
        public async Task<IActionResult> GetById(string id)
        {
            return Ok(await _trendService.GetById(id));
        }

        // POST api/<TrendController>
        [HttpPost]
        public async Task<IActionResult> CreateTrend([FromBody] CreateTrendModel createTrendModel)
        {
            await _trendService.CreateTrend(createTrendModel);
            return Ok("Create thanh cong");
        }

        // PUT api/<TrendController>/5
        [HttpPut("{id}")]
        public void Put(int id, [FromBody] string value)
        {
        }

        // DELETE api/<TrendController>/5
        [HttpDelete("{id}")]
        public void Delete(string id)
        {
        }

        [HttpGet("/SuggestTrend")]
        public async Task<IActionResult> SuggestTrend(string keyword)
        {
            return Ok(await _trendService.SuggestTrend(keyword));
        }

        [HttpGet("/SearchTrend")]
        public async Task<IActionResult> SearchTrend(string keyword)
        {
            return Ok(await _trendService.SearchTrend(keyword));
        }

        [HttpGet("/Get-Top-10-Trend")]
        public async Task<IActionResult> GetTop10Trend()
        {
            return Ok(await _trendService.GetTop10());
        }

        //[HttpGet("/Get-Top-10-Trend-By-Month")]
        //public async Task<IActionResult> GetTop10TrendByMonth(DateTime date)
        //{
        //    return Ok(await _trendService.GetTop10ByMonth(date));
        //}

        [HttpGet("/Filter")]
        public async Task<IActionResult> FilterTrend([FromQuery] FilterModel filter)
        {
            var filteredTrends = await _trendService.Filter(filter);
            return Ok(filteredTrends);
        }
    }
}
