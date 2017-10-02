using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(Tiqri.AMS.Web.Startup))]
namespace Tiqri.AMS.Web
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}
