
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace ProyectoProgra.Models
{

    [Table("t_OrdenDetail")]
    public class OrdenDetail
    {
        [Key]
        public int id {get; set;}
        public int producto {get; set;}

        public string Email {get; set;}

        [Column("quantity")]
        public int Quantity {get; set;}

        [Column("price")]
        public double price {get; set;}

    }
}