using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using Tienda_Deportiva.Entities;
using Tienda_Deportiva.Repositories;

namespace Tienda_Deportiva.capaservicio
{
    public class ClienteService : IClienteService
    {
        private readonly IClienteRepository _clienteRepository;

        public ClienteService(IClienteRepository clienteRepository)
        {
            _clienteRepository = clienteRepository;
        }

        public List<Cliente> GetAllClientes()
        {
            return _clienteRepository.GetAll();
        }

        public Cliente GetClienteById(int id)
        {
            return _clienteRepository.GetById(id);
        }

        public void CreateCliente(Cliente cliente)
        {
            // Validar que los campos requeridos no estén vacíos
            if (string.IsNullOrEmpty(cliente.Nombre) || string.IsNullOrEmpty(cliente.Apellidos) || string.IsNullOrEmpty(cliente.Email))
            {
                throw new ArgumentException("Los campos Nombre, Apellidos y Email son obligatorios.");
            }

            // Validar el formato del email
            if (!IsValidEmail(cliente.Email))
            {
                throw new ArgumentException("El formato del email no es válido.");
            }

            // Verificar si ya existe un cliente con el mismo email
            if (_clienteRepository.GetByEmail(cliente.Email) != null)
            {
                throw new ArgumentException("Ya existe un cliente con el mismo email.");
            }

            _clienteRepository.Insert(cliente);
        }

        public void UpdateCliente(Cliente cliente)
        {
            // Validar que los campos requeridos no estén vacíos
            if (string.IsNullOrEmpty(cliente.Nombre) || string.IsNullOrEmpty(cliente.Apellidos) || string.IsNullOrEmpty(cliente.Email))
            {
                throw new ArgumentException("Los campos Nombre, Apellidos y Email son obligatorios.");
            }

            // Validar el formato del email
            if (!IsValidEmail(cliente.Email))
            {
                throw new ArgumentException("El formato del email no es válido.");
            }

            _clienteRepository.Update(cliente);
        }

        public void DeleteCliente(int id)
        {
            // Verificar si existe el cliente antes de eliminarlo
            if (_clienteRepository.GetById(id) == null)
            {
                throw new ArgumentException("El cliente no existe.");
            }

            _clienteRepository.Delete(id);
        }

        private bool IsValidEmail(string email)
        {
            // Lógica para validar el formato del email
            // Puedes usar una expresión regular o alguna librería de validación de email
            // Aquí se muestra un ejemplo simple
            return email.Contains("@");
        }

    }
}