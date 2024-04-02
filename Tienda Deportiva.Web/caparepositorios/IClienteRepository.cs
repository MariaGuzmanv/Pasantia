using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using Tienda_Deportiva.Entities;

namespace Tienda_Deportiva.caparepositorios
{
    public class IClienteRepository
    {
        List<Cliente> GetAll();
        Cliente GetById(int id);
        void Insert(Cliente cliente);
        void Update(Cliente cliente);
        void Delete(int id);
    }
}