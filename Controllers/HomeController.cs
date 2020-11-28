using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;
using ProyectoProgra.Models;

namespace ProyectoProgra.Controllers
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
 
        public IActionResult nosotros()
        {
            return View();
        }

        public IActionResult RegistrarUsu()
        {
            var model = new RegistrarUsu();
            model.District = " ";
            return View(model);            
        }

        [HttpPost]
        public IActionResult RegistrarUsu(RegistrarUsu registrarUsu)
        {
            if (ModelState.IsValid) 
            {
                // TODO: Hacer algo con los parámetros del objecto contacto
                return RedirectToAction("Index");
            }
            
            return View(registrarUsu);
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
