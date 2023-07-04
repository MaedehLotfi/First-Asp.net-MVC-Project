using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(SoulHealth.Startup))]
namespace SoulHealth
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}
