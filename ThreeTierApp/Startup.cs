using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(ThreeTierApp.Startup))]
namespace ThreeTierApp
{
    public partial class Startup {
        public void Configuration(IAppBuilder app) {
            ConfigureAuth(app);
        }
    }
}
