using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(SecureAuth.Startup))]
namespace SecureAuth
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}
