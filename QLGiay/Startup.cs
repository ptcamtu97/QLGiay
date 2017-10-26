using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(QLGiay.Startup))]
namespace QLGiay
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}
