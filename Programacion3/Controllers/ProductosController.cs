using Microsoft.AspNetCore.Mvc;
using Programacion3.API.Services;

namespace Programacion3.API.Controllers
{
    [ApiController]
    [Route("api/productos")]
    public class ProductosController : ControllerBase
    {
        private readonly IProductoService _productoService;

        public ProductosController(IProductoService productoService)
        {
            _productoService = productoService;
        }

        [HttpGet]
        public IActionResult ObtenerProductos()
        {
            var productos = _productoService.ObtenerTodos();

            return Ok(productos);
        }

        [HttpGet("{id}")]
        public IActionResult ObtenerProductoPorId(int id)
        {
            var producto = _productoService.ObtenerPorId(id);

            if (producto == null)
            {
                return NotFound();
            }

            return Ok(producto);
        }

    }
}
