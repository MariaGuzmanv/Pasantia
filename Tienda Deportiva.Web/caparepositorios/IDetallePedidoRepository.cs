using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using Tienda_Deportiva.Entities;

namespace Tienda_Deportiva.caparepositorios
{
    public class IDetallePedidoRepository
    {
        List<DetallePedido> GetAll();
        DetallePedido GetById(int id);
        void Insert(DetallePedido detallePedido);
        void Update(DetallePedido detallePedido);
        void Delete(int id);
    }
}