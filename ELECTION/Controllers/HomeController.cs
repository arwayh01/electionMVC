using ELECTION.Models;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;
using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Threading.Tasks;

namespace ELECTION.Controllers
{
    [Authorize]
    public class HomeController : Controller
    {
        private readonly ILogger<HomeController> _logger;

        public HomeController(ILogger<HomeController> logger)
        {
            _logger = logger;
        }
        
        public IActionResult Index()
        {
            ModelDashboardView dashboard = new ModelDashboardView();

            dashboard.femme_count = 60;  
            dashboard.homme_count = 40;
            dashboard.centre_count = 30;
            dashboard.sud_count = 20;
            dashboard.Nord_count = 50;
            dashboard.sfax_count = 25;
            dashboard.tunis_count = 40;
            dashboard.sousse_count = 35;
            
            return View(dashboard);
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
