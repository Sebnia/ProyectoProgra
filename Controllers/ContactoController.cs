using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;
using Microsoft.AspNetCore.Mvc.Rendering;
using Microsoft.EntityFrameworkCore;
using ProyectoProgra.Models;
using ProyectoProgra.Data;

namespace ProyectoProgra.Controllers
{
    public class ContactoController : Controller
    {

       private readonly ILogger<ContactoController> _logger;
       private readonly ApplicationDbContext _context;


        public ContactoController(ILogger<ContactoController> logger,
            ApplicationDbContext context)
        {
            _logger = logger;
            _context = context;
        }

        public IActionResult contactenos()
        {
            
            return View();
        }

        [HttpPost]
        public IActionResult Registrar(Contacto objContacto){
            if (ModelState.IsValid)
            {
                _context.Add(objContacto);
                _context.SaveChanges();
                objContacto.Response = "Gracias estamos en contacto";
            }
            return View("contactenos", objContacto);
        }

    }
}