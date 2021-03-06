﻿using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;
using ProyectoProgra.Data;
using ProyectoProgra.Models;

namespace ProyectoProgra.Controllers
{
    public class HomeController : Controller
    {
        private readonly ILogger<HomeController> _logger;
        private readonly ApplicationDbContext _context;

        

        public HomeController(ILogger<HomeController> logger,  ApplicationDbContext context)
        {
            
            _context = context;
            _logger = logger;
        }

        public IActionResult Index()
        {

            var productos = _context.Productos.OrderByDescending(x=>x.ID).Take(6).ToList();
            return View(productos);
        }
        public IActionResult productos()
        {
            return View();
        }
        public IActionResult productosaccesorios()
        {
            return View();
        }

        public IActionResult procesadores()
        {
            return View();
        }
        public IActionResult procesadorproducto(){
            return View();
        }

        public IActionResult contactenos()
        {
            return View();
        }

 
        public IActionResult nosotros()
        {
            return View();
        }

        public IActionResult noticias()
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
    }
}
