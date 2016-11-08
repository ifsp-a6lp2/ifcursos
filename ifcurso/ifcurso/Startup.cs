using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(ifcurso.Startup))]
namespace ifcurso
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}
