using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(attendence_final.Startup))]
namespace attendence_final
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}
