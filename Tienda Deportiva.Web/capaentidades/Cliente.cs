using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Tienda_Deportiva.capaentidades
{
    [Table("Clientes")]
    public class Cliente
    {
        [Key]
        public int ID_Cliente { get; set; }

        [Required]
        public string Nombre { get; set; }

        [Required]
        public string Apellidos { get; set; }

        [Required]
        public string Dirección { get; set; }

        [Required]
        public string Teléfono { get; set; }

        [Required]
        public string Email { get; set; }
    }
}