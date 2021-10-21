using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(QuickNote.WebMVC.Startup))]
namespace QuickNote.WebMVC
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}
