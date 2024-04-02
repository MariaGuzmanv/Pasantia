using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using Tienda_Deportiva.Entities;

namespace Tienda_Deportiva.caparepositorios
{
    public class DetallePedidoRepository : IDetallePedidoRepository
    {
        private readonly TiendaDeportivaDbContext _context;

        public DetallePedidoRepository(TiendaDeportivaDbContext context)
        {
            _context = context;
        }

        public List<DetallePedido> GetAll()
        {
            return _context.DetallesPedido.ToList();
        }

        public DetallePedido GetById(int id)
        {
            return _context.DetallesPedido.Find(id);
        }

        public void Insert(DetallePedido detallePedido)
        {
            _context.DetallesPedido.Add(detallePedido);
            _context.SaveChanges();
        }

        public void Update(DetallePedido detallePedido)
        {
            _context.DetallesPedido.Update(detallePedido);
            _context.SaveChanges();
        }

        public void Delete(int id)
        {
            var detallePedido = _context.DetallesPedido.Find(id);
            if (detallePedido != null)
            {
                _context.DetallesPedido.Remove(detallePedido);
                _context.SaveChanges();
            }
        }
    }
}