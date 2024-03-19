using AssignmentSWD.API.Service.Interfaces;
using AssignmentSWD.API.Service.Models.Type;
using Microsoft.AspNetCore.Mvc;

namespace AssignmentSWD.API.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class TypeController : ControllerBase
    {
        private readonly ITypeService _typeService;

        public TypeController(ITypeService typeService)
        {
            _typeService = typeService;
        }

        [HttpGet("/Get-All-Type")]
        public async Task<IActionResult> GetAll()
        {
            return Ok(await _typeService.GetAll());
        }

        [HttpGet("{id}")]
        public async Task<IActionResult> GetById(string id)
        {
            return Ok(await _typeService.GetById(id));
        }

        [HttpPost]
        public async Task<IActionResult> CreateType([FromBody] CreateTypeModel createTypeModel)
        {
            await _typeService.CreateType(createTypeModel);
            return Ok("Create thanh cong");
        }

        [HttpDelete("{id}")]
        public async Task<IActionResult> Delete(string id)
        {
            await _typeService.DeleteType(id);
            return Ok("Delete thanh cong");
        }
    }
}
