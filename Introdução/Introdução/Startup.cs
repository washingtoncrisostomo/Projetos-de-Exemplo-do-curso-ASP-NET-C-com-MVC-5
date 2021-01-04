using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(Introdução.Startup))]
namespace Introdução
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}
