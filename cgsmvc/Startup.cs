using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(cgsmvc.Startup))]
namespace cgsmvc
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}
