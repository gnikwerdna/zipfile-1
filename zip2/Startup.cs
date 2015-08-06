using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(zip2.Startup))]
namespace zip2
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}
