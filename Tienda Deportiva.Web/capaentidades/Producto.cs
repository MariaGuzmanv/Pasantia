using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Tienda_Deportiva.capaentidades
{
    [Table("Productos")]
    public class Producto
    {
        [Key]
        public int ID_Producto { get; set; }

        [Required]
        public string Nombre { get; set; }

        public string Descripción { get; set; }

        [Required]
        public decimal Precio { get; set; }

        [Required]
        public int Stock { get; set; }
    }
}