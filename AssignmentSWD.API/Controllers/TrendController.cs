using AssignmentSWD.API.Service.Interfaces;
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
        [HttpGet]
        public IEnumerable<string> Get()
        {
            return new string[] { "value1", "value2" };
        }

        // GET api/<TrendController>/5
        [HttpGet("{id}")]
        public string Get(int id)
        {
            return "value";
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
        public void Delete(int id)
        {
        }
    }
}
