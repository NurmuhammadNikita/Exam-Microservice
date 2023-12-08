using General_Motors.Application.DTOs;
using General_Motors.Application.Services.BuyersService;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Rivendell_GameClub.Application.DTOs;
using Rivendell_GameClub.Application.Services.UsersService;
using Rivendell_GameClub.Domain.Tables.Entities;

namespace Rivendell_GameClub.API.Controllers
{
    [Route("api/[controller]/[action]")]
    [ApiController]
    public class UserController : ControllerBase
    {
        private readonly IUserService _service;

        public UserController(IUserService service)
        {
            _service = service;
        }

        [HttpGet]
        public async ValueTask<IActionResult> GetAllAsync()
        {
            IList<User> result = await _service.GetAllAsync();

            return Ok(result);

        }

        [HttpGet]
        public async ValueTask<IActionResult> GetByIdAsync(Guid id)
        {
            var result = await _service.GetByIdAsync(id);
            return Ok(result);
        }


        [HttpPost]
        public async ValueTask<IActionResult> CreateAsync([FromForm] UserDto dto)
        {
            var result = await _service.CreateAsync(dto);

            return Ok(result);
        }

        [HttpPut]
        public async ValueTask<IActionResult> UpdateAsync(Guid Id, [FromForm] UserDto dto)
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
