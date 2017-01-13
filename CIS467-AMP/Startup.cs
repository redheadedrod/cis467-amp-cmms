using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(CIS467_AMP.Startup))]
namespace CIS467_AMP
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}
