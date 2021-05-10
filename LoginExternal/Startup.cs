using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(LoginExternal.Startup))]
namespace LoginExternal
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}
