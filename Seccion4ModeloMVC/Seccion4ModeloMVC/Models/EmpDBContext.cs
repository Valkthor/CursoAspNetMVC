using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Web;

namespace Seccion4ModeloMVC.Models
{
    public class EmpDBContext : DbContext
    {
        public EmpDBContext()
        {

        }

        public DbSet<Clientes> Clientes { get; set; }

    }
}