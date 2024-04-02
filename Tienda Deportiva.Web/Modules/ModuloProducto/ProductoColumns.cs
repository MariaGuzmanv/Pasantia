using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace Tienda_Deportiva.Modules.ModuloProducto
{
    public class ProductoColumns
    {
        [ColumnsScript("ProductoModule.Producto")]
        [BasedOnRow(typeof(ProductoRow), CheckNames = true)]
        public class ProductoColumns
        {
            [EditLink, DisplayName("ID"), AlignRight]
            public int ID_Producto { get; set; }

            [EditLink, Width(200)]
            public string Nombre { get; set; }

            [Width(300)]
            public string Descripción { get; set; }

            [Width(100), AlignRight]
            public decimal Precio { get; set; }

            [Width(100), AlignRight]
            public int Stock { get; set; }
        }

    }
}