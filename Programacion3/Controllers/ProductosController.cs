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
            try
            {
                var productos = _productoService.ObtenerTodos();
                return Ok(productos);
            }
            catch (Exception)
            {
                return StatusCode(500, "Ocurrió un error interno al consultar los productos.");
            }
        }



        [HttpGet("{id}")]
        public IActionResult ObtenerProductoPorId(int id)
        {
            try
            {
                var producto = _productoService.ObtenerPorId(id);

                if (producto == null)
                {
                    return NotFound();
                }

                return Ok(producto);
            }
            catch (Exception)
            {
                return StatusCode(500, "Ocurrió un error interno al buscar el producto.");
            }
        }


    }
}
