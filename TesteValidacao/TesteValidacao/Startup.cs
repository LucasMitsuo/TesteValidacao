using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(TesteValidacao.Startup))]
namespace TesteValidacao
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}
