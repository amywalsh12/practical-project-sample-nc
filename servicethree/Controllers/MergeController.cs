using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Http;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;

namespace servicethree.Controllers
{
    [ApiController]
    [Route("[controller]")]
    public class MergeController : ControllerBase
    {
        [HttpGet]
        public async Task<IActionResult> Get()
        {
            var numbersService = "https://numbers-service/numbers";
            var serviceOneResponseCall = await new HttpClient().GetStringAsync(numbersService);
            var lettersService = "https://letters-service/letters";
            var serviceTwoResponseCall = await new HttpClient().GetStringAsync(lettersService);
            var mergedResponse = $"{serviceOneResponseCall}{serviceTwoResponseCall}";
            return Ok(mergedResponse);
        }
    }
}
