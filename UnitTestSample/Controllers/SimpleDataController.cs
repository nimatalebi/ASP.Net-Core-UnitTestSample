using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using UnitTestSample.Infra.Abstract;

namespace UnitTestSample.Controllers
{
    public class SimpleDataController : Controller
    {
        private readonly ISimpleDataService _simpleDataService;

        public SimpleDataController(ISimpleDataService simpleDataService)
        {
            _simpleDataService = simpleDataService;
        }

        public async Task<IActionResult> Index()
        {
            return View(await _simpleDataService.GetAll());
        }
    }
}
