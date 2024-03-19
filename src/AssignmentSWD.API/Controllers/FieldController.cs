using AssignmentSWD.API.Service.Interfaces;
using AssignmentSWD.API.Service.Models.Field;
using AssignmentSWD.API.Service.Service;
using HaoVN.Template_3_layers.Service.Models.Trend;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace AssignmentSWD.API.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class FieldController : ControllerBase
    {
        private readonly IFieldService _fieldService;

        public FieldController(IFieldService fieldService)
        {
            _fieldService = fieldService;
        }

        [HttpGet("/Get-All-Field")]
        public async Task<IActionResult> GetAll()
        {
            return Ok(await _fieldService.GetAll());
        }

        [HttpGet("{id}")]
        public async Task<IActionResult> GetById(string id)
        {
            return Ok(await _fieldService.GetById(id));

        }

        [HttpPost]
        public async Task<IActionResult> CreateField([FromBody] CreateFieldModel createFieldModel)
        {
            await _fieldService.CreateField(createFieldModel);
            return Ok("Create thanh cong");
        }

        [HttpDelete("{id}")]
        public async Task<IActionResult> Delete(string id)
        {
            await _fieldService.DeleteField(id);
            return Ok("Delete thanh cong");
        }
    }
}
