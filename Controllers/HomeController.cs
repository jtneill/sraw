using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNet.Mvc;
using Serilog;
using Microsoft.Extensions.Logging;

namespace WebApplicationBasic.Controllers
{
    public class HomeController : Controller
    {
        ILogger<HomeController> _log;
        public HomeController(ILogger<HomeController> logger)
        {
            _log = logger;
        }

        public IActionResult Index()
        {
            _log.LogInformation("testing home controller logs");
            return View();
        }

        public IActionResult About()
        {
            ViewData["Message"] = "Your application description page.";

            return View();
        }

        public IActionResult Contact()
        {
            ViewData["Message"] = "Your contact page.";

            return View();
        }

        public IActionResult Error()
        {
            return View();
        }
    }
}
