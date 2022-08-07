using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;
using NlogPro.Models;
using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Threading.Tasks;

namespace NlogPro.Controllers
{
    public class HomeController : Controller
    {
        private readonly ILogger<HomeController> _logger;

        public HomeController(ILogger<HomeController> logger)
        {
            _logger = logger;
        }

        public IActionResult Index()
        {
        //    Sum(5, 6);
            for (int i = 0; i < 250000; i++)
            {
                _logger.LogInformation($"test log {i}");
            }
            return View();
        }

        public IActionResult Privacy()
        {
            return View();
        }

        [ResponseCache(Duration = 0, Location = ResponseCacheLocation.None, NoStore = true)]
        public IActionResult Error()
        {
            return View(new ErrorViewModel { RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier });
        }

        private int Sum(int a, int b)
        {
            try
            {
                _logger.LogTrace("Enter Sum");
                _logger.LogDebug($"a={a} and b={b}");

                int c = a + b;

                _logger.LogInformation("sum method run");

                return c;
            }
            catch (Exception ex)
            {
                _logger.LogError("error", ex);

                throw;
            }

        }

    }
}
