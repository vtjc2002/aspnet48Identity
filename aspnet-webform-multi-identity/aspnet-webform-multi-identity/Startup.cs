using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(aspnet_webform_multi_identity.Startup))]
namespace aspnet_webform_multi_identity
{
    public partial class Startup {
        public void Configuration(IAppBuilder app) {
            ConfigureAuth(app);
        }
    }
}
