using AssignmentSWD.API.Service.Interfaces;
using AssignmentSWD.API.Service.Models.Region;
using Microsoft.AspNetCore.Mvc;

namespace AssignmentSWD.API.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class RegionController : ControllerBase
    {
        private readonly IRegionService _regionService;

        public RegionController(IRegionService regionService)
        {
            _regionService = regionService;
        }

        [HttpGet("/Get-All-Region")]
        public async Task<IActionResult> GetAll()
        {
            return Ok(await _regionService.GetAll());
        }

        [HttpGet("{id}")]
        public async Task<IActionResult> GetById(string id)
        {
            return Ok(await _regionService.GetById(id));

        }

        [HttpPost]
        public async Task<IActionResult> CreateRegion([FromBody] CreateRegionModel createRegionModel)
        {
            await _regionService.CreateRegion(createRegionModel);
            return Ok("Create thanh cong");
        }

        [HttpDelete("{id}")]
        public async Task<IActionResult> DeleteRegion(string id)
        {
            await _regionService.DeleteRegion(id);
            return Ok("Delete thanh cong");
        }
    }
}
