using RegistroMVC.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace RegistroMVC.Controllers
{
    public class HomeController : Controller
    {
        // GET: Home
        public ActionResult Index()
        {
            return View();
        }

        [HttpPost]
        public ActionResult Index(Registro obj)
        {
            if (ModelState.IsValid)
            {
                Seccion6FormsEntities db = new Seccion6FormsEntities();
                db.Registroes.Add(obj);
                db.SaveChanges();
            }
            return View(obj);
        }
    }
}