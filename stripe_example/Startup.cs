using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(stripe_example.Startup))]
namespace stripe_example
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}
