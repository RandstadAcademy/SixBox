using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(SixPanel.Startup))]
namespace SixPanel
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}
