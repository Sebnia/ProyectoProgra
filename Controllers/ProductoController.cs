using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;
using ProyectoProgra.Models;
using ProyectoProgra.Data;
using Microsoft.AspNetCore.Http;

namespace ProyectoProgra.Controllers
{
    
    public class ProductoController : Controller
    {

        private readonly ILogger<ProductoController> _logger;
        private readonly ApplicationDbContext _context;


        public ProductoController(ILogger<ProductoController> logger,
            ApplicationDbContext context)
        {
            _logger = logger;
            _context = context;
        }





        public IActionResult Registrar()
        {
                    var ultProducto = _context.Productos.OrderByDescending(c => c.ID).FirstOrDefault();
                    
                    Producto prod = new Producto();

                    string date = DateTime.UtcNow.ToString("MMddyyyy");
                    
                    if (ultProducto == null)
                    {
                        
                    prod.idProduct =  "TEST" + date + "001";
                    } else
                    {
                        
                    prod.idProduct = "TEST" + date + (Convert.ToInt32(ultProducto.idProduct.Substring(12, ultProducto.idProduct.Length - 12)) + 1).ToString("D3");
                    }

            var model = new Producto();
            model.category = " ";
            
            return View(prod);
            
        }

        [HttpPost]
        public IActionResult Registrar(Producto objProducto)
        {

                    


            if(ModelState.IsValid) 
            {
                
                _context.Add(objProducto);
                _context.SaveChanges();
                objProducto.Response = "Producto Insertado Correctamente";

                return RedirectToAction("Lista");

            }

            return View(objProducto);
        }

        public IActionResult Lista()
        {
            var productos = _context.Productos.ToList();

            return View(productos);
        }

        [HttpPost]
        public IActionResult Borrar(String id) {

            var producto = _context.Productos.FirstOrDefault(x => x.idProduct == id);

            _context.Remove(producto);
            _context.SaveChanges();

            return RedirectToAction("Lista");
        }




    }
}