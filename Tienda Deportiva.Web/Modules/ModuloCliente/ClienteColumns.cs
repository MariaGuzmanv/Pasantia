using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace Tienda_Deportiva.Modules.ModuloCliente
{
    public class ClienteColumns
    {
        [ColumnsScript("ClienteModule.Cliente")]
        [BasedOnRow(typeof(ClienteRow), CheckNames = true)]
        public class ClienteColumns
        {
            [EditLink, DisplayName("ID"), AlignRight]
            public int ID_Cliente { get; set; }

            [EditLink, Width(200)]
            public string Nombre { get; set; }

            [Width(200)]
            public string Apellidos { get; set; }

            [Width(200)]
            public string Dirección { get; set; }

            [Width(100)]
            public string Teléfono { get; set; }

            [Width(200)]
            public string Email { get; set; }
        }

    }
}