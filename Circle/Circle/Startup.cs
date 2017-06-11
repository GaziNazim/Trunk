using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(Circle.Startup))]
namespace Circle
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}
