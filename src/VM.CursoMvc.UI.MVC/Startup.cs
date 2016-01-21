using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(VM.CursoMvc.UI.MVC.Startup))]
namespace VM.CursoMvc.UI.MVC
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}
