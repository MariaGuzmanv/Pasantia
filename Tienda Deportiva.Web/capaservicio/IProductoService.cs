using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using Tienda_Deportiva.Entities;

namespace Tienda_Deportiva.capaservicio
{
    public class IProductoService
    {
        List<Producto> GetAllProductos();
        Producto GetProductoById(int id);
        void CreateProducto(Producto producto);
        void UpdateProducto(Producto producto);
        void DeleteProducto(int id);
    }
}