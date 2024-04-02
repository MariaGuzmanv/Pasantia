using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace Tienda_Deportiva.Modules.ModuloCliente
{
    public class ClienteForm
    {
        [FormScript("ClienteModule.Cliente")]
        [BasedOnRow(typeof(ClienteRow), CheckNames = true)]
        public class ClienteForm
        {
            public string Nombre { get; set; }
            public string Apellidos { get; set; }
            public string Dirección { get; set; }
            public string Teléfono { get; set; }
            public string Email { get; set; }
        }

    }
}