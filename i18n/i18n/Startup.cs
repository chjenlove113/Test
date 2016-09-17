using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(i18n.Startup))]
namespace i18n
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}
