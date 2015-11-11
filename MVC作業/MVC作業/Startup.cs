using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(MVC作業.Startup))]
namespace MVC作業
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}
