using General_Motors.Application.DTOs;
using General_Motors.Application.Services.BuyersService;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Rivendell_GameClub.Application.DTOs;
using Rivendell_GameClub.Application.Services.ComputersService;
using Rivendell_GameClub.Domain.Tables.Models;

namespace Rivendell_GameClub.API.Controllers
{
    [Route("api/[controller]/[action]")]
    [ApiController]
    public class ComputerController : ControllerBase
    {
        private readonly IComputerService _service;

        public ComputerController(IComputerService service)
        {
            _service = service;
        }

        [HttpGet]
        public async ValueTask<IActionResult> GetAllAsync()
        {
            IList<Computer> result = await _service.GetAllAsync();

            return Ok(result);

        }

        [HttpGet]
        public async ValueTask<IActionResult> GetByIdAsync(Guid id)
        {
            var result = await _service.GetByIdAsync(id);
            return Ok(result);
        }


        [HttpPost]
        public async ValueTask<IActionResult> CreateAsync([FromForm] ComputerDto dto)
        {
            var result = await _service.CreateAsync(dto);

            return Ok(result);
        }

        [HttpPut]
        public async ValueTask<IActionResult> UpdateAsync(Guid Id, [FromForm] ComputerDto dto)
        {
            var result = _service.UpdateAsync(Id, dto);

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
