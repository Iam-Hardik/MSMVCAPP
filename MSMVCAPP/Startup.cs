using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(MSMVCAPP.Startup))]
namespace MSMVCAPP
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}
