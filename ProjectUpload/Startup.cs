using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(ProjectUpload.Startup))]
namespace ProjectUpload
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}
