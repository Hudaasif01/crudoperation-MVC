using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(crudoperation_MVC.Startup))]
namespace crudoperation_MVC
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}
