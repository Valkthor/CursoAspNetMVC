using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace Seccion4ModeloMVC.Models
{
    public class Clientes
    {
        public int ID { get; set; }
        public string nombre { get; set; }

        [DisplayFormat(DataFormatString = "{0:yyyy-MM-dd}", ApplyFormatInEditMode = true)]
        public DateTime FechaAlta { get; set; }
        public int edad { get; set; }
    }
}