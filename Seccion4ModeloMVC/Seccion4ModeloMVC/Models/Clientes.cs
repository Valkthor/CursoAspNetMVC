using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;
using System.ComponentModel.DataAnnotations;

namespace Seccion4ModeloMVC.Models
{
    public class Clientes
    {
        public int ID { get; set; }
        
        // maximo 60 caracteres, y minimo 3
        [StringLength (60, MinimumLength =3)]
        public string nombre { get; set; }

        [DisplayFormat(DataFormatString = "{0:yyyy-MM-dd}", ApplyFormatInEditMode = true)]
        [Display (Name = "Fecha de Alta")]
        [DataType (DataType.Date)]
        public DateTime FechaAlta { get; set; }

        [Range (18, 75)]
        public int edad { get; set; }
    }
}