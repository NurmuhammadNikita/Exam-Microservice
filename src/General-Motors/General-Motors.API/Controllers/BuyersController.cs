using General_Motors.Application.DTOs;
using General_Motors.Application.Services.BuyersService;
using General_Motors.Domain.Tables.Entities;
using General_Motors.Infrastructure.DataAccess;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;

namespace General_Motors.API.Controllers
{
    [Route("api/[controller]/[action]")]
    [ApiController]
    public class BuyersController : ControllerBase
    {
        private readonly IBuyerService _service;

        public BuyersController(IBuyerService service)
        {
            _service = service;   
        }

        [HttpGet]
        public async ValueTask<IActionResult> GetAllAsync()
        {
            IList<Buyer> result = await _service.GetAllAsync();

            return Ok(result);

        }

        [HttpGet]
        public async ValueTask<IActionResult> GetByIdAsync( Guid id)
        {
            var result = await _service.GetByIdAsync(id);
            return Ok(result);
        }


        [HttpPost]
        public async ValueTask<IActionResult> CreateAsync([FromForm]BuyerDto dto)
        {
           var result = await _service.CreateAsync(dto);

            return Ok(result);
        }

        [HttpPut]
        public async ValueTask<IActionResult> UpdateAsync(Guid Id,[FromForm] BuyerDto dto)
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
