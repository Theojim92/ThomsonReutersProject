using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(ThomshonHackathonProject.Startup))]
namespace ThomshonHackathonProject
{
    public partial class Startup {
        public void Configuration(IAppBuilder app) {
            ConfigureAuth(app);
        }
    }
}
