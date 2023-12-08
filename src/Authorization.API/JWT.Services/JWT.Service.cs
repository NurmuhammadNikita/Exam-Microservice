using Authorization.API.DTOs;
using Microsoft.IdentityModel.Tokens;
using System.IdentityModel.Tokens.Jwt;
using System.Security.Claims;
using System.Text;

namespace Authorization.API.JWT.Services
{
    public class JWTService
    {
        public string GenerateToken(LoginDto dto)
        {
            SecurityKey secretKey = new SymmetricSecurityKey(Encoding.UTF8.GetBytes("NurmuhammadSharobiddinovMuzaffarovichNikitaConsolidated"));

            SigningCredentials signingCredentials = new SigningCredentials(secretKey, SecurityAlgorithms.HmacSha256);

            List<Claim> claims = new List<Claim>()
            {
                new Claim(ClaimTypes.Role,"User")
            };
            var token = new JwtSecurityToken(
                issuer: "Nikita",
                audience: "Nikita",
                claims: claims,
                expires: DateTime.Now.AddMinutes(1),
                signingCredentials: signingCredentials
                );
            return new JwtSecurityTokenHandler().WriteToken(token);

            
        }
    }
}
