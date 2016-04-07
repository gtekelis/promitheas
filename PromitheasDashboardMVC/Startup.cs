using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(PromitheasDashboardMVC.Startup))]
namespace PromitheasDashboardMVC
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}
