using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace Seccion7BootstrapMVC.Controllers
{
    public class PaisesJQueryController : Controller
    {
        // GET: PaisesJQuery
        public ActionResult Index()
        {
            //return View();

            List<string> lista = new List<string>();
            lista.Add("Seleccionar");
            lista.Add("España");
            lista.Add("gringolandia");
            lista.Add("alemania");


            SelectList paises = new SelectList(lista);
            ViewData["paises"] = paises;

            return View();
        }

        public JsonResult Provincias(string Pais)
        {
            List<string> ListProv = new List<string>();
            switch (Pais)
            {
                case "España":
                    ListProv.Add("provincia1");
                    ListProv.Add("provincia2");
                    break;
                case "gringolandia":
                    ListProv.Add("provincia3");
                    ListProv.Add("provincia4");
                    break;
                case "alemania":
                    ListProv.Add("provincia5");
                    ListProv.Add("provincia6");
                    break;
            }

            return Json(ListProv);
        }

    }
}