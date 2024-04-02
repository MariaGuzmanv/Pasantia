using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace Tienda_Deportiva.Modules.ModuloCliente
{
    public class ClienteGrid
    {
        [EnumKey("ClienteModule.Cliente")]
        [ColumnsKey("ClienteModule.Cliente")]
        [FormKey("ClienteModule.Cliente")]
        public class ClienteGrid : EntityGrid<ClienteRow, ClienteRow.RowFields>
        {
            public ClienteGrid(IServiceProvider serviceProvider)
                : base(serviceProvider)
            {
                Title = "Clientes";
                InitEntityType(typeof(ClienteRow));
            }
        }

    }
}