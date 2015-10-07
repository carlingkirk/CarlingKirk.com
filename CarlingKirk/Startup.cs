using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(CarlingKirk.Startup))]
namespace CarlingKirk
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}
