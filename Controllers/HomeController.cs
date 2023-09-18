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

        public IActionResult SegundaPregunta()
        {
            return View();
        }

        public IActionResult TercerPregunta()
        {
            return View();
        }

        [HttpPost]
        public IActionResult SegundaPregunta(string R2P)
        {
            string respuestacorrecta;
            respuestacorrecta="RAMOS";
            if (R2P==respuestacorrecta)
            {
                return View("RespuestaOK2");
            } else 
            {
                return View("RespuestaFalla2");
            }
        }

        [HttpPost]
        public IActionResult TercerPregunta(string R3P)
        {
            string respuestacorrecta;
            respuestacorrecta="Marcelo Bielsa";
            if (R3P==respuestacorrecta)
            {
                return View("RespuestaOK3");
            } else 
            {
                return View("RespuestaFalla3");
            }
        }


        [HttpPost]
        public IActionResult PrimerPregunta(int R1P)
        {
            if (R1P==1911)
            {
                return View("RespuestaOK1");
            } else 
            {
                return View("RespuestaFalla1");
            }
        }

        public IActionResult RespuestaFalla1()
        {
            return View();
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
