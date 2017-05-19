using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(PROYECTO_FINAL_PROGRA.Startup))]
namespace PROYECTO_FINAL_PROGRA
{
    public partial class Startup {
        public void Configuration(IAppBuilder app) {
            ConfigureAuth(app);
        }
    }
}
