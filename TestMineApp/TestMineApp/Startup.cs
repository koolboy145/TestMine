using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(TestMineApp.Startup))]
namespace TestMineApp
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}
