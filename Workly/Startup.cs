using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(Workly.Startup))]
namespace Workly
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}
