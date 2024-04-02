using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using Tienda_Deportiva.Entities;
using Tienda_Deportiva.Repositories;

namespace Tienda_Deportiva.capaservicio
{
    public class PedidoService : IPedidoService
    {
        private readonly IPedidoRepository _pedidoRepository;
        private readonly IClienteRepository _clienteRepository;

        public PedidoService(IPedidoRepository pedidoRepository, IClienteRepository clienteRepository)
        {
            _pedidoRepository = pedidoRepository;
            _clienteRepository = clienteRepository;
        }

        public List<Pedido> GetAllPedidos()
        {
            return _pedidoRepository.GetAll();
        }

        public Pedido GetPedidoById(int id)
        {
            return _pedidoRepository.GetById(id);
        }

        public void CreatePedido(Pedido pedido)
        {
            // Validar que los campos requeridos no estén vacíos
            if (pedido.ID_Cliente <= 0 || pedido.Fecha_Pedido == DateTime.MinValue)
            {
                throw new ArgumentException("El campo ID_Cliente y Fecha_Pedido son obligatorios.");
            }

            // Verificar si existe el cliente asociado al pedido
            if (_clienteRepository.GetById(pedido.ID_Cliente) == null)
            {
                throw new ArgumentException("El cliente asociado al pedido no existe.");
            }

            _pedidoRepository.Insert(pedido);
        }

        public void UpdatePedido(Pedido pedido)
        {
            // Validar que los campos requeridos no estén vacíos
            if (pedido.ID_Cliente <= 0 || pedido.Fecha_Pedido == DateTime.MinValue)
            {
                throw new ArgumentException("El campo ID_Cliente y Fecha_Pedido son obligatorios.");
            }

            // Verificar si existe el cliente asociado al pedido
            if (_clienteRepository.GetById(pedido.ID_Cliente) == null)
            {
                throw new ArgumentException("El cliente asociado al pedido no existe.");
            }

            _pedidoRepository.Update(pedido);
        }

        public void DeletePedido(int id)
        {
            // Verificar si existe el pedido antes de eliminarlo
            if (_pedidoRepository.GetById(id) == null)
            {
                throw new ArgumentException("El pedido no existe.");
            }

            _pedidoRepository.Delete(id);
        }
    }
}