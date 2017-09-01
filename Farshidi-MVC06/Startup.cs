using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(Farshidi_MVC06.Startup))]
namespace Farshidi_MVC06
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}
