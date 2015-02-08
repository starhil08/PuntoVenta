using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(Version1.Startup))]
namespace Version1
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}
