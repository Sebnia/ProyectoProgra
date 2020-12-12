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
            public String nameProduct {get; set;}
        
            [Required]
            [Column("priceProduct")]
            public Double priceProduct {get; set;}

            [Required]
            [Column("describeProduct")]
            public String describeProduct {get; set;}

            [Required]
            [Column("specifyProduct")]
            public String specifyProduct {get; set;}

            [Required]
            [DisplayName("Category")]
            [Column("category")]
            public String category {get; set;}

            [NotMapped]
            public List<SelectListItem> categories { get;} = new List<SelectListItem>
            {
            
            new SelectListItem { Value = "RAM", Text = "RAM" },
            new SelectListItem { Value = "Computadora", Text = "Computadora" },
            new SelectListItem { Value = "Laptop", Text = "Laptop"  },
            new SelectListItem { Value = "Teclado", Text = "Teclado"  },
            new SelectListItem { Value = "ROM", Text = "ROM"  },
            new SelectListItem { Value = "Monitor", Text = "Monitor"  },
            
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