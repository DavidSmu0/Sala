using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;
using Sala_de_escape.Models;

namespace Sala_de_escape.Controllers
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


        public IActionResult PrimerPregunta()
        {
            return View();
        }

        [HttpPost]
        public IActionResult PrimerPregunta(int R1P)
        {
            if (R1P==1911)
            {
                return View("RespuestaOK");
            } else 
            {
                return View("RespuestaFalla");
            }
        }

        // public ActionResult PR1(int R1)
        // {
            
        // }

        [ResponseCache(Duration = 0, Location = ResponseCacheLocation.None, NoStore = true)]
        public IActionResult Error()
        {
            return View(new ErrorViewModel { RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier });
        }
    }
}
