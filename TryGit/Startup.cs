using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(TryGit.Startup))]
namespace TryGit
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}
