using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Http;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.Logging;

namespace servicethree.Controllers
{
    [ApiController]
    [Route("[controller]")]
    public class MergeController : ControllerBase
    {
        private IConfiguration Configuration;
        public MergeController(IConfiguration configuration)
        {
            Configuration = configuration;
        }
        [HttpGet]
        public async Task<IActionResult> Get()
        {
            // var numbersService = $"https://{Configuration["numbersServiceURL"]}/numbers";
            var numbersService = $"http://numbers-service:81/numbers";
            var serviceOneResponseCall = await new HttpClient().GetStringAsync(numbersService);
            // var lettersService = $"https://{Configuration["lettersServiceURL"]}/letters";
            var lettersService = $"http://letters-service:82/letters";
            var serviceTwoResponseCall = await new HttpClient().GetStringAsync(lettersService);
            var mergedResponse = $"{serviceOneResponseCall}{serviceTwoResponseCall}";
            return Ok(mergedResponse);
        }
    }
}
