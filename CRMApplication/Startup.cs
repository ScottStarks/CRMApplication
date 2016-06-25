using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(CRMApplication.Startup))]
namespace CRMApplication
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}
