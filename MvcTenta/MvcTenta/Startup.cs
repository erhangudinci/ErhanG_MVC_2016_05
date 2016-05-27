using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(MvcTenta.Startup))]
namespace MvcTenta
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}
