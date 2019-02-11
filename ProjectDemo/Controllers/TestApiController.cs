using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Hosting;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace ProjectDemo.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class TestApiController : ControllerBase
    {
        IHostingEnvironment _env;

        public TestApiController(IHostingEnvironment env)
        {
            _env = env;
        }

        [HttpGet("GetEnvironment")]
        public string GetEnvironment()
        {
            return _env.EnvironmentName + " environment";
        }

        [HttpGet("GetDiscount/{monto}")]
        public decimal GetDiscount(decimal monto)
        {
            decimal disc = 0;
            if (_env.IsDevelopment())
            {
                disc = monto * 0.2m;
            }
            if (_env.IsStaging() || _env.IsProduction())
            {
                disc = monto * 0.3m;
            }
            return disc;
        }
    }
}