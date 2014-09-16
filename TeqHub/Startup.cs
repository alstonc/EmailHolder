using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(TeqHub.Startup))]
namespace TeqHub
{
    public partial class Startup {
        public void Configuration(IAppBuilder app) {
            ConfigureAuth(app);
        }
    }
}
