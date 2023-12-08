
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Rivendell_GameClub.Application.DTOs;
using Rivendell_GameClub.Application.Services.PaymentsService;
using Rivendell_GameClub.Domain.Tables.Models;

namespace Rivendell_GameClub.API.Controllers
{
    [Route("api/[controller]/[action]")]
    [ApiController]
    public class PaymentController : ControllerBase
    {
        private readonly IPaymentService _service;

        public PaymentController(IPaymentService service)
        {
            _service = service;
        }

        [HttpGet]
        public async ValueTask<IActionResult> GetAllAsync()
        {
            IList<Payment> result = await _service.GetAllAsync();

            return Ok(result);

        }

        [HttpGet]
        public async ValueTask<IActionResult> GetByIdAsync(Guid id)
        {
            var result = await _service.GetByIdAsync(id);
            return Ok(result);
        }


        [HttpPost]
        public async ValueTask<IActionResult> CreateAsync([FromForm] PaymentDto dto)
        {
            var result = await _service.CreateAsync(dto);

            return Ok(result);
        }

        [HttpPut]
        public async ValueTask<IActionResult> UpdateAsync(Guid Id, [FromForm] PaymentDto dto)
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
