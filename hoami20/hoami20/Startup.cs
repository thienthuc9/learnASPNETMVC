using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(hoami20.Startup))]
namespace hoami20
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}
