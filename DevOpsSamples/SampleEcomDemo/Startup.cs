using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(SampleEcomDemo.Startup))]
namespace SampleEcomDemo
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}
