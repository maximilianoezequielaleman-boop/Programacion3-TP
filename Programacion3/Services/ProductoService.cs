
using Programacion3.API.Models;
using System.Collections.Generic;
using System.Linq;

namespace Programacion3.API.Services
{
    public class ProductoService : IProductoService
    {
        private readonly List<Producto> productos = new()
        {
            new Producto
            {
                Id = 1,
                Nombre = "Teclado",
                Precio = 15000,
                Stock = 10
            },
            new Producto
            {
                Id = 2,
                Nombre = "Mouse",
                Precio = 8500,
                Stock = 20
            },
            new Producto
            {
                Id = 3,
                Nombre = "Monitor",
                Precio = 180000,
                Stock = 5
            }
        };

        public List<Producto> ObtenerTodos()
        {
            return productos;
        }

        public Producto? ObtenerPorId(int id)
        {
            return productos.FirstOrDefault(p => p.Id == id);
        }
    }
}
