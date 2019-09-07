using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(bracketplusMVC.Startup))]
namespace bracketplusMVC
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}
