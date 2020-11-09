namespace EmpleadosMVC2.Migrations
{
    using EmpleadosMVC2.Models;
    using System;
    using System.Data.Entity;
    using System.Data.Entity.Migrations;
    using System.Linq;

    internal sealed class Configuration : DbMigrationsConfiguration<EmpleadosMVC2.Models.EmpleadoDBContext>
    {
        public Configuration()
        {
            AutomaticMigrationsEnabled = false;
        }

        protected override void Seed(EmpleadosMVC2.Models.EmpleadoDBContext context)
        {
            //  This method will be called after migrating to the latest version.

            //  You can use the DbSet<T>.AddOrUpdate() helper extension method 
            //  to avoid creating duplicate seed data.
            context.Empleados.AddOrUpdate(i => i.Nombre,
                new Empleado
                {
                    Nombre = "aaaaa",
                    Antiguedad=20,
                    Edad=36,
                    Categoria= "a"

                },
                new Empleado
                {
                    Nombre = "bbb",
                    Antiguedad = 15,
                    Edad = 40,
                    Categoria="b"

                }

                );
        }
    }
}
