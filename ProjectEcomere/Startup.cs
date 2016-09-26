using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(ProjectEcomere.Startup))]
namespace ProjectEcomere
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}
