using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(ContactManagementSimplifiedMVCAuthenticatedWebApi.Startup))]
namespace ContactManagementSimplifiedMVCAuthenticatedWebApi
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}
