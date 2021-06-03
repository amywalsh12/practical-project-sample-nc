using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;
using frontend.Models;
using System.Net.Http;

namespace frontend.Controllers
{
    public class HomeController : Controller
    {
        private readonly ILogger<HomeController> _logger;

        public HomeController(ILogger<HomeController> logger)
        {
            _logger = logger;
        }

        public async Task<IActionResult> Index()
        {
            var serviceThree = "http://merge-service:7993/merge";
            var serviceThreeResponseCall = await new HttpClient().GetStringAsync(serviceThree);
            return View(serviceThreeResponseCall);
        }
    }
}
