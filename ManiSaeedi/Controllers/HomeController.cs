using ManiSaeedi.Models;
using ManiSaeedi.Models.Context;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;
using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Threading.Tasks;

namespace ManiSaeedi.Controllers
{
    public class HomeController : Controller
    {
        private readonly ILogger<HomeController> _logger;
        private readonly ManiContext _maniContext;

        public HomeController(ILogger<HomeController> logger, ManiContext maniContext)
        {
            _logger = logger;
            _maniContext = maniContext;
        }

        public IActionResult Index()
        {
            ViewBag.AboutMe = _maniContext.AboutMe.First();
            return View();
        }
    }
}
