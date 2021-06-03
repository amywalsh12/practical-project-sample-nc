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
            var serviceOne = "http://numbers-service:7991/numbers";
            var serviceOneResponseCall = await new HttpClient().GetStringAsync(serviceOne);
            var serviceTwo = "http://letters-service:7992/letters";
            var serviceTwoResponseCall = await new HttpClient().GetStringAsync(serviceTwo);
            var mergedResponse = $"{serviceOneResponseCall}{serviceTwoResponseCall}";
            return Ok(mergedResponse);
        }
    }
}
