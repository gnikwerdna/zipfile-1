using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(zip.Startup))]
namespace zip
{
    public partial class Startup {
        public void Configuration(IAppBuilder app) {
            ConfigureAuth(app);
        }
    }
}
