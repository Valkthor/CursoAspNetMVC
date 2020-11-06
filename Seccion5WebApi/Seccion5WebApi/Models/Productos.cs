using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace Seccion5WebApi.Models
{
    public class Productos
    {

        public int ID { get; set; }
        public string nombre { get; set; }
        public string Categoria { get; set; }
        public int Precio { get; set; }
    }
}