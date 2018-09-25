using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(ResidentialHotelMVCWebApp.Startup))]
namespace ResidentialHotelMVCWebApp
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}
