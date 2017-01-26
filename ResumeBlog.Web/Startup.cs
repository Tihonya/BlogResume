using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(ResumeBlog.Web.Startup))]
namespace ResumeBlog.Web
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}
