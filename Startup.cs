using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(Stranica.Startup))]
namespace Stranica
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}
