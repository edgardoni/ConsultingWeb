using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(Aplika.Consulting.Web.Startup))]
namespace Aplika.Consulting.Web
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}
