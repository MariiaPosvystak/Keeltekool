using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(Keeltekool.Startup))]
namespace Keeltekool
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}
