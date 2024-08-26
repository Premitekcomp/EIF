using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(EIF.Startup))]
namespace EIF
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}
