using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace Tienda_Deportiva.Modules.ModuloProducto
{
    public class ProductoGrid
    {
        [EnumKey("ProductoModule.Producto")]
        [ColumnsKey("ProductoModule.Producto")]
        [FormKey("ProductoModule.Producto")]
        public class ProductoGrid : EntityGrid<ProductoRow, ProductoRow.RowFields>
        {
            public ProductoGrid(IServiceProvider serviceProvider)
                : base(serviceProvider)
            {
                Title = "Productos";
                InitEntityType(typeof(ProductoRow));
            }
        }

    }
}