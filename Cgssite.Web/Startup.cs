using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(Cgssite.Web.Startup))]
namespace Cgssite.Web
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}
