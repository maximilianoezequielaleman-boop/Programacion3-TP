using Programacion3.API.Models;
using System.Collections.Generic;

namespace Programacion3.API.Services
{
    public interface IProductoService
    {
        List<Producto> ObtenerTodos();

        Producto? ObtenerPorId(int id);
    }
}