using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(SecondTaskSupportWebCrew.Startup))]
namespace SecondTaskSupportWebCrew
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}
