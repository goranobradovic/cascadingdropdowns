using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(knockout_cascading_dropdowns.Startup))]
namespace knockout_cascading_dropdowns
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}
