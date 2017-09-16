using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(Mod10_1.Startup))]
namespace Mod10_1
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}
