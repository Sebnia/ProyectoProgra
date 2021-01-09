using System;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.AspNetCore.Mvc.Rendering;
using System.Collections.Generic;
using System.ComponentModel;
using Microsoft.AspNetCore.Http;

namespace ProyectoProgra.Models
{
    [Table("t_producto")]
    public class Producto
    {
            [Column("id")]
            public int ID {get; set;}

            [Column("idProduct")]
            public String idProduct {get; set;}

            [Required]
            [Column("nameProduct")]
            [Display(Name = "Nombre del Producto")]
            public String nameProduct {get; set;}
        
            [Required]
            [Column("priceProduct")]
            [Display(Name = "Precio del Producto")]
            public Double priceProduct {get; set;}

            [Required]
            [Column("describeProduct")]
            [Display(Name = "Descripción del Producto")]
            public String describeProduct {get; set;}

            [Required]
            [Column("specifyProduct")]
            [Display(Name = "Especificación del Producto")]
            public String specifyProduct {get; set;}

            [Required]
            [DisplayName("Category")]
            [Column("category")]
            [Display(Name = "Categoría del Producto")]
            public String category {get; set;}

            [NotMapped]
            public List<SelectListItem> categories { get;} = new List<SelectListItem>
            {
            
            new SelectListItem { Value = "RAM", Text = "RAM" },
            new SelectListItem { Value = "Computadora", Text = "Computadora" },
            new SelectListItem { Value = "Laptop", Text = "Laptop"  },
            new SelectListItem { Value = "Periferico", Text = "Periferico"  },
            new SelectListItem { Value = "ROM", Text = "ROM"  },
            new SelectListItem { Value = "Placa Madre", Text = "Placa Madre"  },
            new SelectListItem { Value = "Procesador", Text = "Procesador" },
            new SelectListItem { Value = "Tarjeta de Video", Text = "Tarjeta de Video" },
            new SelectListItem { Value = "Otros", Text = "Otros"}
            };

            [Column("rootImageProduct")]
            public string rootImageProduct { get; set; }

            [NotMapped]
            [DisplayName("Subir imagen")]
            public IFormFile imageFile { get; set; }
            
            [NotMapped]
            public String Response { get; set; }


    }
}