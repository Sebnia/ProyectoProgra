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
    public class CatalogoController : Controller
    {

       private readonly ILogger<CatalogoController> _logger;
       private readonly ApplicationDbContext _context;


        public CatalogoController(ILogger<CatalogoController> logger,
            ApplicationDbContext context)
        {
            _logger = logger;
            _context = context;
        }


        public IActionResult Index()
        { 
            var productos = _context.Productos.ToList();

            return View(productos);
        }

    }
}