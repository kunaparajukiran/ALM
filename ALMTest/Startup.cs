using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(ALMTest.Startup))]
namespace ALMTest
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}
