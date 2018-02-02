using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(Orange_Hospital.Startup))]
namespace Orange_Hospital
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}
