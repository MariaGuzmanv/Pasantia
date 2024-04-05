
namespace Sport.Usuario.Forms
{
    using Serenity;
    using Serenity.ComponentModel;
    using Serenity.Data;
    using System;
    using System.ComponentModel;
    using System.Collections.Generic;
    using System.IO;

    [FormScript("Usuario.DetallePedido")]
    [BasedOnRow(typeof(Entities.DetallePedidoRow), CheckNames = true)]
    public class DetallePedidoForm
    {
        public Int64 IdPedido { get; set; }
        public Int32 IdProducto { get; set; }
        public Int64 Cantidad { get; set; }
        public Int32 Precio { get; set; }
        public Int64 SubTotal { get; set; }
    }
}