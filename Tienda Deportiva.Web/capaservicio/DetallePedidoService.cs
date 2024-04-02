using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using Tienda_Deportiva.Entities;
using Tienda_Deportiva.Repositories;

namespace Tienda_Deportiva.capaservicio
{
    public class DetallePedidoService : IDetallePedidoService
    {
        private readonly IDetallePedidoRepository _detallePedidoRepository;
        private readonly IPedidoRepository _pedidoRepository;
        private readonly IProductoRepository _productoRepository;

        public DetallePedidoService(IDetallePedidoRepository detallePedidoRepository, IPedidoRepository pedidoRepository, IProductoRepository productoRepository)
        {
            _detallePedidoRepository = detallePedidoRepository;
            _pedidoRepository = pedidoRepository;
            _productoRepository = productoRepository;
        }

        public List<DetallePedido> GetAllDetallesPedido()
        {
            return _detallePedidoRepository.GetAll();
        }

        public DetallePedido GetDetallePedidoById(int id)
        {
            return _detallePedidoRepository.GetById(id);
        }

        public void CreateDetallePedido(DetallePedido detallePedido)
        {
            // Validar que los campos requeridos no estén vacíos
            if (detallePedido.ID_Pedido <= 0 || detallePedido.ID_Producto <= 0 || detallePedido.Cantidad <= 0)
            {
                throw new ArgumentException("Los campos ID_Pedido, ID_Producto y Cantidad son obligatorios.");
            }

            // Verificar si existe el pedido asociado al detalle
            if (_pedidoRepository.GetById(detallePedido.ID_Pedido) == null)
            {
                throw new ArgumentException("El pedido asociado al detalle no existe.");
            }

            // Verificar si existe el producto asociado al detalle
            if (_productoRepository.GetById(detallePedido.ID_Producto) == null)
            {
                throw new ArgumentException("El producto asociado al detalle no existe.");
            }

            _detallePedidoRepository.Insert(detallePedido);
        }

        public void UpdateDetallePedido(DetallePedido detallePedido)
        {
            // Validar que los campos requeridos no estén vacíos
            if (detallePedido.ID_Pedido <= 0 || detallePedido.ID_Producto <= 0 || detallePedido.Cantidad <= 0)
            {
                throw new ArgumentException("Los campos ID_Pedido, ID_Producto y Cantidad son obligatorios.");
            }

            // Verificar si existe el pedido asociado al detalle
            if (_pedidoRepository.GetById(detallePedido.ID_Pedido) == null)
            {
                throw new ArgumentException("El pedido asociado al detalle no existe.");
            }

            // Verificar si existe el producto asociado al detalle
            if (_productoRepository.GetById(detallePedido.ID_Producto) == null)
            {
                throw new ArgumentException("El producto asociado al detalle no existe.");
            }

            _detallePedidoRepository.Update(detallePedido);
        }

        public void DeleteDetallePedido(int id)
        {
            // Verificar si existe el detalle del pedido antes de eliminarlo
            if (_detallePedidoRepository.GetById(id) == null)
            {
                throw new ArgumentException("El detalle del pedido no existe.");
            }

            _detallePedidoRepository.Delete(id);
        }
    }
}