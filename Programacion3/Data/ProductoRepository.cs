using Programacion3.API.Models;
using System.Collections.Generic;
using Microsoft.Data.SqlClient;
using Microsoft.Extensions.Configuration;


namespace Programacion3.API.Data
{

    public class ProductoRepository : IProductoRepository
    {
        private readonly string _connectionString;

        public ProductoRepository(IConfiguration configuration)
        {
            _connectionString = configuration.GetConnectionString("ConexionSQL")
                ?? throw new InvalidOperationException("No se encontró la cadena de conexión.");
        }


        public List<Producto> ObtenerTodos()
        {
            List<Producto> productos = new List<Producto>();

            using (SqlConnection conexion = new SqlConnection(_connectionString))
            {
                conexion.Open();

                string consulta = "SELECT Id, Nombre, Precio, Stock FROM Productos";

                using (SqlCommand comando = new SqlCommand(consulta, conexion))
                {
                    using (SqlDataReader lector = comando.ExecuteReader())
                    {
                        while (lector.Read())
                        {
                            Producto producto = new Producto
                            {
                                Id = Convert.ToInt32(lector["Id"]),
                                Nombre = lector["Nombre"].ToString() ?? "",
                                Precio = Convert.ToDecimal(lector["Precio"]),
                                Stock = Convert.ToInt32(lector["Stock"])
                            };

                            productos.Add(producto);
                        }
                    }
                }
            }

            return productos;
        }



        public Producto? ObtenerPorId(int id)
        {
            using (SqlConnection conexion = new SqlConnection(_connectionString))
            {
                conexion.Open();

                string consulta = "SELECT Id, Nombre, Precio, Stock FROM Productos WHERE Id = @Id";

                using (SqlCommand comando = new SqlCommand(consulta, conexion))
                {
                    comando.Parameters.AddWithValue("@Id", id);

                    using (SqlDataReader lector = comando.ExecuteReader())
                    {
                        if (lector.Read())
                        {
                            return new Producto
                            {
                                Id = Convert.ToInt32(lector["Id"]),
                                Nombre = lector["Nombre"].ToString() ?? "",
                                Precio = Convert.ToDecimal(lector["Precio"]),
                                Stock = Convert.ToInt32(lector["Stock"])
                            };
                        }
                    }
                }
            }

            return null;
        }

    }
}
