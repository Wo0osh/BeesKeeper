using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(BeesKeeper.Startup))]
namespace BeesKeeper
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}
