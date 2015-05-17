using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(RiskDU_Demo.Startup))]
namespace RiskDU_Demo
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}
