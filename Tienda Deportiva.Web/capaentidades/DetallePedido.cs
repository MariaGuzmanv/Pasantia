using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Tienda_Deportiva.capaentidades
{
    [Table("Detalles_Pedido")]
    public class DetallePedido
    {
        [Key]
        public int ID_Detalle { get; set; }

        [Required]
        public int ID_Pedido { get; set; }

        [Required]
        public int ID_Producto { get; set; }

        [Required]
        public int Cantidad { get; set; }

        [Required]
        public decimal Precio_Unitario { get; set; }

        [ForeignKey("ID_Pedido")]
        public Pedido Pedido { get; set; }

        [ForeignKey("ID_Producto")]
        public Producto Producto { get; set; }
    }
}