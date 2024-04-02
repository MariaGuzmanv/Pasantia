using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using Tienda_Deportiva.Entities;

namespace Tienda_Deportiva.capaservicio
{
    public class IDetallePedidoService
    {
        List<DetallePedido> GetAllDetallesPedido();
        DetallePedido GetDetallePedidoById(int id);
        void CreateDetallePedido(DetallePedido detallePedido);
        void UpdateDetallePedido(DetallePedido detallePedido);
        void DeleteDetallePedido(int id);
    }
}