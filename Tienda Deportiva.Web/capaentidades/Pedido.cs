using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Tienda_Deportiva.capaentidades
{
    [Table("Pedidos")]
    public class Pedido
    {
        [Key]
        public int ID_Pedido { get; set; }

        [Required]
        public int ID_Cliente { get; set; }

        [Required]
        public DateTime Fecha_Pedido { get; set; }

        [Required]
        public string Estado_Pedido { get; set; }

        [ForeignKey("ID_Cliente")]
        public Cliente Cliente { get; set; }
    }
}