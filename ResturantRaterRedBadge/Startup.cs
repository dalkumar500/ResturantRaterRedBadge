using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(ResturantRaterRedBadge.Startup))]
namespace ResturantRaterRedBadge
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}
