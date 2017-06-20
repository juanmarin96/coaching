using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(C4W.Web.Startup))]
namespace C4W.Web
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}
