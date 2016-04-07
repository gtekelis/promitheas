using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(AdministrationMVC.Startup))]
namespace AdministrationMVC
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}
