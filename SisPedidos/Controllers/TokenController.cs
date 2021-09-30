using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Configuration;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace SisPedidos.Controllers
{
    [Route("SisVendas/Token")]
    public class TokenController : Controller
    {
        private readonly IConfiguration _configuration;

        [HttpPost]

        public IActionResult GetToken()
        {

        }
    }
}
