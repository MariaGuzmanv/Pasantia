using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using Tienda_Deportiva.Entities;

namespace Tienda_Deportiva.caparepositorios
{
    public class PedidoRepository : IPedidoRepository
    {
        private readonly TiendaDeportivaDbContext _context;

        public PedidoRepository(TiendaDeportivaDbContext context)
        {
            _context = context;
        }

        public List<Pedido> GetAll()
        {
            return _context.Pedidos.ToList();
        }

        public Pedido GetById(int id)
        {
            return _context.Pedidos.Find(id);
        }

        public void Insert(Pedido pedido)
        {
            _context.Pedidos.Add(pedido);
            _context.SaveChanges();
        }

        public void Update(Pedido pedido)
        {
            _context.Pedidos.Update(pedido);
            _context.SaveChanges();
        }

        public void Delete(int id)
        {
            var pedido = _context.Pedidos.Find(id);
            if (pedido != null)
            {
                _context.Pedidos.Remove(pedido);
                _context.SaveChanges();
            }
        }
    }
}