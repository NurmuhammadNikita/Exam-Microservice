using Authorization.API.DTOs;
using Authorization.API.JWT.Services;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace Authorization.API.Controllers
{
    [Route("api/[controller]/[action]")]
    [ApiController]
    public class AuthController : ControllerBase
    {
        private readonly JWTService jwtService;

        public AuthController(JWTService service)
        {
            jwtService = service;
        }

        [HttpPost]
        public async ValueTask<IActionResult> GetTokenAsync(LoginDto dto)
        {
            var token = jwtService.GenerateToken(dto);

            return Ok(token);
        }
    }
}
