using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(Fullstackv2.Startup))]
namespace Fullstackv2
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}
