using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace Tienda_Deportiva.Modules.ModuloProducto
{
    public class ProductoForm
    {
        [FormScript("ProductoModule.Producto")]
        [BasedOnRow(typeof(ProductoRow), CheckNames = true)]
        public class ProductoForm
        {
            public string Nombre { get; set; }
            public string Descripción { get; set; }
            public decimal Precio { get; set; }
            public int Stock { get; set; }
        }

    }
}