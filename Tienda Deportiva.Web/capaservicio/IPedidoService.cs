using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using Tienda_Deportiva.Entities;

namespace Tienda_Deportiva.capaservicio
{
    public class IPedidoService
    {
        List<Pedido> GetAllPedidos();
        Pedido GetPedidoById(int id);
        void CreatePedido(Pedido pedido);
        void UpdatePedido(Pedido pedido);
        void DeletePedido(int id);
    }
}