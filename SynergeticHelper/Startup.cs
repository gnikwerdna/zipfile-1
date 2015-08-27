using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(SynergeticHelper.Startup))]
namespace SynergeticHelper
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}
