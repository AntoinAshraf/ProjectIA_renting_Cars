using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(ProjectIA_renting_Cars.Startup))]
namespace ProjectIA_renting_Cars
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}
