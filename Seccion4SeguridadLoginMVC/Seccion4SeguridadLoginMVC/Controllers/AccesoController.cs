using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace Seccion4SeguridadLoginMVC.Controllers
{
    [Authorize]
    public class AccesoController : Controller
    {
       
        public ContentResult Privado()
        {
            return Content("Parte privada");
        }

        [AllowAnonymous]
        public ContentResult Publico()
        {
            return Content("Parte publica");
        }
    }
}