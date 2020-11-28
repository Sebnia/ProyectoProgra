using System;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.AspNetCore.Mvc.Rendering;
using System.Collections.Generic;

namespace ProyectoProgra.Models
{
    public class RegistrarUsu
    {
        
            [StringLength(8, ErrorMessage = "Ingrese un DNI valido", MinimumLength = 8)]
            [RegularExpression("^[0-9]*$", ErrorMessage = "* Solo se permiten números.")]
            [Required(ErrorMessage = "Por favor ingrese su DNI")]            
             public String dni { get; set;}

            [Required(ErrorMessage = "Por favor ingrese su nombre")]            
            public String Name { get; set;}

            [Required(ErrorMessage = "Por favor ingrese su apellido")]            
            public String Lastname {get; set;}

            [Required(ErrorMessage = "Por favor ingrese su Email")]
            [EmailAddress(ErrorMessage = "Por favor ingrese un Email válido")]      
            public String Email {get; set;}
            
            [Required(ErrorMessage = "Por favor ingrese su distrito")]            
            [Display(Name="Distrito")]
            public String District {get; set;}

            [NotMapped]
            public List<SelectListItem> Districts { get; } = new List<SelectListItem>
            {

            
            new SelectListItem { Value = "Ancon", Text = "Ancon" },
            new SelectListItem { Value = "Ate", Text = "Ate Vitarte" },
            new SelectListItem { Value = "Barranco", Text = "Barranco"  },
            new SelectListItem { Value = "Breña", Text = "Breña"  },
            new SelectListItem { Value = "Carabayllo", Text = "Carabayllo"  },
            new SelectListItem { Value = "Chaclacayo", Text = "Chaclacayo"  },
            new SelectListItem { Value = "Chorrillos", Text = "Chorrillos"  },
            new SelectListItem { Value = "Cieneguilla", Text = "Cieneguilla"  },
            new SelectListItem { Value = "Comas", Text = "Comas"  },
            new SelectListItem { Value = "El Agustino", Text = "El Agustino" },
            new SelectListItem { Value = "Independencia", Text = "Independencia" },
            new SelectListItem { Value = "Jesús María", Text = "Jesús María" },
            new SelectListItem { Value = "La Molina", Text = "La Molina" },
            new SelectListItem { Value = "Lince", Text = "Lince" },
            new SelectListItem { Value = "Los Olivos", Text = "Los Olivos" },
            new SelectListItem { Value = "Lurigancho", Text = "Lurigancho" },
            new SelectListItem { Value = "Lurín", Text = "Lurín" },
            new SelectListItem { Value = "Magdalena del Mar", Text = "Magdalena del Mar" },
            new SelectListItem { Value = "Miraflores", Text = "Miraflores" },
            new SelectListItem { Value = "Pachacamac", Text = "Pachacamac" },
            new SelectListItem { Value = "Pucusana", Text = "Pucusana" },
            new SelectListItem { Value = "Pueblo Libre", Text = "Pueblo Libre" },
            new SelectListItem { Value = "Puente Piedra", Text = "Puente Piedra" },
            new SelectListItem { Value = "Punta Hermosa", Text = "Punta Hermosa" },
            new SelectListItem { Value = "Punta Negra", Text = "Punta Negra" },
            new SelectListItem { Value = "San Bartolo", Text = "San Bartolo" },
            new SelectListItem { Value = "San Borja", Text = "San Borja" },
            new SelectListItem { Value = "San Isidro", Text = "San Isidro" },
            new SelectListItem { Value = "San Juan de Lurigancho", Text = "San Juan de Lurigancho" },
            new SelectListItem { Value = "San Juan de Miraflores", Text = "San Juan de Miraflores" },
            new SelectListItem { Value = "San Luis", Text = "San Luis" },
            new SelectListItem { Value = "San Martín de Porres", Text = "San Martín de Porres" },
            new SelectListItem { Value = "San Miguel", Text = "San Miguel" },
            new SelectListItem { Value = "Santa Anita", Text = "Santa Anita" },
            new SelectListItem { Value = "Santa María del Mar", Text = "Santa María del Mar" },
            new SelectListItem { Value = "Santa Rosa", Text = "Santa Rosa" },
            new SelectListItem { Value = "Santiago de Surco", Text = "Santiago de Surco" },
            new SelectListItem { Value = "Surquillo", Text = "Surquillo" },
            new SelectListItem { Value = "Villa El Salvador", Text = "Villa El Salvador" },
            new SelectListItem { Value = "Villa María del Triunfo", Text = "Villa María del Triunfo" },

            
            };


            [Required(ErrorMessage = "Por favor ingrese una contraseña")]
            [DataType(DataType.Password)]
            public String Password { get; set;}

            [Required(ErrorMessage = "Por favor confirme su contraseña")]
            [Compare("Password", ErrorMessage = "Las contraseñas no coinciden")]
            [DataType(DataType.Password)]
            public String VerifiedPassword { get; set;}


            [NotMapped]
            public String Response { get; set; }        

            [Display(Name = "Deseo recibir correos promocionales")]
            public bool spam { get; set; }


    }
}