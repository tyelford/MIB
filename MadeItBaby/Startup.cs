using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(MadeItBaby.Startup))]
namespace MadeItBaby
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}
