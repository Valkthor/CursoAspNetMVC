using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(EmpleadosMVC2.Startup))]
namespace EmpleadosMVC2
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}
