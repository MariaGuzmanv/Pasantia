using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using Tienda_Deportiva.Entities;

namespace Tienda_Deportiva.capaservicio
{
    public class IClienteService
    {
        List<Cliente> GetAllClientes();
        Cliente GetClienteById(int id);
        void CreateCliente(Cliente cliente);
        void UpdateCliente(Cliente cliente);
        void DeleteCliente(int id);
    }
}