using System;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.AspNetCore.Mvc.Rendering;
using System.Collections.Generic;

namespace ProyectoProgra.Models
{
    [Table("t_contacto")]
    public class Contacto
    {

        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        [Column("id")]
        public int ID { get; set; }

        
            [StringLength(8, ErrorMessage = "Ingrese un DNI valido", MinimumLength = 8)]
            [RegularExpression("^[0-9]*$", ErrorMessage = "* Solo se permiten números.")]
            [Required(ErrorMessage = "Por favor ingrese su DNI")]   
            [Column("dni")]         
             public String dni { get; set;}

            [Required(ErrorMessage = "Por favor ingrese su nombre")]            
            [Column("name")]
            public String Name { get; set;}

            [Required(ErrorMessage = "Por favor ingrese su apellido")]
            [Column("lastname")]            
            public String Lastname {get; set;}

            [Required(ErrorMessage = "Por favor ingrese su Email")]
            [EmailAddress(ErrorMessage = "Por favor ingrese un Email válido")]     
            [Column("email")] 
            public String Email {get; set;}
            
            [Required(ErrorMessage = "Por favor ingrese su distrito")]            
            [Column("district")]
            public String District {get; set;}

            [DataType(DataType.PhoneNumber)]
            [Required(ErrorMessage = "Por favor ingrese su número telefonico")]
            [Column("phone")]
            public int Phone { get; set; }

            [Required(ErrorMessage = "Por favor ingrese un título")]
            [Column("subject")]
            public String Subject { get; set; }

            [Required(ErrorMessage = "Por favor ingrese su mensaje")]
            [Column("message")]
            public String Message { get; set; }

            [NotMapped]
            public String Response { get; set; }        


    }
}