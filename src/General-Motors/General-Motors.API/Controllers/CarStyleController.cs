using General_Motors.Application.DTOs;
using General_Motors.Application.Services.CarsService;
using General_Motors.Application.Services.CarStylesService;
using General_Motors.Domain.Tables.Models;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace General_Motors.API.Controllers
{
    [Route("api/[controller]/[action]")]
    [ApiController]
    public class CarStyleController : ControllerBase
    {
        private readonly ICarStyleService _service;

        public CarStyleController(ICarStyleService service)
        {
            _service = service;
        }

        [HttpGet]
        public async ValueTask<IActionResult> GetAllAsync()
        {
            IList<CarStyle> result = await _service.GetAllAsync();

            return Ok(result);

        }

        [HttpGet]
        public async ValueTask<IActionResult> GetByIdAsync(Guid id)
        {
            var result = await _service.GetByIdAsync(id);
            return Ok(result);
        }


        [HttpPost]
        public async ValueTask<IActionResult> CreateAsync([FromForm] CarStyleDto dto)
        {
            var result = await _service.CreateAsync(dto);

            return Ok(result);
        }

        [HttpPut]
        public async ValueTask<IActionResult> UpdateAsync(Guid Id, [FromForm] CarStyleDto dto)
        {
            var result = await _service.UpdateAsync(Id, dto);

            return Ok(result);
        }

        [HttpDelete]

        public async ValueTask<IActionResult> DeleteAsync(Guid Id)
        {
            var result = (_service.DeleteAsync(Id));

            return Ok(result);
        }
    }
}
