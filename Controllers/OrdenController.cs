using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;
using ProyectoProgra.Data;
using ProyectoProgra.Models;

namespace ProyectoProgra.Controllers
{
    public class OrdenController : Controller
    {
        private readonly ILogger<OrdenController> _logger;
        private readonly ApplicationDbContext _context;

        private readonly UserManager<IdentityUser> _um;


        

        public OrdenController(ILogger<OrdenController> logger,  ApplicationDbContext context, UserManager<IdentityUser> um)
        {
            
            _context = context;
            _logger = logger;
            _um = um;
        }
        
        public IActionResult AddToCart(int? Id){
            
            var producto = _context.Productos.Find(Id);

            var OrdenDetail = new OrdenDetail();
            OrdenDetail.producto = producto.ID;
            OrdenDetail.price = producto.priceProduct;
            OrdenDetail.Email = _um.GetUserName(User);
            OrdenDetail.Quantity = 1;
            
            _context.OrdenDetails.Add(OrdenDetail);
            _context.SaveChanges();

            return RedirectToAction("Orden");
        }


        public IActionResult Orden() {

            var user = _um.GetUserName(User);
            TempData["user"] = user;
            var orden = _context.OrdenDetails.Where(x=>x.Email == user).ToList();
            return View(orden);
        }
        
    
    
    
    
    
    }

}