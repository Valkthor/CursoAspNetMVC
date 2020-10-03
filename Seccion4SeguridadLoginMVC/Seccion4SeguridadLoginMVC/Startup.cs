using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(Seccion4SeguridadLoginMVC.Startup))]
namespace Seccion4SeguridadLoginMVC
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}
