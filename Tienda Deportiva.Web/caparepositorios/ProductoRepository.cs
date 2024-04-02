﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using Tienda_Deportiva.Entities;

namespace Tienda_Deportiva.caparepositorios
{
    public class ProductoRepository : IProductoRepository
    {
        private readonly TiendaDeportivaDbContext _context;

        public ProductoRepository(TiendaDeportivaDbContext context)
        {
            _context = context;
        }

        public List<Producto> GetAll()
        {
            return _context.Productos.ToList();
        }

        public Producto GetById(int id)
        {
            return _context.Productos.Find(id);
        }

        public void Insert(Producto producto)
        {
            _context.Productos.Add(producto);
            _context.SaveChanges();
        }

        public void Update(Producto producto)
        {
            _context.Productos.Update(producto);
            _context.SaveChanges();
        }

        public void Delete(int id)
        {
            var producto = _context.Productos.Find(id);
            if (producto != null)
            {
                _context.Productos.Remove(producto);
                _context.SaveChanges();
            }
        }
    }
}