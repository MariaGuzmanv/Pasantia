using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using Tienda_Deportiva.Entities;

namespace Tienda_Deportiva.caparepositorios
{
    public class IProductoRepository
    {
        List<Producto> GetAll();
        Producto GetById(int id);
        void Insert(Producto producto);
        void Update(Producto producto);
        void Delete(int id);
    }
}