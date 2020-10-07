using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;
using UnitTestSample.Infra.Abstract;
using UnitTestSample.Models;

namespace UnitTestSample.Controllers
{
    public class HomeController : Controller
    {
        private readonly ISimpleDataService _simpleDataService;

        public HomeController(ISimpleDataService simpleDataService)
        {
            _simpleDataService = simpleDataService;
        }

        public IActionResult Index()
        {
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
    }
}
