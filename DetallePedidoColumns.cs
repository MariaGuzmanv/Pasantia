
namespace Sport.Usuario.Columns
{
    using Serenity;
    using Serenity.ComponentModel;
    using Serenity.Data;
    using System;
    using System.ComponentModel;
    using System.Collections.Generic;
    using System.IO;

    [ColumnsScript("Usuario.DetallePedido")]
    [BasedOnRow(typeof(Entities.DetallePedidoRow), CheckNames = true)]
    public class DetallePedidoColumns
    {
        [EditLink, DisplayName("Db.Shared.RecordId"), AlignRight]
        public Int32 IdDetalle { get; set; }
        public String IdPedidoEstado { get; set; }
        public String IdProductoProducto { get; set; }
        public Int64 Cantidad { get; set; }
        public Int32 Precio { get; set; }
        public Int64 SubTotal { get; set; }
    }
}