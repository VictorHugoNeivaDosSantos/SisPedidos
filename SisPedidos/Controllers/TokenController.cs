using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Configuration;
using Microsoft.IdentityModel.Tokens;
using SisPedidos.Model;
using System;
using System.Collections.Generic;
using System.IdentityModel.Tokens.Jwt;
using System.Linq;
using System.Security.Claims;
using System.Text;
using System.Threading.Tasks;

namespace SisPedidos.Controllers
{
    [Route("SisVendas/Token")]
    public class TokenController : Controller
    {
        private readonly IConfiguration _configuration;

        [HttpPost]

        public IActionResult GetToken([FromBody] User user)
        {
            if (user.UserName == "teste" && user.Password == "12345")
            {
                var claims = new[]
                {
                      new Claim(ClaimTypes.Name, user.UserName)
                };
                var key = new SymmetricSecurityKey(Encoding.UTF8.GetBytes(_configuration["SecurityKey"]));
                var credts = new SigningCredentials(key, SecurityAlgorithms.HmacSha256);

                token = new JwtSecurityTokenHandler().WriteToken(token);

            }





        }
    }
}
