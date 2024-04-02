using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using Tienda_Deportiva.Entities;
using Tienda_Deportiva.Repositories;

namespace Tienda_Deportiva.capaservicio
{
    public class ProductoService : IProductoService
    {
        private readonly IProductoRepository _productoRepository;

        public ProductoService(IProductoRepository productoRepository)
        {
            _productoRepository = productoRepository;
        }

        public List<Producto> GetAllProductos()
        {
            return _productoRepository.GetAll();
        }

        public Producto GetProductoById(int id)
        {
            return _productoRepository.GetById(id);
        }

        public void CreateProducto(Producto producto)
        {
            // Validar que los campos requeridos no estén vacíos
            if (string.IsNullOrEmpty(producto.Nombre) || producto.Precio <= 0)
            {
                throw new ArgumentException("El campo Nombre es obligatorio y el Precio debe ser mayor a cero.");
            }

            // Verificar si ya existe un producto con el mismo nombre
            if (_productoRepository.GetByNombre(producto.Nombre) != null)
            {
                throw new ArgumentException("Ya existe un producto con el mismo nombre.");
            }

            _productoRepository.Insert(producto);
        }

        public void UpdateProducto(Producto producto)
        {
            // Validar que los campos requeridos no estén vacíos
            if (string.IsNullOrEmpty(producto.Nombre) || producto.Precio <= 0)
            {
                throw new ArgumentException("El campo Nombre es obligatorio y el Precio debe ser mayor a cero.");
            }

            _productoRepository.Update(producto);
        }

        public void DeleteProducto(int id)
        {
            // Verificar si existe el producto antes de eliminarlo
            if (_productoRepository.GetById(id) == null)
            {
                throw new ArgumentException("El producto no existe.");
            }

            _productoRepository.Delete(id);
        }
    }
}