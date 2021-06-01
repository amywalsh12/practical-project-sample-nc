using System;
using System.Collections.Generic;
using System.Linq;
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
        public async IActionResult Get()
        {
            var serviceOne = "https://serviceone/numbers";
            var serviceOneResponseCall = await new HttpClient().GetAsStringAsync(serviceOne);
            var serviceTwo = "https://servicetwo/letters";
            var serviceTwoResponseCall = await new HttpClient().GetAsStringAsync(serviceTwo);
            var mergedResponse = $"{serviceOneResponseCall}{serviceTwoResponseCall}";
            return Ok(mergedResponse);
        }
    }
}
