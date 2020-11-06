using Seccion5WebApi.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;

namespace Seccion5WebApi.Controllers
{
    public class ProductosController : ApiController
    {
        Productos[] productos = new Productos[]
        {
            new Productos { ID = 1, nombre = "Producto1", Categoria = "categoria1", Precio = 3 },
            new Productos { ID = 2, nombre = "Producto2", Categoria = "categoria2", Precio = 4 },
            new Productos { ID = 3, nombre = "Producto3", Categoria = "categoria3", Precio = 5 }
        };


        public ProductosController()
        {

        }

        public IEnumerable<Productos> GetTodosLosProductos()
        {
            return productos;
        }

        public IHttpActionResult GetProducto(int id)
        {
            var producto = productos.FirstOrDefault((p) => p.ID == id);
            if (producto == null)
            {
                return NotFound();
            }
            return Ok(producto);
        }
    }
}
