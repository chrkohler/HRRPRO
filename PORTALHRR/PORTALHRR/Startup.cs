using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(PORTALHRR.Startup))]
namespace PORTALHRR
{
    public partial class Startup {
        public void Configuration(IAppBuilder app) {
            ConfigureAuth(app);
        }
    }
}
