using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using Tienda_Deportiva.Entities;

namespace Tienda_Deportiva.caparepositorios
{
    public class IPedidoRepository
    {
        List<Pedido> GetAll();
        Pedido GetById(int id);
        void Insert(Pedido pedido);
        void Update(Pedido pedido);
        void Delete(int id);
    }
}