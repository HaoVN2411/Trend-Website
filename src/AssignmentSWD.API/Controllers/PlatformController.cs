using AssignmentSWD.API.Service.Interfaces;
using AssignmentSWD.API.Service.Models.Platform;
using Microsoft.AspNetCore.Mvc;

namespace AssignmentSWD.API.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class PlatformController : ControllerBase
    {
        private readonly IPlatformService _platformService;

        public PlatformController(IPlatformService platformService)
        {
            _platformService = platformService;
        }

        [HttpGet("/Get-All-Platform")]
        public async Task<IActionResult> GetAll()
        {
            return Ok(await _platformService.GetAll());
        }

        [HttpGet("{id}")]
        public async Task<IActionResult> GetById(string id)
        {
            return Ok(await _platformService.GetById(id));
        }

        [HttpPost]
        public async Task<IActionResult> CreatePlatform([FromBody] CreatePlatformModel createPlatformModel)
        {
            await _platformService.CreatePlatform(createPlatformModel);
            return Ok("Create thanh cong");
        }

        [HttpDelete("{id}")]
        public async Task<IActionResult> Delete(string id)
        {
            await _platformService.DeletePlatform(id);
            return Ok("Delete thanh cong");
        }
    }
}
