using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(MedApp.Web.Startup))]
namespace MedApp.Web
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}
