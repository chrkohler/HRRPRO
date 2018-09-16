using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(SISTEMAHRR.Startup))]
namespace SISTEMAHRR
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}
