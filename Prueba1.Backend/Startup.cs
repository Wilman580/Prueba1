using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(Prueba1.Backend.Startup))]
namespace Prueba1.Backend
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}
