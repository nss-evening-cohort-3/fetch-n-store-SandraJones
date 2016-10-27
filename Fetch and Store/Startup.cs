using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(Fetch_and_Store.Startup))]
namespace Fetch_and_Store
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}
