using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(MembershipOnlineApplication.Startup))]
namespace MembershipOnlineApplication
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}
