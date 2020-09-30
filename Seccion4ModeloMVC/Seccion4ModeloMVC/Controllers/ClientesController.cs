using Seccion4ModeloMVC.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace Seccion4ModeloMVC.Controllers
{
    public class ClientesController : Controller
    {
        public static List<Clientes> empList = new List<Clientes>
        {
            new Clientes{
                ID=1,
                nombre="nombre3",
                FechaAlta=DateTime.Parse(DateTime.Today.ToString()),
                edad=41
            },
            new Clientes{
                ID=2,
                nombre="nombre4",
                FechaAlta=DateTime.Parse(DateTime.Today.ToString()),
                edad=35
            },
        };

        private EmpDBContext db = new EmpDBContext();
        // GET: Clientes
        public ActionResult Index()
        {
            var Clientes = from e in db.Clientes
                           orderby e.ID
                           select e;
            return View(Clientes);
        }

        // GET: Clientes/Details/5
        public ActionResult Details(int id)
        {
            return View();
        }

        // GET: Clientes/Create
        public ActionResult Create()
        {
            return View();
        }

        // POST: Clientes/Create
        // POST: Clientes/Create
        [HttpPost]
        public ActionResult Create(Clientes emp)
        {
            try
            {
                //empList.Add(emp);
                db.Clientes.Add(emp);
                db.SaveChanges();
                return RedirectToAction("Index");
            }
            catch
            {
                return View();
            }
        }

        /*
        FORMA TRADICIONAL CON FORM COLLECTION
        [HttpPost]
        public ActionResult Create(FormCollection collection)
        {
            try
            {
                // TODO: Add insert logic here
                Clientes emp = new Clientes();
                emp.nombre = collection["nombre"];
                DateTime jDate;
                DateTime.TryParse(collection["DOB"], out jDate);
                emp.FechaAlta = jDate;
                string edad = collection["edad"];
                emp.edad = Int32.Parse(edad);
                empList.Add(emp);
                return RedirectToAction("Index");
            }
            catch
            {
                return View();
            }
        }
         */
        // GET: Clientes/Edit/5
        public ActionResult Edit(int id)
        {
            
            var Clientes = db.Clientes.Single(m => m.ID == id);
            return View(Clientes);
        }

        // POST: Clientes/Edit/5
        [HttpPost]
        public ActionResult Edit(int id, FormCollection collection)
        {
            try
            {
                // TODO: Add update logic here
                var cliente = db.Clientes.Single(m => m.ID == id);
                if(TryUpdateModel(cliente))
                {
                    db.SaveChanges();
                    return RedirectToAction("Index");
                }
                return View(cliente);
            }
            catch
            {
                return View();
            }
        }

        // GET: Clientes/Delete/5
        public ActionResult Delete(int id)
        {
            return View();
        }

        // POST: Clientes/Delete/5
        [HttpPost]
        public ActionResult Delete(int id, FormCollection collection)
        {
            try
            {
                // TODO: Add delete logic here

                return RedirectToAction("Index");
            }
            catch
            {
                return View();
            }
        }

        [NonAction]

        public List<Clientes> TodosLosClientes()
        {
            return new List<Clientes>
            {
                new Clientes
                {
                   ID= 1,
                   nombre="nombre1",
                   FechaAlta=DateTime.Parse(DateTime.Today.ToString()),
                   edad=30
                },
                new Clientes
                {
                   ID= 2,
                   nombre="nombre2",
                   FechaAlta=DateTime.Parse(DateTime.Today.ToString()),
                   edad=30
                }
            };
        }
    }
}
