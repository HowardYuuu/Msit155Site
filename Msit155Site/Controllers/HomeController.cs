﻿using Microsoft.AspNetCore.Mvc;
using Msit155Site.Models;
using System.Diagnostics;

namespace Msit155Site.Controllers
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
            return View();
        }

        public IActionResult First()
        {
            return View();
        }

        public IActionResult JsonTest()
        {
            return View();
        }

        public IActionResult Register() 
        {
            return View();
        }

        public IActionResult Avatar()
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

        public IActionResult Address()
        {
            return View();
        }
    }
}
