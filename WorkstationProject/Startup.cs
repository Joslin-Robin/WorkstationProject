using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(WorkstationProject.Startup))]
namespace WorkstationProject
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}
