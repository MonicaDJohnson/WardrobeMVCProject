using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(WardrobeMVCProject.Startup))]
namespace WardrobeMVCProject
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}
