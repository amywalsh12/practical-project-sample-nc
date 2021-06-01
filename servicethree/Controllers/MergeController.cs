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
            //var serviceOne = "http://serviceone/numbers";
            var serviceOne = "https://localhost:44397/numbers";
            var serviceOneResponseCall = await new HttpClient().GetStringAsync(serviceOne);
            //var serviceTwo = "https://localhost:44306/letters";
            var serviceTwo = "http://servicetwo/letters";
            var serviceTwoResponseCall = await new HttpClient().GetStringAsync(serviceTwo);
            var mergedResponse = $"{serviceOneResponseCall}{serviceTwoResponseCall}";
            return Ok(mergedResponse);
        }
    }
}
