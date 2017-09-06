using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(agrigit.Startup))]
namespace agrigit
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}
