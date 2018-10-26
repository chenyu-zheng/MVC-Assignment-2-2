using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(MVC_Assignment_2_2.Startup))]
namespace MVC_Assignment_2_2
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}
