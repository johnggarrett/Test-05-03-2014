using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(TestMVC5.Startup))]
namespace TestMVC5
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}
