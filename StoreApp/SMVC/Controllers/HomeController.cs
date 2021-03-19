using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;
using SBL;
using SModels;
using SMVC.Models;
using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Text.Json;
using System.Threading.Tasks;

namespace SMVC.Controllers
{
    public class HomeController : Controller
    {
        private readonly ILogger<HomeController> _logger;
        private IStoreBL _storeBL;

        public HomeController(IStoreBL storeBL, ILogger<HomeController> logger)
        {
            _storeBL = storeBL;
            _logger = logger;
        }

        public IActionResult Index()
        {
            return View();
        }
        public IActionResult IndexOrder()
        {
            Orders order = _storeBL.addNewOrder();
            HttpContext.Session.SetString("orderData", JsonSerializer.Serialize(order));
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
