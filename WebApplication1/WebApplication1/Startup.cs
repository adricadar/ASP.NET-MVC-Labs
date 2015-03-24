using Lab2.Web;
using Microsoft.Owin;
using Owin;

[assembly: OwinStartup(typeof(Lab2.Web.Startup))]
namespace Lab2.Web
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}
