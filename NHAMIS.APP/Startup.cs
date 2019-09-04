using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(NHAMIS.APP.Startup))]
namespace NHAMIS.APP
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}
