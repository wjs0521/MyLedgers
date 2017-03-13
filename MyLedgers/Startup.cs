using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(MyLedgers.Startup))]
namespace MyLedgers
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}
