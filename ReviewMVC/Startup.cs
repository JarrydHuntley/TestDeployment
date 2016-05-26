using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(ReviewMVC.Startup))]
namespace ReviewMVC
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}
